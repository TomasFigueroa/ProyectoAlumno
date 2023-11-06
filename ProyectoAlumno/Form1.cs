using BackendAlumno;
using CapaNegocio;
using System.Data;

namespace ProyectoAlumno
{
    public partial class Form1 : Form
    {
        private ALumno alumno = new ALumno();
        private Pago pago = new Pago();
        private NegPago negpago = new NegPago();
        private NegAlumno negalumno = new NegAlumno();
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
            Dt_Alumno.ColumnCount = 5;
            Dt_Alumno.Columns[0].HeaderText = "DNI";
            Dt_Alumno.Columns[1].HeaderText = "Nombre";
            Dt_Alumno.Columns[0].Width = 100;
            Dt_Alumno.Columns[1].Width = 100;
            Dt_Alumno.Columns[2].HeaderText = "Apellido";
            Dt_Alumno.Columns[3].HeaderText = "Legajo";
            Dt_Alumno.Columns[4].HeaderText = "Analitico";
            Dt_Alumno.Columns[2].Width = 70;
            Dt_Alumno.Columns[3].Width = 50;
            Dt_Alumno.Columns[4].Width = 200;
            LlenarAlum();
            Dt_Pago.ColumnCount = 6;
            Dt_Pago.Columns[0].HeaderText = "COD";
            Dt_Pago.Columns[1].HeaderText = "Fecha_Pago";
            Dt_Pago.Columns[0].Width = 100;
            Dt_Pago.Columns[1].Width = 100;
            Dt_Pago.Columns[2].HeaderText = "Cuota";
            Dt_Pago.Columns[3].HeaderText = "Monto_Cutoa";
            Dt_Pago.Columns[4].HeaderText = "DNIdeAlumno";
            Dt_Pago.Columns[5].HeaderText = "Descripcion";
            Dt_Pago.Columns[2].Width = 70;
            Dt_Pago.Columns[3].Width = 50;
            Dt_Pago.Columns[4].Width = 200;
            Dt_Pago.Columns[5].Width = 200;
            LlenarPag();
        }
        private void LlenarAlum()
        {
            Dt_Alumno.Rows.Clear();

            ds = negalumno.ListadoAlumno("Todos");


            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Dt_Alumno.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4]);

                }
            }
            else
            {
                lblMensaje.Text = "No hay Alumnos cargados en el sistema";
            }

        }
        private void LlenarPag()
        {
            Dt_Pago.Rows.Clear();

            ds = negpago.ListadoPago("Todos");


            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Dt_Alumno.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5]);

                }
            }
            else
            {
                lblMensaje1.Text = "No hay Pagos cargados en el sistema";
            }

        }
        private void Bt_Cargar_alm_Click(object sender, EventArgs e)
        {
            //string DATO = Txt_DNI.Text;
            //if (DATO != "")
            //{
            //    autos.Patente = Txt_Patente.Text;
            //    BuscarFilaAutos(Txt_Patente.Text, ds);
            //    ds_a_Box(ds);



            //    negAutos.abmAutos("Borrar", autos);
            //    boton = true;
            //    dgautos.Rows.Clear();
            //    LlenarMod();

            //}

        }
        private void ds_a_Box(DataSet ds)
        {
            Txt_DNI.Text = ds.Tables[0].Rows[fila]["DNI"].ToString();
            Txt_Nombre.Text = ds.Tables[0].Rows[fila]["Nombre"].ToString();
            Txt_Apellido.Text = ds.Tables[0].Rows[fila]["Apellido"].ToString();
            Txt_Legajo.Text = ds.Tables[0].Rows[fila]["Legajo"].ToString();

        }
        int fila = -1;

        private void CargarAlumno()
        {
            alumno.DNI = Convert.ToInt32(Txt_DNI.Text);
            alumno.Nombre = Txt_Nombre.Text.ToUpper();
            alumno.Apellido = Txt_Apellido.Text.ToUpper();
            alumno.Legajo = Convert.ToInt32(Txt_Legajo.Text);
            alumno.Analitico = Check_Analitico.Checked;
           

        }
    }
}