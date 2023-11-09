namespace ProyectoAlumno
	{
	partial class Form1
		{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
			{
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			lblMensaje = new Label();
			Check_Analitico = new CheckBox();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			Txt_Apellido = new TextBox();
			Txt_Legajo = new TextBox();
			Txt_Nombre = new TextBox();
			Txt_DNI = new TextBox();
			Bt_borrar = new Button();
			Bt_Cargar_alm = new Button();
			tabControl2 = new TabPage();
			lblMensaje1 = new Label();
			label6 = new Label();
			Fecha = new DateTimePicker();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			Txt_Monto = new TextBox();
			Txt_Descrip = new TextBox();
			Txt_DNI_Pago = new TextBox();
			Txt_Cuota = new TextBox();
			Txt_COD = new TextBox();
			Bt_Eliminar_Pag = new Button();
			BT_Cargar_Pag = new Button();
			Dt_Pago = new DataGridView();
			Dt_Alumno = new DataGridView();
			Bt_Modificar = new Button();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Dt_Pago).BeginInit();
			((System.ComponentModel.ISupportInitialize)Dt_Alumno).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabControl2);
			tabControl1.Location = new Point(10, 9);
			tabControl1.Margin = new Padding(3, 2, 3, 2);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(885, 160);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(Bt_Modificar);
			tabPage1.Controls.Add(lblMensaje);
			tabPage1.Controls.Add(Check_Analitico);
			tabPage1.Controls.Add(label10);
			tabPage1.Controls.Add(label9);
			tabPage1.Controls.Add(label8);
			tabPage1.Controls.Add(label7);
			tabPage1.Controls.Add(Txt_Apellido);
			tabPage1.Controls.Add(Txt_Legajo);
			tabPage1.Controls.Add(Txt_Nombre);
			tabPage1.Controls.Add(Txt_DNI);
			tabPage1.Controls.Add(Bt_borrar);
			tabPage1.Controls.Add(Bt_Cargar_alm);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Margin = new Padding(3, 2, 3, 2);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3, 2, 3, 2);
			tabPage1.Size = new Size(877, 132);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Alumno";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// lblMensaje
			// 
			lblMensaje.AutoSize = true;
			lblMensaje.Location = new Point(34, 69);
			lblMensaje.Name = "lblMensaje";
			lblMensaje.Size = new Size(0, 15);
			lblMensaje.TabIndex = 14;
			// 
			// Check_Analitico
			// 
			Check_Analitico.AutoSize = true;
			Check_Analitico.Location = new Point(550, 31);
			Check_Analitico.Margin = new Padding(3, 2, 3, 2);
			Check_Analitico.Name = "Check_Analitico";
			Check_Analitico.Size = new Size(73, 19);
			Check_Analitico.TabIndex = 13;
			Check_Analitico.Text = "Analitico";
			Check_Analitico.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(404, 10);
			label10.Name = "label10";
			label10.Size = new Size(42, 15);
			label10.TabIndex = 11;
			label10.Text = "Legajo";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(276, 13);
			label9.Name = "label9";
			label9.Size = new Size(51, 15);
			label9.TabIndex = 10;
			label9.Text = "Apellido";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(146, 10);
			label8.Name = "label8";
			label8.Size = new Size(51, 15);
			label8.TabIndex = 9;
			label8.Text = "Nombre";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(14, 13);
			label7.Name = "label7";
			label7.Size = new Size(27, 15);
			label7.TabIndex = 8;
			label7.Text = "DNI";
			// 
			// Txt_Apellido
			// 
			Txt_Apellido.Location = new Point(276, 28);
			Txt_Apellido.Margin = new Padding(3, 2, 3, 2);
			Txt_Apellido.Name = "Txt_Apellido";
			Txt_Apellido.Size = new Size(110, 23);
			Txt_Apellido.TabIndex = 7;
			// 
			// Txt_Legajo
			// 
			Txt_Legajo.Location = new Point(404, 28);
			Txt_Legajo.Margin = new Padding(3, 2, 3, 2);
			Txt_Legajo.Name = "Txt_Legajo";
			Txt_Legajo.Size = new Size(110, 23);
			Txt_Legajo.TabIndex = 5;
			// 
			// Txt_Nombre
			// 
			Txt_Nombre.Location = new Point(145, 26);
			Txt_Nombre.Margin = new Padding(3, 2, 3, 2);
			Txt_Nombre.Name = "Txt_Nombre";
			Txt_Nombre.Size = new Size(110, 23);
			Txt_Nombre.TabIndex = 4;
			// 
			// Txt_DNI
			// 
			Txt_DNI.Location = new Point(13, 27);
			Txt_DNI.Margin = new Padding(3, 2, 3, 2);
			Txt_DNI.Name = "Txt_DNI";
			Txt_DNI.Size = new Size(110, 23);
			Txt_DNI.TabIndex = 3;
			// 
			// Bt_borrar
			// 
			Bt_borrar.Location = new Point(746, 65);
			Bt_borrar.Margin = new Padding(3, 2, 3, 2);
			Bt_borrar.Name = "Bt_borrar";
			Bt_borrar.Size = new Size(82, 22);
			Bt_borrar.TabIndex = 2;
			Bt_borrar.Text = "BORRAR";
			Bt_borrar.UseVisualStyleBackColor = true;
			Bt_borrar.Click += Bt_borrar_Click;
			// 
			// Bt_Cargar_alm
			// 
			Bt_Cargar_alm.Location = new Point(746, 28);
			Bt_Cargar_alm.Margin = new Padding(3, 2, 3, 2);
			Bt_Cargar_alm.Name = "Bt_Cargar_alm";
			Bt_Cargar_alm.Size = new Size(82, 22);
			Bt_Cargar_alm.TabIndex = 1;
			Bt_Cargar_alm.Text = "CARGAR";
			Bt_Cargar_alm.UseVisualStyleBackColor = true;
			Bt_Cargar_alm.Click += Bt_Cargar_alm_Click;
			// 
			// tabControl2
			// 
			tabControl2.Controls.Add(lblMensaje1);
			tabControl2.Controls.Add(label6);
			tabControl2.Controls.Add(Fecha);
			tabControl2.Controls.Add(label5);
			tabControl2.Controls.Add(label4);
			tabControl2.Controls.Add(label3);
			tabControl2.Controls.Add(label2);
			tabControl2.Controls.Add(label1);
			tabControl2.Controls.Add(Txt_Monto);
			tabControl2.Controls.Add(Txt_Descrip);
			tabControl2.Controls.Add(Txt_DNI_Pago);
			tabControl2.Controls.Add(Txt_Cuota);
			tabControl2.Controls.Add(Txt_COD);
			tabControl2.Controls.Add(Bt_Eliminar_Pag);
			tabControl2.Controls.Add(BT_Cargar_Pag);
			tabControl2.Location = new Point(4, 24);
			tabControl2.Margin = new Padding(3, 2, 3, 2);
			tabControl2.Name = "tabControl2";
			tabControl2.Padding = new Padding(3, 2, 3, 2);
			tabControl2.Size = new Size(877, 132);
			tabControl2.TabIndex = 1;
			tabControl2.Text = "Pago";
			tabControl2.UseVisualStyleBackColor = true;
			// 
			// lblMensaje1
			// 
			lblMensaje1.AutoSize = true;
			lblMensaje1.Location = new Point(20, 102);
			lblMensaje1.Name = "lblMensaje1";
			lblMensaje1.Size = new Size(0, 15);
			lblMensaje1.TabIndex = 17;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(449, 7);
			label6.Name = "label6";
			label6.Size = new Size(87, 15);
			label6.TabIndex = 16;
			label6.Text = "Fecha del pago";
			// 
			// Fecha
			// 
			Fecha.Location = new Point(449, 24);
			Fecha.Margin = new Padding(3, 2, 3, 2);
			Fecha.Name = "Fecha";
			Fecha.Size = new Size(219, 23);
			Fecha.TabIndex = 15;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(298, 6);
			label5.Name = "label5";
			label5.Size = new Size(106, 15);
			label5.TabIndex = 14;
			label5.Text = "Monto de la Cuota";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(161, 45);
			label4.Name = "label4";
			label4.Size = new Size(69, 15);
			label4.TabIndex = 13;
			label4.Text = "Descripcion";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(161, 4);
			label3.Name = "label3";
			label3.Size = new Size(95, 15);
			label3.TabIndex = 12;
			label3.Text = "DNI del ALumno";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(16, 50);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 11;
			label2.Text = "Cuota";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 4);
			label1.Name = "label1";
			label1.Size = new Size(46, 15);
			label1.TabIndex = 10;
			label1.Text = "Codigo";
			// 
			// Txt_Monto
			// 
			Txt_Monto.Location = new Point(298, 22);
			Txt_Monto.Margin = new Padding(3, 2, 3, 2);
			Txt_Monto.Name = "Txt_Monto";
			Txt_Monto.Size = new Size(110, 23);
			Txt_Monto.TabIndex = 8;
			// 
			// Txt_Descrip
			// 
			Txt_Descrip.Location = new Point(161, 62);
			Txt_Descrip.Margin = new Padding(3, 2, 3, 2);
			Txt_Descrip.Name = "Txt_Descrip";
			Txt_Descrip.Size = new Size(110, 23);
			Txt_Descrip.TabIndex = 7;
			// 
			// Txt_DNI_Pago
			// 
			Txt_DNI_Pago.Location = new Point(161, 22);
			Txt_DNI_Pago.Margin = new Padding(3, 2, 3, 2);
			Txt_DNI_Pago.Name = "Txt_DNI_Pago";
			Txt_DNI_Pago.Size = new Size(110, 23);
			Txt_DNI_Pago.TabIndex = 6;
			// 
			// Txt_Cuota
			// 
			Txt_Cuota.Location = new Point(16, 62);
			Txt_Cuota.Margin = new Padding(3, 2, 3, 2);
			Txt_Cuota.Name = "Txt_Cuota";
			Txt_Cuota.Size = new Size(110, 23);
			Txt_Cuota.TabIndex = 5;
			// 
			// Txt_COD
			// 
			Txt_COD.Location = new Point(16, 22);
			Txt_COD.Margin = new Padding(3, 2, 3, 2);
			Txt_COD.Name = "Txt_COD";
			Txt_COD.Size = new Size(110, 23);
			Txt_COD.TabIndex = 4;
			// 
			// Bt_Eliminar_Pag
			// 
			Bt_Eliminar_Pag.Location = new Point(773, 58);
			Bt_Eliminar_Pag.Margin = new Padding(3, 2, 3, 2);
			Bt_Eliminar_Pag.Name = "Bt_Eliminar_Pag";
			Bt_Eliminar_Pag.Size = new Size(82, 22);
			Bt_Eliminar_Pag.TabIndex = 3;
			Bt_Eliminar_Pag.Text = "Eliminar";
			Bt_Eliminar_Pag.UseVisualStyleBackColor = true;
			Bt_Eliminar_Pag.Click += Bt_Eliminar_Pag_Click;
			// 
			// BT_Cargar_Pag
			// 
			BT_Cargar_Pag.Location = new Point(773, 21);
			BT_Cargar_Pag.Margin = new Padding(3, 2, 3, 2);
			BT_Cargar_Pag.Name = "BT_Cargar_Pag";
			BT_Cargar_Pag.Size = new Size(82, 22);
			BT_Cargar_Pag.TabIndex = 2;
			BT_Cargar_Pag.Text = "Cargar";
			BT_Cargar_Pag.UseVisualStyleBackColor = true;
			BT_Cargar_Pag.Click += BT_Cargar_Pag_Click;
			// 
			// Dt_Pago
			// 
			Dt_Pago.AllowUserToAddRows = false;
			Dt_Pago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dt_Pago.Location = new Point(463, 196);
			Dt_Pago.Margin = new Padding(3, 2, 3, 2);
			Dt_Pago.Name = "Dt_Pago";
			Dt_Pago.ReadOnly = true;
			Dt_Pago.RowHeadersWidth = 51;
			Dt_Pago.RowTemplate.Height = 29;
			Dt_Pago.Size = new Size(429, 252);
			Dt_Pago.TabIndex = 1;
			// 
			// Dt_Alumno
			// 
			Dt_Alumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dt_Alumno.Location = new Point(14, 196);
			Dt_Alumno.Margin = new Padding(3, 2, 3, 2);
			Dt_Alumno.Name = "Dt_Alumno";
			Dt_Alumno.RowHeadersWidth = 51;
			Dt_Alumno.RowTemplate.Height = 29;
			Dt_Alumno.Size = new Size(428, 252);
			Dt_Alumno.TabIndex = 0;
			// 
			// Bt_Modificar
			// 
			Bt_Modificar.Location = new Point(746, 104);
			Bt_Modificar.Name = "Bt_Modificar";
			Bt_Modificar.Size = new Size(82, 23);
			Bt_Modificar.TabIndex = 15;
			Bt_Modificar.Text = "MODIFICAR";
			Bt_Modificar.UseVisualStyleBackColor = true;
			Bt_Modificar.Click += Bt_Modificar_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(911, 457);
			Controls.Add(tabControl1);
			Controls.Add(Dt_Alumno);
			Controls.Add(Dt_Pago);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Form1";
			Text = "CAJA DE ITSC";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			tabControl2.ResumeLayout(false);
			tabControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)Dt_Pago).EndInit();
			((System.ComponentModel.ISupportInitialize)Dt_Alumno).EndInit();
			ResumeLayout(false);
			}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabControl2;
		private DataGridView Dt_Alumno;
		private Button Bt_borrar;
		private Button Bt_Cargar_alm;
		private Button Bt_Eliminar_Pag;
		private Button BT_Cargar_Pag;
		private DataGridView Dt_Pago;
		private TextBox Txt_Apellido;
		private TextBox Txt_Legajo;
		private TextBox Txt_Nombre;
		private TextBox Txt_DNI;
		private TextBox Txt_DNI_Pago;
		private TextBox Txt_Cuota;
		private TextBox Txt_COD;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox Txt_Monto;
		private TextBox Txt_Descrip;
		private CheckBox Check_Analitico;
		private Label label6;
		private DateTimePicker Fecha;
		private Label lblMensaje;
		private Label lblMensaje1;
		private Button Bt_Modificar;
		}
	}