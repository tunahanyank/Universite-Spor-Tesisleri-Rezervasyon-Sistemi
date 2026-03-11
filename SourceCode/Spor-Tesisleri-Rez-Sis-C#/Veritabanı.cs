using System;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public class Veritabanı
    {
        public string baglantiAdresi = @"Server=(local);Database=universite_Spor_Tesisleri_Rezervasyon_Sistemi;Trusted_Connection=True;";

        public DataTable VeriGetir(string sorgu)
        {
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglantiAdresi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       

    }
}











