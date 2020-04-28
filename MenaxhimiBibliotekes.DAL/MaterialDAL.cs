using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.BO;
using System.Data;
using System.Data.SqlClient;

namespace MenaxhimiBibliotekes.DAL
{
    public class MaterialDAL : ICrud<Material>, IConvertToBO<Material>
    {
        private Material material;
        public bool Add(Material obj)
        {
            int MaterialId ;//pusblish house id me kon nullable

            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using ( SqlCommand command = Connection.Command(conn,"usp_CreateMaterial",CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "Title", obj.Title);
                        Connection.AddParameter(command, "GenreId", obj._Genre.GenreId);



                        if (obj.PublishPlace != null)
                        {
                            Connection.AddParameter(command, "PublishHouse", obj._PublishHouse._PublishHouse);
                        }

                        if (obj.PublishPlace != null)
                        {
                            Connection.AddParameter(command, "PlaceOfPublication", obj.PublishPlace);
                        }

                        if (obj.ISBN != null)
                        {
                            Connection.AddParameter(command, "ISBN", obj.ISBN);
                        }

                        Connection.AddParameter(command, "MaterialTypeId", obj._MaterialType.MaterialTypeId);
                        Connection.AddParameter(command, "AvailableCoppies", obj.AvailableCoppies);// ne sql me llogarit

                        Connection.AddParameter(command, "Quantity", obj.Quantity);// nese ne sql egziston mu mbledh kuantiteti

                        if (obj.NumberOfPages != 0)
                        {
                            Connection.AddParameter(command, "NumberOfPages", obj.NumberOfPages);
                        }

                        Connection.AddParameter(command, "Language", obj._Language._Language); // mu konsultu me koleget a me lan ket apo vetem id:D
                        Connection.AddParameter(command, "InsBy", obj.InsBy);
                        Connection.AddParameter(command, "Author", obj._Author.AuthorName);



                        MaterialId = command.ExecuteNonQuery();//me bo ne sql me kthy id te kti produkti qe 
                                                               //te insertojme edhe tek 2 tabelat e ndermjetme.


                        bool isInserted;
                        if (obj.Shelves.Count() > 0)
                        {
                            foreach (var item in obj.Shelves)
                            {
                                isInserted =   insertMaterialLocation(conn, MaterialId,item,obj.InsBy);

                                if (isInserted == false)
                                {
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            return false;
                        }


                    }

                    return true;
                }
            }



            catch (Exception)
            {
                return false;
            }



        }



        public bool insertMaterialLocation(SqlConnection conn, int materialId, Shelf shelf, int insBy)
        {
            int rowaffecte;
            using (SqlCommand command = Connection.Command(conn, "usp_CreateMaterialAuthor", CommandType.StoredProcedure))
            {
                Connection.AddParameter(command, "MaterialId", materialId);
                Connection.AddParameter(command, "RaftiId", shelf.ShelfId);
                Connection.AddParameter(command, "InsBy", insBy);
                rowaffecte = command.ExecuteNonQuery();
            }


            if (rowaffecte > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool Delete(int Id)
        {
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_DeleteMaterial", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "MaterialId", Id);
                        int Affected = command.ExecuteNonQuery();

                        if (Affected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Material obj)
        {
            throw new NotImplementedException();
        }

        public Material Get(int Id)
        {
            try
            {
                material = new Material();
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_GetMaterial", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {

                                material = ToBO(sqr);
                                if (material == null)
                                {
                                    throw new Exception();
                                }


                            }
                            return material;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }



        }

        public Material Get(Material obj)
        {
            throw new NotImplementedException();
        }

        public List<Material> GetAll()
        {
            try
            {
                List<Material> _AllMaterials = new List<Material>();
                material = new Material();
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_GetMaterial", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                while (sqr.Read())
                                {

                                    material = ToBO(sqr);
                                        if (material == null)
                                        {
                                            throw new Exception();
                                        }

                                        //rreshtat e rafteve ne listen brenda materialeve

                                    _AllMaterials.Add(material);


                                    
                                }
                            }
                            return _AllMaterials;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }




        public bool Update(Material obj)
        {
            int MaterialId;

            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    using (SqlCommand command = Connection.Command(conn, "usp_updateMaterial", CommandType.StoredProcedure))
                    {
                        Connection.AddParameter(command, "MaterialId", obj.MaterialId);
                        Connection.AddParameter(command, "Title", obj.Title);
                        Connection.AddParameter(command, "GenreId", obj._Genre.GenreId);



                        if (obj.PublishPlace != null)
                        {
                            Connection.AddParameter(command, "PublishHouse", obj._PublishHouse._PublishHouse);
                        }

                        if (obj.PublishPlace != null)
                        {
                            Connection.AddParameter(command, "PlaceOfPublication", obj.PublishPlace);
                        }

                        if (obj.ISBN != null)
                        {
                            Connection.AddParameter(command, "ISBN", obj.ISBN);
                        }

                        Connection.AddParameter(command, "MaterialType", obj._MaterialType._MaterialType);
                        Connection.AddParameter(command, "AvailableCoppies", obj.AvailableCoppies);// ne sql me llogarit

                        Connection.AddParameter(command, "Quantity", obj.Quantity);// nese ne sql egziston mu mbledh kuantiteti

                        if (obj.NumberOfPages != 0)
                        {
                            Connection.AddParameter(command, "NumberOfPages", obj.NumberOfPages);
                        }

                        Connection.AddParameter(command, "Language", obj._Language._Language); // mu konsultu me koleget a me lan ket apo vetem id:D
                        Connection.AddParameter(command, "UbdBy", obj.UpdBy);







                    }

                    return true;
                }
            }







            catch (Exception)
            {
                return false;
            }
        }

