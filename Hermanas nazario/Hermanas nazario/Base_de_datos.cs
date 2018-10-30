using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Hermanas_nazario
{
    public class Base_de_datos
    {
        public static SqlConnection Conectar()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CLSVRED;Initial Catalog=Clinica;Integrated Security=True");

            return con;
        }
        public static int Log(string txtusuario, string txtcontraseña)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Nombre_usuario, Contrasena_usuario from Usuarios WHERE Nombre_usuario LIKE @nom AND Contrasena_usuario LIKE @usu", con);
            cmd.Parameters.AddWithValue("nom", txtusuario);
            cmd.Parameters.AddWithValue("usu", txtcontraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {

                menu a = new menu();
                a.Show();
                con.Close();
                return 1;

            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrecta");
                con.Close();
                return 0;
            }

        }

        public static void Registro(string nom1, string nom2, string ape1, string ape2, string lugar, string fecha, string padre, string madre, string identidad, string sexo, int riesgo)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Mante_pacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Primer_nombre_paciente", nom1));
                cmd.Parameters.Add(new SqlParameter("@Segundo_nombre_paciente", nom2));
                cmd.Parameters.Add(new SqlParameter("@Primer_apellido_paciente", ape1));
                cmd.Parameters.Add(new SqlParameter("@Segundo_apellido_paciente", ape2));
                cmd.Parameters.Add(new SqlParameter("@Lugar_nacimiento", lugar));
                cmd.Parameters.Add(new SqlParameter("@Fecha_nacimiento", fecha));
                cmd.Parameters.Add(new SqlParameter("@Nombre_padre_paciente", padre));
                cmd.Parameters.Add(new SqlParameter("@Nombre_madre_paciente", madre));
                cmd.Parameters.Add(new SqlParameter("@Numero_identidad_paciente", identidad));
                cmd.Parameters.Add(new SqlParameter("@Sexo_paciente", sexo));
                cmd.Parameters.Add(new SqlParameter("@Codigo_riesgo", riesgo));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        public static void expediente(string ID)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Pacientes] WHERE [Numero_identidad_paciente]=@id", con);
                cmd.Parameters.AddWithValue("@id", ID);
                SqlDataReader registro = cmd.ExecuteReader();

                if (registro.Read())
                {
                    MessageBox.Show("El numero de expediente es : "+registro["Codigo_expediente_paciente"].ToString());
                }

                
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }

        }

        public static void registrar_usuario(string usu, string contra, int codigo)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Mante_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre_usuario", usu));
                cmd.Parameters.Add(new SqlParameter("@Contrasena_usuario", contra));
                cmd.Parameters.Add(new SqlParameter("@Codigo_empleado", codigo));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {           
                con.Close();
            }
        }

        public static void registrar_empleado(string nom1, string nom2, string ape1, string ape2, string correo, string id, string sexo, string tel )
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Mante_empleados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Primer_nombre_empleado", nom1));
                cmd.Parameters.Add(new SqlParameter("@Segundo_nombre_empleado", nom2));
                cmd.Parameters.Add(new SqlParameter("@Primer_apellido_empleado", ape1));
                cmd.Parameters.Add(new SqlParameter("@Segundo_apellido_empleado", ape2));
                cmd.Parameters.Add(new SqlParameter("@Correo_empleado", correo));
                cmd.Parameters.Add(new SqlParameter("@Numero_identidad_empleado", id));
                cmd.Parameters.Add(new SqlParameter("@Sexo_empleado", sexo));
                cmd.Parameters.Add(new SqlParameter("@Telefono_empleado", tel));

                
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

    }
}
