using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace KPiR
{
    class DBContact
    {
        OracleConnection conn;

        public DBContact()
        {
            string oradb = "User Id=KPiR;Password=KPiR;" +
                "Data Source = localhost:1521/XE;Pooling = false;";
            conn = new OracleConnection();
            conn.ConnectionString = oradb;
        }

        public DataTable getKonta()
        {
            try
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from konta ";

                cmd.CommandText += "order by nazwa";
                OracleDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            return null;
        }

        public bool isKontoUsed(string nazwa)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from PRZYCHODY_I_ROZCHODY where KONTO = '" + nazwa + "'";

                OracleDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            return false;
        }

        public bool isAkcjaUsed(string nazwa)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from PRZYCHODY_I_ROZCHODY where AKCJA_ID = '" + nazwa + "'";

                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            return false;
        }

        public DataTable getAkcje()
        {
            try
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from akcje ";

                cmd.CommandText += "order by nazwa";
                OracleDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            return null;
        }

        public DataTable getKoordynatorzy()
        {
            try
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from koordynatorzy ";

                cmd.CommandText += "order by funkcja";
                OracleDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            return null;
        }

        public double getStanKonta(string nazwa, string data)
        {
            double suma = 0;
            try
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                cmd.CommandText = "KPiR.STAN_KONTA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Return_Value", OracleDbType.Double, ParameterDirection.ReturnValue);
                cmd.Parameters.Add("NAZWA", OracleDbType.Varchar2).Value = nazwa;
                OracleDate date = new OracleDate(int.Parse(data.Substring(0, 4)), int.Parse(data.Substring(5, 2)), int.Parse(data.Substring(8, 2)));
                cmd.Parameters.Add("DATA", OracleDbType.Date).Value = date;
                cmd.ExecuteNonQuery();
                suma = double.Parse(cmd.Parameters["Return_Value"].Value.ToString().Replace(".",","));
                cmd.Parameters.RemoveAt(0);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            return suma;
        }


        public double ZmianaKoordynatora(string funkcja, string imie, string nazwisko, string poczatek)
        {
            double suma = 0;
            try
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                cmd.CommandText = "KPiR.ZMIANA_KOORDYNATORA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("funkcja", OracleDbType.Varchar2).Value = funkcja;
                cmd.Parameters.Add("imie", OracleDbType.Varchar2).Value = imie;
                cmd.Parameters.Add("nazwisko", OracleDbType.Varchar2).Value = nazwisko;
                OracleDate date = new OracleDate(int.Parse(poczatek.Substring(0, 4)), int.Parse(poczatek.Substring(5, 2)), int.Parse(poczatek.Substring(8, 2)));
                cmd.Parameters.Add("poczatek", OracleDbType.Date).Value = date;
                cmd.ExecuteNonQuery();
                cmd.Parameters.RemoveAt(0);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            return suma;
        }
    }
}
