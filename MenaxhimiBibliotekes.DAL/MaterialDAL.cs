using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.BO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.DAL
{
    public class MaterialDAL : ICreate<Material>, IUpdate<Material>, IDelete, IRead<Material>, IConvertToBO<Material>
    {
        private Material material;
        public int Add(Material obj)
        {

           

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_CreateMaterial", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("@Title", obj.Title);

                        command.Parameters.AddWithValue("@GenreId", obj._Genre.GenreId);

                        if (obj.PublishPlace != null)
                        {
                            command.Parameters.AddWithValue("@PublishHouse", obj._PublishHouse._PublishHouse);
                        }

                        if (obj.PublishPlace != null)
                        {
                            command.Parameters.AddWithValue("@PlaceOfPublication", obj.PublishPlace);
                        }

                        if (obj.ISBN.Length > 0)
                        {
                            command.Parameters.AddWithValue("@ISBN", obj.ISBN);
                        }


                        command.Parameters.AddWithValue("@MaterialTypeId", obj._MaterialType.MaterialTypeId);

                        command.Parameters.AddWithValue("@Quantity", obj.Quantity);// nese ne sql egziston mu mbledh kuantiteti

                        if (obj.NumberOfPages > 0)
                        {
                            command.Parameters.AddWithValue("@NumberOfPages", obj.NumberOfPages);
                        }



                        command.Parameters.AddWithValue("@LanguageId", obj._Language.LanguageId);

                        command.Parameters.AddWithValue("@InsBy", obj.InsBy);
                        command.Parameters.AddWithValue("@AuthorName", obj._Author.AuthorName);
                        command.Parameters.AddWithValue("@IsActive", obj.IsActive);
                        command.Parameters.AddWithValue("@ShelfId", obj._Shelf.ShelfId);

                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            return
                                 0;
                        }

                        else
                        {

                            return 1;
                            
                        }

                    }

                


                }
            }



            catch (Exception)
            {
                return -1;
            }



        }






        public int Delete(int Id)
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_DeleteMaterial", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("MaterialiId", Id);
                        int Affected = command.ExecuteNonQuery();

                        if (Affected > 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }

                }
            }
            catch (Exception)
            {

                return -1;
            }
        }



        public Material Get(int Id)
        {
            try
            {
                material = new Material();
                using (SqlConnection conn = DbHelper.GetConnection())
                {

                    using (SqlCommand command = DbHelper.Command(conn, "usp_GetMaterialById", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("MaterialId", Id);

                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.Read())
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


        public List<Material> GetAll()
        {
            try
            {
                List<Material> _AllMaterials = new List<Material>();
                material = new Material();
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_GetMaterial", CommandType.StoredProcedure))
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




        public int Update(Material obj)
        {

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_EditMaterial", CommandType.StoredProcedure))
                    {



                        command.Parameters.AddWithValue("MaterialId", obj.MaterialId);
                        command.Parameters.AddWithValue("GenreId", obj._Genre.GenreId);
                        command.Parameters.AddWithValue("Title", obj.Title);
                        if (obj._PublishHouse.PublishHouseId > 0)
                        {
                            command.Parameters.AddWithValue("PublishHouse", obj._PublishHouse._PublishHouse);
                            command.Parameters.AddWithValue("PublishHouseId", obj._PublishHouse.PublishHouseId);
                        }

                        if (obj.PublishPlace.Length > 0)
                        {
                            command.Parameters.AddWithValue("PlaceOfPublication", obj.PublishPlace);
                        }
                        if (obj.PublishYear != null)
                        {
                            command.Parameters.AddWithValue("@PublicationYear", obj.PublishYear);
                        }
                        if (obj.ISBN.Length > 0)
                        {
                            command.Parameters.AddWithValue("ISBN", obj.ISBN);
                        }


                        command.Parameters.AddWithValue("MaterialTypeId", obj._MaterialType.MaterialTypeId);

                        command.Parameters.AddWithValue("Quantity", obj.Quantity);// nese ne sql egziston mu mbledh kuantiteti

                        if (obj.NumberOfPages > 0)
                        {
                            command.Parameters.AddWithValue("NumberOfPages", obj.NumberOfPages);
                        }
                        command.Parameters.AddWithValue("LanguageId", obj._Language.LanguageId);

                        command.Parameters.AddWithValue("AuthorId", obj._Author.AuthorID);
                        command.Parameters.AddWithValue("Author", obj._Author.AuthorName);
                        command.Parameters.AddWithValue("@AvailableCoppies", obj.AvailableCoppies);
                        command.Parameters.AddWithValue("UpdId", obj.UpdBy);
                        command.Parameters.AddWithValue("IsActive", obj.IsActive);

                        int row= command.ExecuteNonQuery();


                        if (row > 0)
                        {
                            return 1;

                        }
                        else
                        {
                            return -1;
                        }

                    }

                }

            }







            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public Material ToBO(SqlDataReader reader)
        {
            material = new Material();
            try
            {
                 

                material.MaterialId = int.Parse(reader["MaterialId"].ToString());
                material.Title = reader["Title"].ToString();

                material._Genre.GenreId = int.Parse(reader["GenreId"].ToString());
                material.GenreId = int.Parse(reader["GenreId"].ToString());
                material._Genre._Genre = reader["Genre"].ToString();


                if (reader["PublishHouseId"] != DBNull.Value)
                {

                    material._PublishHouse.PublishHouseId = int.Parse(reader["PublishHouseId"].ToString());
                    material.PublishHouseId = int.Parse(reader["PublishHouseId"].ToString());
                    material._PublishHouse._PublishHouse = reader["PublishHouse"].ToString();

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
                material.MaterialTypeId = int.Parse(reader["MaterialTypeId"].ToString());

                material._MaterialType._MaterialType = reader["MaterialType"].ToString();


                material.AvailableCoppies = int.Parse(reader["AvailableCoppies"].ToString());
               material.Quantity = int.Parse(reader["MaterialQuantity"].ToString());

                if (reader["NumberOfPages"] != DBNull.Value)
                {
                    material.NumberOfPages = int.Parse(reader["NumberOfPages"].ToString());
                }

                if (reader["PublishHouseId"] != DBNull.Value)
                {
                    material.PublishHouseId = int.Parse(reader["PublishHouseId"].ToString());
                    material._PublishHouse.PublishHouseId = int.Parse(reader["PublishHouseId"].ToString());
                    material._PublishHouse._PublishHouse = reader["PublishHouse"].ToString();
                }

                material.ShelfId = int.Parse(reader["ShelfId"].ToString());
                material._Shelf.ShelfId = int.Parse(reader["ShelfId"].ToString());
                material._Shelf.Location = reader["Location"].ToString();
                material._Shelf.Quantity = int.Parse(reader["ShelfQuantity"].ToString());
                material._Shelf.Description = reader["Description"].ToString();


                material.AuthorId = int.Parse(reader["AuthorId"].ToString());
                material._Author.AuthorID = int.Parse(reader["AuthorId"].ToString());
                material._Author.AuthorName = reader["AuthorName"].ToString();

                material._Language.LanguageId = int.Parse(reader["LanguageId"].ToString());
                material.LanguageId = int.Parse(reader["LanguageId"].ToString());
                material._Language._Language = reader["Language"].ToString();

                material.IsActive = (bool)reader["IsActive"];

                material.InsBy = int.Parse(reader["InsBy"].ToString());
                material.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    material.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    material.UpdDate = (DateTime)reader["UpdDate"];
                }

                material.UpdNo = int.Parse(reader["UpdNo"].ToString());

                return material;
            }
            catch (Exception)
            {
                return null;
            }


        }




    }
}