        public Material ToBO(SqlDataReader reader)
        {
            material = new Material();
            try
            {
                 

                material.MaterialId = int.Parse(reader["MaterialId"].ToString());
                material.Title = reader["Title"].ToString();

                material._Genre.GenreId = int.Parse(reader["GenreId"].ToString());// me rregullu edhe ktu
                material._Genre.GenreId= int.Parse(reader["GenreId"].ToString());
                material._Genre._Genre = reader["Genre"].ToString();
                material._Genre.InsBy = int.Parse(reader["GenreInsBy"].ToString());
                material._Genre.InsDate = (DateTime)reader["GenreInsDate"];
                material._Genre.UpdBy = int.Parse(reader["GenreUpdBy"].ToString());
                material._Genre.UpdDate = (DateTime)reader["GenreUpdDate"];
                material._Genre.UpdNo = int.Parse(reader["GenreUpdNo"].ToString());

                if (reader["PublishHouseId"] != DBNull.Value)
                {
                    material._PublishHouse._PublishHouse = reader["PublishHouse"].ToString();
                    material._PublishHouse.PublishHouseId = int.Parse(reader["PublishHouseId"].ToString());
                    material._MaterialType.InsBy = int.Parse(reader["PublishHouseInsBy"].ToString());
                    material._MaterialType.InsDate = (DateTime)reader["PublishHouseInsDate"];
                    material._MaterialType.UpdBy = int.Parse(reader["PublishHouseUpdBy"].ToString());
                    material._MaterialType.UpdDate = (DateTime)reader["PublishHouseUpdDate"];
                    material._MaterialType.UpdNo = int.Parse(reader["PublishHouseUpdNo"].ToString());

                }
                if (reader["PublishYear"] != DBNull.Value)
                {
                    material.PublishYear = (DateTime)reader["PublishYear"];
                }
                if (reader["PlaceOfPublication"] != DBNull.Value)
                {
                    material.PublishPlace = reader["PlaceOfPublication"].ToString();
                }
                if (reader["ISBN"] != DBNull.Value)
                {
                    material.ISBN = reader["ISBN"].ToString();
                }
                material._MaterialType.MaterialTypeId = int.Parse(reader["MaterialTypeId"].ToString());
                material._MaterialType._MaterialType = reader["MaterialType"].ToString();
                material._MaterialType.InsBy = int.Parse(reader["MaterialTypeInsBy"].ToString());
                material._MaterialType.InsDate = (DateTime)reader["MaterialTypeInsDate"];
                material._MaterialType.UpdBy = int.Parse(reader["MaterialTypeUpdBy"].ToString());
                material._MaterialType.UpdDate = (DateTime)reader["MaterialTypeUpdDate"];
                material._MaterialType.UpdNo = int.Parse(reader["MaterialTypeUpdNo"].ToString());


                material.AvailableCoppies = int.Parse(reader["AvailableCoppies"].ToString());
                material.Quantity = int.Parse(reader["Quantitiy"].ToString());

                if (reader["NumberOfPages"] != DBNull.Value)
                {
                    material.NumberOfPages = int.Parse(reader["NumberOfPages"].ToString());
                }

                material._Author.AuthorID = int.Parse(reader["AuthorId"].ToString());

                material._Author.AuthorName = reader["Language"].ToString();

                if (reader["AuthorLastName"] != DBNull.Value)
                {
                    material._Author.AuthorLastName = reader["AuthorName"].ToString();
                }
                material._Author.InsBy = int.Parse(reader["AuthorInsBy"].ToString());
                material._Author.InsDate = (DateTime)reader["AuthorInsDate"];
                material._Author.UpdBy = int.Parse(reader["AuthorUpdBy"].ToString());
                material._Author.UpdDate = (DateTime)reader["AuthorUpdDate"];
                material._Author.UpdNo = int.Parse(reader["AuthorUpdNo"].ToString());


                material._Language.LanguageId = int.Parse(reader["LanguageId"].ToString());
                material._Language._Language = reader["Language"].ToString();
                material._Language.InsBy = int.Parse(reader["LanguageInsBy"].ToString());
                material._Language.InsDate = (DateTime)reader["LanguageInsDate"];
                material._Language.UpdBy = int.Parse(reader["LanguageUpdBy"].ToString());
                material._Language.UpdDate = (DateTime)reader["LanguageUpdDate"];
                material._Language.UpdNo = int.Parse(reader["LanguageUpdNo"].ToString());


                material.IsActive = (bool)reader["IsActive"];

                material.InsBy = int.Parse(reader["InsBy"].ToString());
                material.InsDate = (DateTime)reader["InsDate"];
                material.UpdBy = int.Parse(reader["UpdBy"].ToString());
                material.UpdDate = (DateTime)reader["UpdDate"];
                material.UpdNo = int.Parse(reader["UpdNo"].ToString());
                return material;
            }
            catch (Exception)
            {
                return null;
            }


        }



        public bool UpdateMaterialLocation(SqlConnection conn, int materialId, int currentShelfId, Shelf ml)
        {
            int rowaffecte;
            using (SqlCommand command = Connection.Command(conn, "usp_UpdateMaterialAuthor", CommandType.StoredProcedure))
            {
                Connection.AddParameter(command, "MaterialId", materialId);
                Connection.AddParameter(command, "MaterialId", materialId);
                Connection.AddParameter(command, "RaftiId", ml.ShelfId);
                Connection.AddParameter(command, "updBy", ml.UpdBy);
                rowaffecte = command.ExecuteNonQuery();
            }

            if (rowaffecte > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
