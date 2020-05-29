using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.DAL
{
    public class ReservationDAL : ICreate<Reservation>, IUpdate<Reservation>, IDelete, IRead<Reservation>, IConvertToBO<Reservation>
    {
        Reservation reservation;

        public int Add(Reservation obj)
        {
            int isInserted;
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Reservations_Insert", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("subscriberId", obj.SubscriberId);
                        command.Parameters.AddWithValue("materialId", obj.MaterialId);
                        command.Parameters.AddWithValue("reservationDate", obj.ReservationDate);

                        command.Parameters.AddWithValue("insBy", obj.InsBy);

                        isInserted = command.ExecuteNonQuery();
                        if (isInserted > 0)
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
            catch (Exception)
            {
                MessageBox.Show("Problem me Reservation DAL-in", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
        }

        public int Delete(int Id)
        {
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Reservations_Delete", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("reservationId", Id);
                        int Affected = command.ExecuteNonQuery();
                        if (Affected > 0)
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
            catch (Exception)
            {
                return -1;
            }
        }

        public Reservation Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAll()
        {
            //throw new Exception();
            try
            {
                List<Reservation> _AllReservation = new List<Reservation>();
                reservation = new Reservation();
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    using (SqlCommand command = DbHelper.Command(conn, "usp_Reservations_GetAll", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader sqr = command.ExecuteReader())
                        {
                            if (sqr.HasRows)
                            {
                                while (sqr.Read())
                                {
                                    reservation = ToBO(sqr);
                                    if (reservation == null)
                                    {
                                        throw new Exception();
                                    }

                                    _AllReservation.Add(reservation);
                                }
                            }
                            return _AllReservation;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Reservation ToBO(SqlDataReader reader)
        {
            try
            {
                Reservation reservation = new Reservation();

                reservation.ReservationId = int.Parse(reader["ReservationId"].ToString());
                reservation.SubscriberId = int.Parse(reader["SubscriberId"].ToString());
                reservation.MaterialId = int.Parse(reader["MaterialId"].ToString());
                reservation.ReservationDate = DateTime.Parse(reader["ReservationDate"].ToString());

                reservation.InsBy = int.Parse(reader["InsBy"].ToString());
                reservation.InsDate = (DateTime)reader["InsDate"];

                if (reader["UpdBy"] != DBNull.Value)
                {
                    reservation.UpdBy = int.Parse(reader["UpdBy"].ToString());
                }
                if (reader["UpdDate"] != DBNull.Value)
                {
                    reservation.UpdDate = DateTime.Parse(reader["UpdDate"].ToString());
                }

                reservation.UpdNo = int.Parse(reader["UpdNo"].ToString());

                return reservation;
            }

            catch (Exception)
            {
                MessageBox.Show("Problem me ToBo", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public int Update(Reservation obj)
        {

            int rowsAffected = 0;
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    using (var command = DbHelper.Command(conn, "usp_Reservations_Update", CommandType.StoredProcedure))
                    {
                        command.Parameters.AddWithValue("reservationId", obj.ReservationId);
                        command.Parameters.AddWithValue("subscriberId", obj.SubscriberId);
                        command.Parameters.AddWithValue("materialId", obj.MaterialId);
                        command.Parameters.AddWithValue("reservationDate", obj.ReservationDate);
                        command.Parameters.AddWithValue("updBy", obj.UpdBy);

                        rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
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
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
