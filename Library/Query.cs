using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Library
{
    public class Query
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=control_escolar; user=root; pwd=abcd;");

        #region inicio de sesion
        public string login(string name, string contra, ref string nameok, ref string apellido, ref string cargo) {
            conexion.Open();
            string query = "select * from control_escolar.Usuarios where id_usuario = @name and Contraseña = @contra;";
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = query;
            comando.Parameters.AddWithValue("@name",name);
            comando.Parameters.AddWithValue("@contra",contra);
            comando.Connection = conexion;
            MySqlDataReader almacen = comando.ExecuteReader();

            if (almacen.Read())
            {
                nameok = almacen.GetValue(1).ToString();
                apellido = almacen.GetValue(2).ToString();
                cargo = almacen.GetValue(3).ToString();
                conexion.Close();
                return "Accesando";
            }
            else {
                conexion.Close();
                return "Usuario o Contrase incorrectos";
            }
        }
        #endregion

        #region Opreaciones de los grupos
        public DataSet Consulta_Grupos(){
            conexion.Open();
            MySqlDataAdapter mysqldata = new MySqlDataAdapter("select * from control_escolar.grupos;", conexion);
            DataSet ds = new DataSet();
            mysqldata.Fill(ds);
            conexion.Close();
            return ds;
        }
        
        public string Agregar_Grupo(int grado, string grupo, string aula){
            conexion.Open();
            try {
                string inserccion = string.Format("insert into control_escolar.grupos() values(null, {0}, '{1}', '{2}');", grado, grupo, aula);
                MySqlCommand comando = new MySqlCommand(inserccion, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Datos Insertados Correctamente";
            } catch(MySqlException ex) {
                conexion.Close();
                return ex.ToString();
            }
            
        }

        public string Actualizar_Grupo(int id,int grado, string grupo, string aula) {
            conexion.Open();
            try {
                string actualizacion = string.Format("update control_escolar set Grado = {0}, Grupo = '{1}', Aula= '{2}' where idGrado = {3}", grado, grupo, aula, id);
                MySqlCommand comando = new MySqlCommand(actualizacion, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Datos Actualizados Correctamente";
            }
            catch (MySqlException ex) {
                conexion.Close();
                return ex.ToString();
            }
        }

        public string Eliminar_Grupo(int id) {
            conexion.Open();
            try {
                string elimnar = string.Format("delete from control_escolar.grupos where idGrupo = {0}",id);
                MySqlCommand comando = new MySqlCommand(elimnar, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Registro elimnado";
            }
            catch (MySqlException ex) {
                conexion.Close();
                return "Para eliminar un grupo no debe tener alumnos en el.";
            }
        }
        #endregion

        #region materias

        public DataSet Consultar_Materias() {
            conexion.Open();
            string consuta = string.Format("select * from control_escolar.materias;");
            MySqlDataAdapter comando = new MySqlDataAdapter(consuta, conexion);
            DataSet ds = new DataSet();
            comando.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataSet Cons_mat_grad(int grado) {
            conexion.Open();
            string consulta = string.Format("select * from control_escolar.materias where grupos_idgrados = {0}; ",grado);
            MySqlDataAdapter data = new MySqlDataAdapter(consulta, conexion);
            DataSet ds = new DataSet();
            data.Fill(ds);
            conexion.Close();
            return ds;
        }

        public string Modificar_materias(string clave, string nombre, string tipo, int grado) {
            conexion.Open();
            try
            {
                string consulta = string.Format("update control_escolar.materias set Nombre_materia = '{0}', Tiipo_materia = '{1}', Grupos_idGrados = {2} where Clave_materia = '{3}'",
                    nombre, tipo, grado, clave);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Datos Actualizados correctamente";
            }
            catch (MySqlException ex) {
                conexion.Close();
                return "Excepcion no controlada";
            }
        }

        public string Agregar_materia(string clave, string nombre, string tipo, int grado) {
            conexion.Open();
            try {
                string consulta = string.Format("insert into control_escolar.materias() values ('{0}','{1}','{2}',{3});",clave, nombre, tipo, grado);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Dato Creado Correctamente.";
            } catch (MySqlException ex) {
                conexion.Close();
                return "Excepcion no controlada.";
            }
        }

        public string Eliminar_materia(string clave) {
            conexion.Open();
            try {
                string consulta = string.Format("delete from control_escolar.materias where Clave_materia = '{0}';",clave);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Dato Eliminado.";
            } catch (MySqlException ex) {
                conexion.Close();
                return "Excepcion no Controlada.";
            }
        }
        #endregion

        #region inscripciones

        public string Inscripciones_alumno(string CURP, string ap_paterno, string ap_mterno, string nombre, int edad, string direccion, string fecha_nacimiento, string periodo, int grado) {
            string clave_tutor = CURP;

            conexion.Open();
            try {
                string consulta = string.Format("insert into control_escolar.alumnos() values('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}',{9});",
                    CURP, ap_paterno, ap_mterno, nombre, edad, direccion, fecha_nacimiento, clave_tutor, periodo, grado);
                MySqlCommand comando = new MySqlCommand(consulta,conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Estudiante inscrito al grupo correctamente.";
            }
            catch (MySqlException) {
                conexion.Close();
                return "Excepcion no Controlada";
            }
        }

        public string Modifcacion_alumnos(string CURP, string ap_paterno, string ap_materno, string nombre, int edad, string direccion, string fecha_nac, string periodo, int grado) {
            conexion.Open();
            string id_tutor = CURP;
            try {
                string consulta = string.Format("Update control_escolar.alumnos set ap_paterno = '{0}', ap_materno = '{1}', nombre= '{2}', " +
                    "edad= {3}, direccion= '{4}', fecha_nacimiento ='{5}'" +
                    "where CURP = '{6}';",ap_paterno,ap_materno, nombre, edad,direccion,fecha_nac,CURP);
                MySqlCommand comando = new MySqlCommand(consulta,conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Datos del alumnos actualizados correctamente.";
            } catch (MySqlException ex) {
                conexion.Close();
                return "Excepcion no controlada.";
            }
        }

        public string Eliminar_alumno(string CURP) {
            conexion.Open();
            try {
                string consulta = string.Format("delete from control_escolar.alumnos where CURP = '{0}';",CURP);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Registro eliminado correctamente.";
            } catch (MySqlException ex) {
                conexion.Close();
                return "Excepcion no controla. No puede eliminar el registro otros datos dependen de este.";
            }
        }

        public DataSet Consulta_alumnos() {
            conexion.Open();
            string consulta = string.Format("select * from control_escolar.alumnos");
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataSet Consulta_Alumnos_Grupo(int grado) {
            conexion.Open();
            string consulta = string.Format("select * from control_escolar.alumnos where Grupos_idGrados = {0};",grado);
            MySqlDataAdapter data = new MySqlDataAdapter(consulta, conexion);
            DataSet ds = new DataSet();
            data.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataSet Consulta_Alumnos_Genero(string genero) {
            conexion.Open();
            string consulta = string.Format("select CURP,Ap_paterno,Ap_materno,Nombre, Edad, Fecha_nacimiento, Direccion, Genero " +
                "from control_escolar.alumnos, control_escolar.detalle_alumnos where Genero = '{0}';",genero);
            MySqlDataAdapter data = new MySqlDataAdapter(consulta, conexion);
            DataSet ds = new DataSet();
            data.Fill(ds);
            conexion.Close();
            return ds;
        }

        public string Insertar_detalle_alumno(string genero, string tipo_sangre, string alergias, string enfermedad_cronica ,string CURP) {
            conexion.Open();
            try {
                string consulta = string.Format("Insert into control_escolar.detalle_alumnos() values('{0}','{1}','{2}','{3}','{4}');",genero,tipo_sangre,alergias,enfermedad_cronica,CURP);
                MySqlCommand comando = new MySqlCommand(consulta,conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "El detalle del alumno se agrego correctamente.";
            } catch (MySqlException ex) {
                conexion.Close();
                return "Excepcion no controlada.";
            }
        }

        public string Modificar_detalle_alumno(string genero, string tipo_sangre, string alergias, string enfermedad_cronica, string CURP) {
            conexion.Open();
            try {
                string consulta = string.Format("update control_escolar.detalle_alumnos set Genero = '{0}', Tipo_sangre = '{1}', Alergias = '{2}', Enfermedad_cronica = '{3}' where Alumnos_CURP = '{4}';",
                    genero,tipo_sangre,alergias,enfermedad_cronica,CURP);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Datos Actualizados Correctamente.";
            } catch (MySqlException ex) {
                conexion.Close();
                return "Excepcion no controlada.";
            }

        }

        public string Eliminar_detalle_alumno(string CURP) {
            conexion.Open();
            try {
                string consulta = string.Format("delete from control_escolar.detalle_alumnos where Alumnos_CURP = '{0}';",CURP);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Dato eliminado correctamente.";
            } catch (MySqlException ex) {
                conexion.Close();
                return "Excepcion no controlada.";
            }

        }

        public bool grado_edad(int grado, int edad)
        {
            if (grado == 1 && edad == 6)
            {
                return true;
            }
            else if (grado == 2 && edad == 7)
            {
                return true;
            }
            else if (grado == 3 && edad == 8)
            {
                return true;
            }
            else if (grado == 4 && edad == 9)
            {
                return true;
            }
            else if (grado == 5 && edad == 10)
            {
                return true;
            }
            else if (grado == 6 && edad == 11)
            {
                return true;
            }
            else {
                return false;
            }
            
        }

        public bool edad_fecha(int edad, int año) {
            DateTime fechaActual = DateTime.Today;
            int año_actual = Convert.ToInt32(fechaActual.Year);
            int resultado = año_actual - edad;

            if (resultado == año)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool curp_fecha(int curp, int fecha) {
            if (curp == fecha)
            {
                return true;
            }
            return false;
        }

        public int Contar_Alumnos_Grado(int grado) {
            conexion.Open();
            string consulta = string.Format("select COUNT(*) from control_escolar.alumnos where Grupos_idGrados = {0};",grado);
            MySqlCommand comando = new MySqlCommand(consulta,conexion);
            int cantidad = Convert.ToInt32(comando.ExecuteScalar());
            conexion.Close();
            return cantidad;
        }
        #endregion

        #region Alta de Tutor del alumnos
        public string Agregar_Tutor(string CURP, string ap_paterno, string ap_materno, string nombre, string celular, string telefono, string email, string direccion ) {
            conexion.Open();
            try {
                string consulta = string.Format("Insert into control_escolar.tutor values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');",CURP,ap_paterno,ap_materno,nombre,celular,telefono,email,direccion);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Datos de Tutor Guardados Correctamente.";
            } catch (MySqlException) {
                conexion.Close();
                return "Excepcion no Controlada";
            }
        }

        public string Modificar_Tutor(string ap_paterno, string ap_materno, string nombre, string celular, string telefono, string correo, string direccion, string CURP) {
            conexion.Open();
            string consulta = string.Format("Update control_escolar.Tutor set Ap_paterno = '{0}', Ap_materno = '{1}', Nombre = '{2}'," +
                " Tel_celular = '{3}', Tel_hogar ='{4}',Correo_electronico ='{5}', Direccion='{6}' where idTutor = '{7}';",ap_paterno,ap_materno,nombre,celular,telefono,correo,direccion,CURP);
            try {
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Datos del tutor actulizado correctamente.";
            } catch(MySqlException) {
                conexion.Close();
                return "Excepcion no controlada.";
            }
        }

        public DataSet Consultar_Tutores() {
            conexion.Open();
            string consulta = string.Format("select * from control_escolar.tutor;");
            MySqlDataAdapter data = new MySqlDataAdapter(consulta, conexion);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }

        public string Eliminar_Tutor(string CURP) {
            conexion.Open();
            string consulta = string.Format("delete from control_escolar.tutor where idTutor = '{0}';",CURP);
            try {
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Dato Eliminado.";
            }
            catch (MySqlException) {
                conexion.Close();
                return "Excepcion no controlada.";
            }
        }

        #endregion

        #region Calificaciones

        public DataSet C_alumnos_calificaciones_grado1() {
            conexion.Open();
            string consuta = string.Format("select CURP, Ap_paterno, Ap_materno, Nombre from control_escolar.alumnos where control_escolar.alumnos.Grupos_idGrados = 1;");
            MySqlDataAdapter comando = new MySqlDataAdapter(consuta, conexion);
            DataSet ds = new DataSet();
            comando.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataSet C_alumnos_calificaciones_grado2()
        {
            conexion.Open();
            string consuta = string.Format("select CURP, Ap_paterno, Ap_materno, Nombre from control_escolar.alumnos where control_escolar.alumnos.Grupos_idGrados = 2;");
            MySqlDataAdapter comando = new MySqlDataAdapter(consuta, conexion);
            DataSet ds = new DataSet();
            comando.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataSet C_alumnos_calificaciones_grado3()
        {
            conexion.Open();
            string consuta = string.Format("select CURP, Ap_paterno, Ap_materno, Nombre from control_escolar.alumnos where control_escolar.alumnos.Grupos_idGrados = 3;");
            MySqlDataAdapter comando = new MySqlDataAdapter(consuta, conexion);
            DataSet ds = new DataSet();
            comando.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataSet C_alumnos_calificaciones_grado4()
        {
            conexion.Open();
            string consuta = string.Format("select CURP, Ap_paterno, Ap_materno, Nombre from control_escolar.alumnos where control_escolar.alumnos.Grupos_idGrados = 4;");
            MySqlDataAdapter comando = new MySqlDataAdapter(consuta, conexion);
            DataSet ds = new DataSet();
            comando.Fill(ds);
            conexion.Close();
            return ds;
        }
        public DataSet C_alumnos_calificaciones_grado5()
        {
            conexion.Open();
            string consuta = string.Format("select CURP, Ap_paterno, Ap_materno, Nombre from control_escolar.alumnos where control_escolar.alumnos.Grupos_idGrados = 5;");
            MySqlDataAdapter comando = new MySqlDataAdapter(consuta, conexion);
            DataSet ds = new DataSet();
            comando.Fill(ds);
            conexion.Close();
            return ds;
        }
        public DataSet C_alumnos_calificaciones_grado6()
        {
            conexion.Open();
            string consuta = string.Format("select CURP, Ap_paterno, Ap_materno, Nombre from control_escolar.alumnos where control_escolar.alumnos.Grupos_idGrados = 6;");
            MySqlDataAdapter comando = new MySqlDataAdapter(consuta, conexion);
            DataSet ds = new DataSet();
            comando.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataSet Materia1and2() {
            conexion.Open();
            string consuta = string.Format("select C_español,C_matematicas,C_civismo, C_E_Fisica, C_Artes,C_nat_soc,C_computacion,C_ingles from control_escolar.c_primer_segundo_grado;");
            MySqlDataAdapter comando = new MySqlDataAdapter(consuta, conexion);
            DataSet ds = new DataSet();
            comando.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataSet Materia3()
        {
            conexion.Open();
            string consuta = string.Format("select C_Español, C_matematicas, C_C_Naturales, C_Entidad_d_vivo,C_For_civ_etic,C_educ_fisica, C_educ_artisitica,C_computacion,C_ingles  from control_escolar.c_tercer_grado;");
            MySqlDataAdapter comando = new MySqlDataAdapter(consuta, conexion);
            DataSet ds = new DataSet();
            comando.Fill(ds);
            conexion.Close();
            return ds;
        }

        public DataSet Materia4and5and6()
        {
            conexion.Open();
            string consuta = string.Format("select C_español, C_matematicas, C_CiencNaturales, C_geografia,C_historia, C_civc_etica,C_educ_fisica,C_educ_artistica, C_computacion,C_ingles from control_escolar.c_cuarto_quinto_sexto_grado;");
            MySqlDataAdapter comando = new MySqlDataAdapter(consuta, conexion);
            DataSet ds = new DataSet();
            comando.Fill(ds);
            conexion.Close();
            return ds;
        }

        public string Inser_cal_1and2(int c_esñol, int c_mate, int c_civ, int c_efisica, int artes, int sociedad, int computacion, int ingles, int grupo, string periodo, string curp) {
            conexion.Open();
            try {
                string insertar = string.Format("insert into control_escolar.c_primer_segundo_grado values ({0},{1},{2},{3},{4},{5},{6},{7},'{8}','{9}',{10});",
                    c_esñol,c_mate,c_civ,c_efisica,artes, sociedad,computacion,ingles,periodo, curp, grupo);

                MySqlCommand comando = new MySqlCommand(insertar, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Captura de calificacioes agregada Exictosamente.";
            }
            catch (MySqlException) {
                conexion.Clone();
                return "Excepcion no controlada";
            }
        }

        public string Inser_cal_3(int español, int mate, int c_nat, int entidad,int civica,int efisica, int artes, int computacion, int ingles, int grupo, string periodo, string curp)
        {
            conexion.Open();
            try
            {
                string insertar = string.Format("insert into control_escolar.c_tercer_grado values ({0},{1},{2},{3},{4},{5},{6},{7},{8},'{9}','{10}',{11});",
                    español, mate, c_nat, entidad,civica, efisica, artes, computacion, ingles, periodo, curp, grupo);

                MySqlCommand comando = new MySqlCommand(insertar, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Captura de calificacioes agregada Exictosamente.";
            }
            catch (MySqlException)
            {
                conexion.Clone();
                return "Excepcion no controlada";
            }
        }

        public string Inser_cal_4_5_6(int español, int mate, int c_nat, int geografia,int historia, int civica, int efisica, int artes, int computacion, int ingles, int grupo, string periodo, string curp)
        {
            conexion.Open();
            try
            {
                string insertar = string.Format("insert into control_escolar.c_tercer_grado values ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},'{10}','{11}',{12});",
                    español, mate, c_nat, geografia,historia, civica, efisica, artes, computacion, ingles, periodo, curp, grupo);

                MySqlCommand comando = new MySqlCommand(insertar, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return "Captura de calificacioes agregada Exictosamente.";
            }
            catch (MySqlException)
            {
                conexion.Clone();
                return "Excepcion no controlada";
            }
        }

        #endregion

    }
}
