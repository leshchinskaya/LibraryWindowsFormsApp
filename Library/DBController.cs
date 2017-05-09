using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    class DBController
    {
        static string connect = "Data Source=MARIE18CD;Initial Catalog=Library3;Integrated Security=True";
        SqlConnection con = new SqlConnection(connect);

        public DataTable LoadView(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                // Заполняем DatаТаblе данными из курсора
                // и выполняем очистку.
                dt.Load(reader);
                reader.Close();
                return dt;
            }
            catch (Exception ex)
            {
                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool CheckRole(string role)
        {
            SqlCommand cmd = new SqlCommand("select dbo.CheckRole(@rolename)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@rolename", SqlDbType.VarChar, 20));
            cmd.Parameters["@rolename"].Value = role;
            try
            {
                con.Open();
                return (bool)cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public int InsertStudent(Student c)
        {
            // Далее стандартная последовательность вызова ХП
            // Соединение с БД
            // SqlConnection con = new SqlConnection(connectionString);
            // Созданной команде передается имя ХП
            SqlCommand cmd = new SqlCommand("[dbo].[InsertSTUDENT]", con);
            // Указывается тип команды
            cmd.CommandType = CommandType.StoredProcedure;
            // Создаются пар-ры ХП, указываются имена, тип, длина
            cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@surname", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@faculty", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@course", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@groupp", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@cardNum", SqlDbType.Int));
            // Устанавливаются их значения
            cmd.Parameters["@name"].Value = c.name;
            cmd.Parameters["@surname"].Value = c.surname;
            cmd.Parameters["@faculty"].Value = c.faculty;
            cmd.Parameters["@course"].Value = c.course;
            cmd.Parameters["@groupp"].Value = c.groupp;
            cmd.Parameters["@cardNum"].Value = c.cardNum;

            try
            {
                con.Open(); // Открыть соединение
                cmd.ExecuteNonQuery(); // Вызвать ХП
                //return (int)cmd.Parameters["Client_ID"].Value;
                return 1;
            }
            catch (SqlException ex)
            {

                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return -1;
            }

            finally
            {
                con.Close();
            }
        }

        internal int InsertGetbook(Getbook getbook)
        {
            // Далее стандартная последовательность вызова ХП
            // Соединение с БД
            // SqlConnection con = new SqlConnection(connectionString);
            // Созданной команде передается имя ХП
            SqlCommand cmd = new SqlCommand("[dbo].[GETBOOK1]", con);
            // Указывается тип команды
            cmd.CommandType = CommandType.StoredProcedure;
            // Создаются пар-ры ХП, указываются имена, тип, длина
            cmd.Parameters.Add(new SqlParameter("@giveDate", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@returnDate", SqlDbType.DateTime));
            //cmd.Parameters.Add(new SqlParameter("@realReturnDate", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@cardNum", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@idBookone", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@idStudent", SqlDbType.Int));
            // Устанавливаются их значения
            cmd.Parameters["@giveDate"].Value = getbook.giveDate;
            cmd.Parameters["@returnDate"].Value = getbook.returnDate;
            //cmd.Parameters["@realReturnDate"].Value = getbook.realReturnDate;
            cmd.Parameters["@cardNum"].Value = getbook.cardNum;
            cmd.Parameters["@idBookone"].Value = getbook.idBookone;
            cmd.Parameters["@idStudent"].Value = getbook.idStudent;

            try
            {
                con.Open(); // Открыть соединение
                cmd.ExecuteNonQuery(); // Вызвать ХП
                //return (int)cmd.Parameters["Client_ID"].Value;
                return 1;
            }
            catch (SqlException ex)
            {

                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return -1;
            }

            finally
            {
                con.Close();
            }
        }

        public int InsertBook(Book b)
        {
            // Далее стандартная последовательность вызова ХП
            // Соединение с БД
            // SqlConnection con = new SqlConnection(connectionString);
            // Созданной команде передается имя ХП
            SqlCommand cmd = new SqlCommand("[dbo].[InsertBOOK]", con);
            // Указывается тип команды
            cmd.CommandType = CommandType.StoredProcedure;
            // Создаются пар-ры ХП, указываются имена, тип, длина
            cmd.Parameters.Add(new SqlParameter("@idBook", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@title", SqlDbType.VarChar, 150));
            cmd.Parameters.Add(new SqlParameter("@numPages", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@numExem", SqlDbType.Int));

            cmd.Parameters["@idBook"].Direction = ParameterDirection.Output;
            // Устанавливаются их значения
            cmd.Parameters["@title"].Value = b.title;
            cmd.Parameters["@numPages"].Value = b.numPages;
            cmd.Parameters["@numExem"].Value = b.numExem;

            try
            {
                con.Open(); // Открыть соединение
                cmd.ExecuteNonQuery(); // Вызвать ХП
                return (int)cmd.Parameters["@idBook"].Value;
               // return 1;
            }
            catch (SqlException ex)
            {

                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return -1;
            }

            finally
            {
                con.Close();
            }
        }

        public int InsertAuthor(Author auth)
        {
            // Далее стандартная последовательность вызова ХП
            // Соединение с БД
            // SqlConnection con = new SqlConnection(connectionString);
            // Созданной команде передается имя ХП
            SqlCommand cmd = new SqlCommand("[dbo].[InsertAuthor]", con);
            // Указывается тип команды
            cmd.CommandType = CommandType.StoredProcedure;
            // Создаются пар-ры ХП, указываются имена, тип, длина
            cmd.Parameters.Add(new SqlParameter("@idAuthor", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@fio", SqlDbType.VarChar, 150));
            // Устанавливаются их значения
            cmd.Parameters["@fio"].Value = auth.fio;

            cmd.Parameters["@idAuthor"].Direction = ParameterDirection.Output;

            try
            {
                con.Open(); // Открыть соединение
                cmd.ExecuteNonQuery(); // Вызвать ХП
                return (int)cmd.Parameters["@idAuthor"].Value;
                //return 1;
            }
            catch (SqlException ex)
            {

                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return -1;
            }

            finally
            {
                con.Close();
            }
            Library.AddBook.idAuth = auth.idAuthor;
        }

        public int InsertBookone(Bookones bo)
        {
            // Далее стандартная последовательность вызова ХП
            // Соединение с БД
            // SqlConnection con = new SqlConnection(connectionString);
            // Созданной команде передается имя ХП
            SqlCommand cmd = new SqlCommand("[dbo].[InsertBOOKONES]", con);
            // Указывается тип команды
            cmd.CommandType = CommandType.StoredProcedure;
            // Создаются пар-ры ХП, указываются имена, тип, длина
            cmd.Parameters.Add(new SqlParameter("@injury", SqlDbType.VarChar, 150));
            cmd.Parameters.Add(new SqlParameter("@idBook", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@idBank", SqlDbType.Int));
            // Устанавливаются их значения
            cmd.Parameters["@injury"].Value = bo.injury;
            cmd.Parameters["@idBook"].Value = bo.idBook;
            cmd.Parameters["@idBank"].Value = bo.idBank;

            try
            {
                con.Open(); // Открыть соединение
                cmd.ExecuteNonQuery(); // Вызвать ХП
                //return (int)cmd.Parameters["Client_ID"].Value;
                return 1;
            }
            catch (SqlException ex)
            {

                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return -1;
            }

            finally
            {
                con.Close();
            }
        }

        public int InsertBank(Bank bn)
        {
            // Далее стандартная последовательность вызова ХП
            // Соединение с БД
            // SqlConnection con = new SqlConnection(connectionString);
            // Созданной команде передается имя ХП
            SqlCommand cmd = new SqlCommand("[dbo].[InstBank]", con);
            // Указывается тип команды
            cmd.CommandType = CommandType.StoredProcedure;
            // Создаются пар-ры ХП, указываются имена, тип, длина
            cmd.Parameters.Add(new SqlParameter("@idBank", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@placeName", SqlDbType.VarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@numOfPlace", SqlDbType.VarChar, 50));
            // Устанавливаются их значения
            cmd.Parameters["@placeName"].Value = bn.placeName;
            cmd.Parameters["@numOfPlace"].Value = bn.numOfPlace;

            cmd.Parameters["@idBank"].Direction = ParameterDirection.Output;

            try
            {
                con.Open(); // Открыть соединение
                cmd.ExecuteNonQuery(); // Вызвать ХП
                return (int)cmd.Parameters["@idBank"].Value;
                //return 1;
            }
            catch (SqlException ex)
            {

                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return -1;
            }

            finally
            {
                con.Close();
            }

        }

        public int InsertBookHasAuthor(BookHasAuthor bhauth)
        {
            // Далее стандартная последовательность вызова ХП
            // Соединение с БД
            // SqlConnection con = new SqlConnection(connectionString);
            // Созданной команде передается имя ХП
            SqlCommand cmd = new SqlCommand("[dbo].[InstertBookHasAuthor]", con);
            // Указывается тип команды
            cmd.CommandType = CommandType.StoredProcedure;
            // Создаются пар-ры ХП, указываются имена, тип, длина
            cmd.Parameters.Add(new SqlParameter("@idBook", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@idAuthor", SqlDbType.Int));
            // Устанавливаются их значения
            cmd.Parameters["@idBook"].Value = bhauth.idBook;
            cmd.Parameters["@idAuthor"].Value = bhauth.idAuthor;

            try
            {
                con.Open(); // Открыть соединение
                cmd.ExecuteNonQuery(); // Вызвать ХП
                //return (int)cmd.Parameters["Client_ID"].Value;
                return 1;
            }
            catch (SqlException ex)
            {

                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return -1;
            }

            finally
            {
                con.Close();
            }
        }

        public int UpdateGetbook(int idBookone, int idStudent, DateTime realReturnD)
        {
            // Далее стандартная последовательность вызова ХП
            // Соединение с БД
            // SqlConnection con = new SqlConnection(connectionString);
            // Созданной команде передается имя ХП
            SqlCommand cmd = new SqlCommand("[dbo].[UpdateGetbook]", con);
            // Указывается тип команды
            cmd.CommandType = CommandType.StoredProcedure;
            // Создаются пар-ры ХП, указываются имена, тип, длина
            cmd.Parameters.Add(new SqlParameter("@realReturnDate", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@idBookone", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@idStudent", SqlDbType.Int));
            // Устанавливаются их значения
            cmd.Parameters["@idBookone"].Value = idBookone;
            cmd.Parameters["@idStudent"].Value = idStudent;
            cmd.Parameters["@realReturnDate"].Value = realReturnD;

            try
            {
                con.Open(); // Открыть соединение
                cmd.ExecuteNonQuery(); // Вызвать ХП
                //return (int)cmd.Parameters["Client_ID"].Value;
                return 1;
            }
            catch (SqlException ex)
            {

                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return -1;
            }

            finally
            {
                con.Close();
            }
        }

        public int UpdateBook(int idBook)
        {
            // Далее стандартная последовательность вызова ХП
            // Соединение с БД
            // SqlConnection con = new SqlConnection(connectionString);
            // Созданной команде передается имя ХП
            SqlCommand cmd = new SqlCommand("[dbo].[UpdateBook1]", con);
            // Указывается тип команды
            cmd.CommandType = CommandType.StoredProcedure;
            // Создаются пар-ры ХП, указываются имена, тип, длина
            cmd.Parameters.Add(new SqlParameter("@idBook", SqlDbType.Int));
            // Устанавливаются их значения
            cmd.Parameters["@idBook"].Value = idBook;

            try
            {
                con.Open(); // Открыть соединение
                cmd.ExecuteNonQuery(); // Вызвать ХП
                //return (int)cmd.Parameters["Client_ID"].Value;
                return 1;
            }
            catch (SqlException ex)
            {

                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return -1;
            }

            finally
            {
                con.Close();
            }
        }

        public int UpdateBookminus(int idBook)
        {
            // Далее стандартная последовательность вызова ХП
            // Соединение с БД
            // SqlConnection con = new SqlConnection(connectionString);
            // Созданной команде передается имя ХП
            SqlCommand cmd = new SqlCommand("[dbo].[UpdateBookminus]", con);
            // Указывается тип команды
            cmd.CommandType = CommandType.StoredProcedure;
            // Создаются пар-ры ХП, указываются имена, тип, длина
            cmd.Parameters.Add(new SqlParameter("@idBook", SqlDbType.Int));
            // Устанавливаются их значения
            cmd.Parameters["@idBook"].Value = idBook;

            try
            {
                con.Open(); // Открыть соединение
                cmd.ExecuteNonQuery(); // Вызвать ХП
                //return (int)cmd.Parameters["Client_ID"].Value;
                return 1;
            }
            catch (SqlException ex)
            {

                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return -1;
            }

            finally
            {
                con.Close();
            }
        }
        public DataTable GetAsTable(string sql)
        {
            DataTable dt = new DataTable();

            //string sql = "Select * From ViewClient";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                // Заполняем DatаТаblе данными из курсора
                // и выполняем очистку.
                dt.Load(reader);
                reader.Close();
                return dt;
            }
            catch (Exception ex)
            {
                //throw new ApplicationException("Ошибка данных");
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }


    }
}
