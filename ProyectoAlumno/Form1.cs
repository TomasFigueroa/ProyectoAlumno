using BackendAlumno;
using CapaNegocio;
using CapoDatos;
using System.Data;

namespace ProyectoAlumno
	{
	public partial class Form1 :Form
		{
		private ALumno alumno = new ALumno();
		private Pago pago = new Pago();
		private NegPago negpago = new NegPago();
		private NegAlumno negalumno = new NegAlumno();
		private AdminAlumno adminAlumno = new AdminAlumno();
		DataSet ds = new DataSet();
		public DataTable DT { get; set; } = new DataTable();
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
					Dt_Pago.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5]);

					}
				}
			else
				{
				lblMensaje1.Text = "No hay Pagos cargados en el sistema";
				}

			}
		private void Bt_Cargar_alm_Click(object sender, EventArgs e)
			{
			int nGrabados = -1;
			CargarAlumno();



			nGrabados = negalumno.abmAlumno("Alta", alumno);
			if (nGrabados == -1)
				{
				MessageBox.Show("No se pudo grabar el Alumno en el sistema");
				}
			else
				{
				MessageBox.Show("Se pudo grabar el Alumno en el sistema con exito");
				LlenarAlum();


				}

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

		private void BT_Cargar_Pag_Click(object sender, EventArgs e)
			{
			int nGrabados = -1;
			CargarPago();
			bool pag = false;
			bool fila = Validar();
			DataSet ds = adminAlumno.listadoAlumno("Todos");
			if (ds.Tables[0].Rows.Count > 0)
				{
				foreach (DataRow dr in ds.Tables[0].Rows)
					{
					if (dr[0].ToString() == Txt_DNI_Pago.Text)
						{
						pag = true;
						}
					}
				if (!pag)
					{ MessageBox.Show("el DNI no corresponde a ningun alumno"); return; };
				}
			if (pag == true)
				{
				nGrabados = negpago.abmPago("Alta", pago);
				if (nGrabados == -1)
					{
					MessageBox.Show("No se pudo grabar el pago en el sistema");
					}
				else
					{
					MessageBox.Show("Se pudo grabar el pago en el sistema con exito");
					LlenarPag();


					}
				}
			else
				{
				MessageBox.Show("No se pudo grabar el pago en el sistema");
				}



			}
		private void CargarPago()
			{
			pago.COD = Convert.ToInt32(Txt_COD.Text);
			pago.Cuota = Convert.ToInt32(Txt_Cuota.Text);
			pago.Descripcion = Txt_Descrip.Text;
			pago.Monto_Cuota = Convert.ToInt32(Txt_Monto.Text);
			pago.DNI_Alumno = Convert.ToInt32(Txt_DNI_Pago.Text);
			pago.Fecha_Pago = DateTime.Now;
			}
		private bool Validar()
			{
			bool res = false;
			filas = BuscarFilaAlumno(Txt_DNI_Pago.Text, ds);

			if (filas != -1)
				{
				res = true;
				}

			return res;
			}
		public int filas = -1;
		public int BuscarFilaAlumno(string alumn, DataSet ds)
			{


			for (int i = 0; i < Dt_Alumno.Rows.Count; i++)
				{
				if (ds.Tables[0].Rows[i]["DNI_Alumno"].ToString() == alumn)
					{
					filas = i;
					break;
					}
				}

			return filas;
			}


		private void Bt_borrar_Click(object sender, EventArgs e)
			{
			string DATO = Txt_DNI.Text;
			if (DATO != "")
				{
				alumno.DNI = Convert.ToInt32(Txt_DNI.Text);
				pago.DNI_Alumno = Convert.ToInt32(Txt_DNI.Text);




				negpago.abmPago("Borrar", pago);
				negalumno.abmAlumno("Borrar", alumno);

				MessageBox.Show("Se pudo borrar el Alumno y sus pagos con exito");
				LlenarAlum();
				LlenarPag();

				}
			}

		private void Bt_Eliminar_Pag_Click(object sender, EventArgs e)
			{
			string DATO = Txt_COD.Text;
			if (DATO != "")
				{

				pago.COD = Convert.ToInt32(Txt_COD.Text);

				negpago.abmPago("Eliminar", pago);

				MessageBox.Show("Se pudo borrar su pago con exito");

				LlenarPag();

			}
		}

		private void Bt_Modificar_Click(object sender, EventArgs e)
		{
			bool validacion = Validar();
			int nResultado = -1;

			if (validacion == true)
				{
				CargarAlumno();
				nResultado = adminAlumno.abmAlumno("Modificar", alumno);
				if (nResultado != -1)
				{
					MessageBox.Show("El alumno fue modificado con exito");
					LlenarAlum();
					LlenarPag();




				}
				else
				{
					MessageBox.Show("ERROR no se pudo modificar el alumno");
				}
			}









		}
	}
}