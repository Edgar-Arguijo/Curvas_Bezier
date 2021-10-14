namespace Curvas_Bezier
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtX1 = new System.Windows.Forms.NumericUpDown();
            this.txtY1 = new System.Windows.Forms.NumericUpDown();
            this.txtX2 = new System.Windows.Forms.NumericUpDown();
            this.txtY2 = new System.Windows.Forms.NumericUpDown();
            this.txtY4 = new System.Windows.Forms.NumericUpDown();
            this.txtX4 = new System.Windows.Forms.NumericUpDown();
            this.txtY3 = new System.Windows.Forms.NumericUpDown();
            this.txtX3 = new System.Windows.Forms.NumericUpDown();
            this.txtY5 = new System.Windows.Forms.NumericUpDown();
            this.txtX5 = new System.Windows.Forms.NumericUpDown();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP3 = new System.Windows.Forms.Label();
            this.lblP4 = new System.Windows.Forms.Label();
            this.lblP5 = new System.Windows.Forms.Label();
            this.btnPunto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnGrafica = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDibujo = new System.Windows.Forms.Label();
            this.btnAutores = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX5)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(123)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.label5.Location = new System.Drawing.Point(248, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 45);
            this.label5.TabIndex = 32;
            this.label5.Text = "CURVA DE BEZIER";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Curvas_Bezier.Properties.Resources.Imagen1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveBorderThickness = 1;
            this.bunifuImageButton1.ActiveCornerRadius = 20;
            this.bunifuImageButton1.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuImageButton1.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuImageButton1.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(123)))), ((int)(((byte)(218)))));
            this.bunifuImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.BackgroundImage")));
            this.bunifuImageButton1.ButtonText = "  X ";
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuImageButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuImageButton1.IdleBorderThickness = 1;
            this.bunifuImageButton1.IdleCornerRadius = 20;
            this.bunifuImageButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.bunifuImageButton1.IdleForecolor = System.Drawing.Color.White;
            this.bunifuImageButton1.IdleLineColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Location = new System.Drawing.Point(729, 5);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(57, 41);
            this.bunifuImageButton1.TabIndex = 30;
            this.bunifuImageButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(123)))), ((int)(((byte)(218)))));
            this.pictureBox1.Location = new System.Drawing.Point(362, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(34, 135);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(34, 197);
            this.txtX1.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtX1.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(120, 20);
            this.txtX1.TabIndex = 3;
            this.txtX1.Visible = false;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(197, 197);
            this.txtY1.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtY1.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(120, 20);
            this.txtY1.TabIndex = 4;
            this.txtY1.Visible = false;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(34, 248);
            this.txtX2.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtX2.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(120, 20);
            this.txtX2.TabIndex = 5;
            this.txtX2.Visible = false;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(197, 248);
            this.txtY2.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtY2.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(120, 20);
            this.txtY2.TabIndex = 6;
            this.txtY2.Visible = false;
            // 
            // txtY4
            // 
            this.txtY4.Location = new System.Drawing.Point(197, 353);
            this.txtY4.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtY4.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.txtY4.Name = "txtY4";
            this.txtY4.Size = new System.Drawing.Size(120, 20);
            this.txtY4.TabIndex = 10;
            this.txtY4.Visible = false;
            // 
            // txtX4
            // 
            this.txtX4.Location = new System.Drawing.Point(34, 353);
            this.txtX4.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtX4.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.txtX4.Name = "txtX4";
            this.txtX4.Size = new System.Drawing.Size(120, 20);
            this.txtX4.TabIndex = 9;
            this.txtX4.Visible = false;
            // 
            // txtY3
            // 
            this.txtY3.Location = new System.Drawing.Point(197, 302);
            this.txtY3.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtY3.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.txtY3.Name = "txtY3";
            this.txtY3.Size = new System.Drawing.Size(120, 20);
            this.txtY3.TabIndex = 8;
            this.txtY3.Visible = false;
            // 
            // txtX3
            // 
            this.txtX3.Location = new System.Drawing.Point(34, 302);
            this.txtX3.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtX3.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(120, 20);
            this.txtX3.TabIndex = 7;
            this.txtX3.Visible = false;
            // 
            // txtY5
            // 
            this.txtY5.Location = new System.Drawing.Point(197, 407);
            this.txtY5.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtY5.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.txtY5.Name = "txtY5";
            this.txtY5.Size = new System.Drawing.Size(120, 20);
            this.txtY5.TabIndex = 14;
            this.txtY5.Visible = false;
            // 
            // txtX5
            // 
            this.txtX5.Location = new System.Drawing.Point(34, 407);
            this.txtX5.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.txtX5.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.txtX5.Name = "txtX5";
            this.txtX5.Size = new System.Drawing.Size(120, 20);
            this.txtX5.TabIndex = 13;
            this.txtX5.Visible = false;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPuntos.Location = new System.Drawing.Point(29, 106);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(122, 16);
            this.lblPuntos.TabIndex = 15;
            this.lblPuntos.Text = "Número de Puntos:";
            this.lblPuntos.Visible = false;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblP1.Location = new System.Drawing.Point(31, 178);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(52, 16);
            this.lblP1.TabIndex = 16;
            this.lblP1.Text = "Punto 1";
            this.lblP1.Visible = false;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblP2.Location = new System.Drawing.Point(31, 229);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(52, 16);
            this.lblP2.TabIndex = 17;
            this.lblP2.Text = "Punto 2";
            this.lblP2.Visible = false;
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblP3.Location = new System.Drawing.Point(31, 283);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(52, 16);
            this.lblP3.TabIndex = 18;
            this.lblP3.Text = "Punto 3";
            this.lblP3.Visible = false;
            // 
            // lblP4
            // 
            this.lblP4.AutoSize = true;
            this.lblP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblP4.Location = new System.Drawing.Point(31, 334);
            this.lblP4.Name = "lblP4";
            this.lblP4.Size = new System.Drawing.Size(52, 16);
            this.lblP4.TabIndex = 19;
            this.lblP4.Text = "Punto 4";
            this.lblP4.Visible = false;
            // 
            // lblP5
            // 
            this.lblP5.AutoSize = true;
            this.lblP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblP5.Location = new System.Drawing.Point(31, 388);
            this.lblP5.Name = "lblP5";
            this.lblP5.Size = new System.Drawing.Size(52, 16);
            this.lblP5.TabIndex = 20;
            this.lblP5.Text = "Punto 5";
            this.lblP5.Visible = false;
            // 
            // btnPunto
            // 
            this.btnPunto.ActiveBorderThickness = 1;
            this.btnPunto.ActiveCornerRadius = 20;
            this.btnPunto.ActiveFillColor = System.Drawing.Color.White;
            this.btnPunto.ActiveForecolor = System.Drawing.Color.Black;
            this.btnPunto.ActiveLineColor = System.Drawing.Color.White;
            this.btnPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.btnPunto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPunto.BackgroundImage")));
            this.btnPunto.ButtonText = "PUNTOS";
            this.btnPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.Color.Black;
            this.btnPunto.IdleBorderThickness = 1;
            this.btnPunto.IdleCornerRadius = 20;
            this.btnPunto.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.btnPunto.IdleForecolor = System.Drawing.Color.White;
            this.btnPunto.IdleLineColor = System.Drawing.Color.White;
            this.btnPunto.Location = new System.Drawing.Point(208, 123);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(5);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(95, 41);
            this.btnPunto.TabIndex = 21;
            this.btnPunto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPunto.Visible = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ActiveBorderThickness = 1;
            this.btnLimpiar.ActiveCornerRadius = 20;
            this.btnLimpiar.ActiveFillColor = System.Drawing.Color.White;
            this.btnLimpiar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnLimpiar.ActiveLineColor = System.Drawing.Color.Black;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.ButtonText = "LIMPIAR";
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.IdleBorderThickness = 1;
            this.btnLimpiar.IdleCornerRadius = 20;
            this.btnLimpiar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.btnLimpiar.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnLimpiar.IdleLineColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(208, 456);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 41);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BtnGrafica
            // 
            this.BtnGrafica.ActiveBorderThickness = 1;
            this.BtnGrafica.ActiveCornerRadius = 20;
            this.BtnGrafica.ActiveFillColor = System.Drawing.Color.White;
            this.BtnGrafica.ActiveForecolor = System.Drawing.Color.Black;
            this.BtnGrafica.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnGrafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.BtnGrafica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGrafica.BackgroundImage")));
            this.BtnGrafica.ButtonText = "GRAFICAR";
            this.BtnGrafica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGrafica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrafica.ForeColor = System.Drawing.Color.Black;
            this.BtnGrafica.IdleBorderThickness = 1;
            this.BtnGrafica.IdleCornerRadius = 20;
            this.BtnGrafica.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.BtnGrafica.IdleForecolor = System.Drawing.Color.White;
            this.BtnGrafica.IdleLineColor = System.Drawing.Color.White;
            this.BtnGrafica.Location = new System.Drawing.Point(43, 456);
            this.BtnGrafica.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGrafica.Name = "BtnGrafica";
            this.BtnGrafica.Size = new System.Drawing.Size(108, 41);
            this.BtnGrafica.TabIndex = 23;
            this.BtnGrafica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGrafica.Click += new System.EventHandler(this.BtnGrafica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(417, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(500, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.label3.Location = new System.Drawing.Point(682, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.label4.Location = new System.Drawing.Point(599, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "label4";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manualmente",
            "Mouse"});
            this.comboBox1.Location = new System.Drawing.Point(139, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDibujo
            // 
            this.lblDibujo.AutoSize = true;
            this.lblDibujo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDibujo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDibujo.Location = new System.Drawing.Point(79, 67);
            this.lblDibujo.Name = "lblDibujo";
            this.lblDibujo.Size = new System.Drawing.Size(54, 16);
            this.lblDibujo.TabIndex = 29;
            this.lblDibujo.Text = "Dibujar:";
            // 
            // btnAutores
            // 
            this.btnAutores.ActiveBorderThickness = 1;
            this.btnAutores.ActiveCornerRadius = 20;
            this.btnAutores.ActiveFillColor = System.Drawing.Color.White;
            this.btnAutores.ActiveForecolor = System.Drawing.Color.Black;
            this.btnAutores.ActiveLineColor = System.Drawing.Color.Black;
            this.btnAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.btnAutores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutores.BackgroundImage")));
            this.btnAutores.ButtonText = "AUTOR";
            this.btnAutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.ForeColor = System.Drawing.Color.Black;
            this.btnAutores.IdleBorderThickness = 1;
            this.btnAutores.IdleCornerRadius = 20;
            this.btnAutores.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(64)))), ((int)(((byte)(121)))));
            this.btnAutores.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnAutores.IdleLineColor = System.Drawing.Color.White;
            this.btnAutores.Location = new System.Drawing.Point(709, 470);
            this.btnAutores.Margin = new System.Windows.Forms.Padding(5);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(81, 37);
            this.btnAutores.TabIndex = 31;
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(89)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.lblDibujo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGrafica);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.lblP5);
            this.Controls.Add(this.lblP4);
            this.Controls.Add(this.lblP3);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.txtY5);
            this.Controls.Add(this.txtX5);
            this.Controls.Add(this.txtY4);
            this.Controls.Add(this.txtX4);
            this.Controls.Add(this.txtY3);
            this.Controls.Add(this.txtX3);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Label lblP2;
		private System.Windows.Forms.Label lblP1;
		private System.Windows.Forms.Label lblPuntos;
		private System.Windows.Forms.NumericUpDown txtY5;
		private System.Windows.Forms.NumericUpDown txtX5;
		private System.Windows.Forms.NumericUpDown txtY4;
		private System.Windows.Forms.NumericUpDown txtX4;
		private System.Windows.Forms.NumericUpDown txtY3;
		private System.Windows.Forms.NumericUpDown txtX3;
		private System.Windows.Forms.NumericUpDown txtY2;
		private System.Windows.Forms.NumericUpDown txtX2;
		private System.Windows.Forms.NumericUpDown txtY1;
		private System.Windows.Forms.NumericUpDown txtX1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuThinButton2 btnPunto;
		private System.Windows.Forms.Label lblP5;
		private System.Windows.Forms.Label lblP4;
		private System.Windows.Forms.Label lblP3;
		private Bunifu.Framework.UI.BunifuThinButton2 BtnGrafica;
		private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblDibujo;
		private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAutores;
    }
}

