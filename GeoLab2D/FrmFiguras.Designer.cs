namespace GeoLab2D
{
    partial class FrmFiguras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlControles = new System.Windows.Forms.Panel();
            this.tabsHerramientas = new System.Windows.Forms.TabControl();
            this.tabFiguras = new System.Windows.Forms.TabPage();
            this.btnLimpiarF = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.txtRadioLado = new System.Windows.Forms.TextBox();
            this.txtCentroY = new System.Windows.Forms.TextBox();
            this.txtCentroX = new System.Windows.Forms.TextBox();
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblCentroY = new System.Windows.Forms.Label();
            this.lblCentroX = new System.Windows.Forms.Label();
            this.lblFigura = new System.Windows.Forms.Label();
            this.tabGeometria = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblPuntoDentro = new System.Windows.Forms.Label();
            this.lblProyeccion = new System.Windows.Forms.Label();
            this.txtPuntoPY = new System.Windows.Forms.TextBox();
            this.txtPuntoPX = new System.Windows.Forms.TextBox();
            this.lblPuntoPY = new System.Windows.Forms.Label();
            this.lblPuntoPX = new System.Windows.Forms.Label();
            this.txtBY = new System.Windows.Forms.TextBox();
            this.txtBX = new System.Windows.Forms.TextBox();
            this.txtAY = new System.Windows.Forms.TextBox();
            this.txtAX = new System.Windows.Forms.TextBox();
            this.lblPuntoP = new System.Windows.Forms.Label();
            this.lblBY = new System.Windows.Forms.Label();
            this.lblBX = new System.Windows.Forms.Label();
            this.lblExtremoB = new System.Windows.Forms.Label();
            this.lblAY = new System.Windows.Forms.Label();
            this.lblAX = new System.Windows.Forms.Label();
            this.lblExtremoA = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.txtPuntoY = new System.Windows.Forms.TextBox();
            this.txtPuntoX = new System.Windows.Forms.TextBox();
            this.lblPuntoY = new System.Windows.Forms.Label();
            this.lblPuntoX = new System.Windows.Forms.Label();
            this.btnProyeccion = new System.Windows.Forms.Button();
            this.btnPuntoDentro = new System.Windows.Forms.Button();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.tabTransformaciones = new System.Windows.Forms.TabPage();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnEscalar = new System.Windows.Forms.Button();
            this.btnRotar = new System.Windows.Forms.Button();
            this.btnTrasladar = new System.Windows.Forms.Button();
            this.txtEscalaY = new System.Windows.Forms.TextBox();
            this.txtEscalaX = new System.Windows.Forms.TextBox();
            this.txtRotacion = new System.Windows.Forms.TextBox();
            this.txtTrasladarY = new System.Windows.Forms.TextBox();
            this.txtTrasladarX = new System.Windows.Forms.TextBox();
            this.lblEscalaY = new System.Windows.Forms.Label();
            this.lblEscalaX = new System.Windows.Forms.Label();
            this.lblRotacion = new System.Windows.Forms.Label();
            this.lblTrasladarY = new System.Windows.Forms.Label();
            this.lblTrasladarX = new System.Windows.Forms.Label();
            this.pnlLienzo = new System.Windows.Forms.Panel();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloRotacion = new System.Windows.Forms.Label();
            this.lblTituloEscalamiento = new System.Windows.Forms.Label();
            this.lblNumeroLados = new System.Windows.Forms.Label();
            this.txtNumeroLados = new System.Windows.Forms.TextBox();
            this.pnlControles.SuspendLayout();
            this.tabsHerramientas.SuspendLayout();
            this.tabFiguras.SuspendLayout();
            this.tabGeometria.SuspendLayout();
            this.tabTransformaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControles
            // 
            this.pnlControles.Controls.Add(this.tabsHerramientas);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControles.Location = new System.Drawing.Point(0, 0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(404, 964);
            this.pnlControles.TabIndex = 0;
            // 
            // tabsHerramientas
            // 
            this.tabsHerramientas.Controls.Add(this.tabFiguras);
            this.tabsHerramientas.Controls.Add(this.tabGeometria);
            this.tabsHerramientas.Controls.Add(this.tabTransformaciones);
            this.tabsHerramientas.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabsHerramientas.Location = new System.Drawing.Point(0, 0);
            this.tabsHerramientas.Name = "tabsHerramientas";
            this.tabsHerramientas.SelectedIndex = 0;
            this.tabsHerramientas.Size = new System.Drawing.Size(410, 964);
            this.tabsHerramientas.TabIndex = 4;
            // 
            // tabFiguras
            // 
            this.tabFiguras.Controls.Add(this.txtNumeroLados);
            this.tabFiguras.Controls.Add(this.lblNumeroLados);
            this.tabFiguras.Controls.Add(this.btnLimpiarF);
            this.tabFiguras.Controls.Add(this.btnDibujar);
            this.tabFiguras.Controls.Add(this.txtAngulo);
            this.tabFiguras.Controls.Add(this.txtRadioLado);
            this.tabFiguras.Controls.Add(this.txtCentroY);
            this.tabFiguras.Controls.Add(this.txtCentroX);
            this.tabFiguras.Controls.Add(this.cmbFigura);
            this.tabFiguras.Controls.Add(this.lblAngulo);
            this.tabFiguras.Controls.Add(this.lblRadio);
            this.tabFiguras.Controls.Add(this.lblCentroY);
            this.tabFiguras.Controls.Add(this.lblCentroX);
            this.tabFiguras.Controls.Add(this.lblFigura);
            this.tabFiguras.Location = new System.Drawing.Point(4, 29);
            this.tabFiguras.Name = "tabFiguras";
            this.tabFiguras.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiguras.Size = new System.Drawing.Size(402, 931);
            this.tabFiguras.TabIndex = 0;
            this.tabFiguras.Text = "Figuras";
            this.tabFiguras.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarF
            // 
            this.btnLimpiarF.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLimpiarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiarF.Location = new System.Drawing.Point(206, 462);
            this.btnLimpiarF.Name = "btnLimpiarF";
            this.btnLimpiarF.Size = new System.Drawing.Size(125, 70);
            this.btnLimpiarF.TabIndex = 33;
            this.btnLimpiarF.Text = "Limpiar";
            this.btnLimpiarF.UseVisualStyleBackColor = false;
            this.btnLimpiarF.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDibujar.Location = new System.Drawing.Point(37, 462);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(153, 70);
            this.btnDibujar.TabIndex = 32;
            this.btnDibujar.Text = "Dibujar figura";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // txtAngulo
            // 
            this.txtAngulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngulo.Location = new System.Drawing.Point(143, 400);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(100, 26);
            this.txtAngulo.TabIndex = 31;
            this.txtAngulo.Text = "0";
            // 
            // txtRadioLado
            // 
            this.txtRadioLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadioLado.Location = new System.Drawing.Point(51, 298);
            this.txtRadioLado.Name = "txtRadioLado";
            this.txtRadioLado.Size = new System.Drawing.Size(100, 26);
            this.txtRadioLado.TabIndex = 30;
            this.txtRadioLado.Text = "80";
            // 
            // txtCentroY
            // 
            this.txtCentroY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentroY.Location = new System.Drawing.Point(205, 198);
            this.txtCentroY.Name = "txtCentroY";
            this.txtCentroY.Size = new System.Drawing.Size(100, 26);
            this.txtCentroY.TabIndex = 29;
            this.txtCentroY.Text = "300";
            // 
            // txtCentroX
            // 
            this.txtCentroX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentroX.Location = new System.Drawing.Point(51, 198);
            this.txtCentroX.Name = "txtCentroX";
            this.txtCentroX.Size = new System.Drawing.Size(100, 26);
            this.txtCentroX.TabIndex = 28;
            this.txtCentroX.Text = "400";
            // 
            // cmbFigura
            // 
            this.cmbFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Items.AddRange(new object[] {
            "Hexágono",
            "Flor margarita",
            "Polígono estrellado"});
            this.cmbFigura.Location = new System.Drawing.Point(94, 85);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(167, 28);
            this.cmbFigura.TabIndex = 27;
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngulo.Location = new System.Drawing.Point(143, 365);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(100, 22);
            this.lblAngulo.TabIndex = 26;
            this.lblAngulo.Text = "Ángulo (°)";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadio.Location = new System.Drawing.Point(47, 266);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(62, 22);
            this.lblRadio.TabIndex = 25;
            this.lblRadio.Text = "Radio";
            // 
            // lblCentroY
            // 
            this.lblCentroY.AutoSize = true;
            this.lblCentroY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroY.Location = new System.Drawing.Point(202, 162);
            this.lblCentroY.Name = "lblCentroY";
            this.lblCentroY.Size = new System.Drawing.Size(89, 22);
            this.lblCentroY.TabIndex = 24;
            this.lblCentroY.Text = "Centro Y";
            // 
            // lblCentroX
            // 
            this.lblCentroX.AutoSize = true;
            this.lblCentroX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroX.Location = new System.Drawing.Point(47, 162);
            this.lblCentroX.Name = "lblCentroX";
            this.lblCentroX.Size = new System.Drawing.Size(89, 22);
            this.lblCentroX.TabIndex = 23;
            this.lblCentroX.Text = "Centro X";
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigura.Location = new System.Drawing.Point(90, 46);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(184, 22);
            this.lblFigura.TabIndex = 22;
            this.lblFigura.Text = "Seleccionar figura: ";
            // 
            // tabGeometria
            // 
            this.tabGeometria.Controls.Add(this.lblArea);
            this.tabGeometria.Controls.Add(this.btnLimpiar);
            this.tabGeometria.Controls.Add(this.lblPuntoDentro);
            this.tabGeometria.Controls.Add(this.lblProyeccion);
            this.tabGeometria.Controls.Add(this.txtPuntoPY);
            this.tabGeometria.Controls.Add(this.txtPuntoPX);
            this.tabGeometria.Controls.Add(this.lblPuntoPY);
            this.tabGeometria.Controls.Add(this.lblPuntoPX);
            this.tabGeometria.Controls.Add(this.txtBY);
            this.tabGeometria.Controls.Add(this.txtBX);
            this.tabGeometria.Controls.Add(this.txtAY);
            this.tabGeometria.Controls.Add(this.txtAX);
            this.tabGeometria.Controls.Add(this.lblPuntoP);
            this.tabGeometria.Controls.Add(this.lblBY);
            this.tabGeometria.Controls.Add(this.lblBX);
            this.tabGeometria.Controls.Add(this.lblExtremoB);
            this.tabGeometria.Controls.Add(this.lblAY);
            this.tabGeometria.Controls.Add(this.lblAX);
            this.tabGeometria.Controls.Add(this.lblExtremoA);
            this.tabGeometria.Controls.Add(this.lblResultados);
            this.tabGeometria.Controls.Add(this.txtPuntoY);
            this.tabGeometria.Controls.Add(this.txtPuntoX);
            this.tabGeometria.Controls.Add(this.lblPuntoY);
            this.tabGeometria.Controls.Add(this.lblPuntoX);
            this.tabGeometria.Controls.Add(this.btnProyeccion);
            this.tabGeometria.Controls.Add(this.btnPuntoDentro);
            this.tabGeometria.Controls.Add(this.btnPerimetro);
            this.tabGeometria.Controls.Add(this.btnArea);
            this.tabGeometria.Location = new System.Drawing.Point(4, 29);
            this.tabGeometria.Name = "tabGeometria";
            this.tabGeometria.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeometria.Size = new System.Drawing.Size(402, 931);
            this.tabGeometria.TabIndex = 1;
            this.tabGeometria.Text = "Geometría";
            this.tabGeometria.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(102, 810);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(159, 64);
            this.btnLimpiar.TabIndex = 71;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblPuntoDentro
            // 
            this.lblPuntoDentro.AutoSize = true;
            this.lblPuntoDentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoDentro.Location = new System.Drawing.Point(21, 19);
            this.lblPuntoDentro.Name = "lblPuntoDentro";
            this.lblPuntoDentro.Size = new System.Drawing.Size(258, 25);
            this.lblPuntoDentro.TabIndex = 70;
            this.lblPuntoDentro.Text = "Punto dentro del polígono";
            // 
            // lblProyeccion
            // 
            this.lblProyeccion.AutoSize = true;
            this.lblProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyeccion.Location = new System.Drawing.Point(21, 186);
            this.lblProyeccion.Name = "lblProyeccion";
            this.lblProyeccion.Size = new System.Drawing.Size(119, 25);
            this.lblProyeccion.TabIndex = 69;
            this.lblProyeccion.Text = "Proyección";
            // 
            // txtPuntoPY
            // 
            this.txtPuntoPY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoPY.Location = new System.Drawing.Point(77, 139);
            this.txtPuntoPY.Name = "txtPuntoPY";
            this.txtPuntoPY.Size = new System.Drawing.Size(100, 26);
            this.txtPuntoPY.TabIndex = 68;
            // 
            // txtPuntoPX
            // 
            this.txtPuntoPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoPX.Location = new System.Drawing.Point(77, 79);
            this.txtPuntoPX.Name = "txtPuntoPX";
            this.txtPuntoPX.Size = new System.Drawing.Size(100, 26);
            this.txtPuntoPX.TabIndex = 67;
            // 
            // lblPuntoPY
            // 
            this.lblPuntoPY.AutoSize = true;
            this.lblPuntoPY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoPY.Location = new System.Drawing.Point(62, 116);
            this.lblPuntoPY.Name = "lblPuntoPY";
            this.lblPuntoPY.Size = new System.Drawing.Size(26, 20);
            this.lblPuntoPY.TabIndex = 66;
            this.lblPuntoPY.Text = "Y:";
            // 
            // lblPuntoPX
            // 
            this.lblPuntoPX.AutoSize = true;
            this.lblPuntoPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoPX.Location = new System.Drawing.Point(62, 56);
            this.lblPuntoPX.Name = "lblPuntoPX";
            this.lblPuntoPX.Size = new System.Drawing.Size(26, 20);
            this.lblPuntoPX.TabIndex = 65;
            this.lblPuntoPX.Text = "X:";
            // 
            // txtBY
            // 
            this.txtBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBY.Location = new System.Drawing.Point(202, 347);
            this.txtBY.Name = "txtBY";
            this.txtBY.Size = new System.Drawing.Size(100, 26);
            this.txtBY.TabIndex = 64;
            // 
            // txtBX
            // 
            this.txtBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBX.Location = new System.Drawing.Point(202, 284);
            this.txtBX.Name = "txtBX";
            this.txtBX.Size = new System.Drawing.Size(100, 26);
            this.txtBX.TabIndex = 63;
            // 
            // txtAY
            // 
            this.txtAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAY.Location = new System.Drawing.Point(59, 347);
            this.txtAY.Name = "txtAY";
            this.txtAY.Size = new System.Drawing.Size(100, 26);
            this.txtAY.TabIndex = 62;
            // 
            // txtAX
            // 
            this.txtAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAX.Location = new System.Drawing.Point(56, 284);
            this.txtAX.Name = "txtAX";
            this.txtAX.Size = new System.Drawing.Size(100, 26);
            this.txtAX.TabIndex = 61;
            // 
            // lblPuntoP
            // 
            this.lblPuntoP.AutoSize = true;
            this.lblPuntoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoP.Location = new System.Drawing.Point(36, 399);
            this.lblPuntoP.Name = "lblPuntoP";
            this.lblPuntoP.Size = new System.Drawing.Size(81, 22);
            this.lblPuntoP.TabIndex = 60;
            this.lblPuntoP.Text = "Punto P";
            // 
            // lblBY
            // 
            this.lblBY.AutoSize = true;
            this.lblBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBY.Location = new System.Drawing.Point(198, 324);
            this.lblBY.Name = "lblBY";
            this.lblBY.Size = new System.Drawing.Size(48, 20);
            this.lblBY.TabIndex = 59;
            this.lblBY.Text = "B.Y: ";
            // 
            // lblBX
            // 
            this.lblBX.AutoSize = true;
            this.lblBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBX.Location = new System.Drawing.Point(206, 261);
            this.lblBX.Name = "lblBX";
            this.lblBX.Size = new System.Drawing.Size(43, 20);
            this.lblBX.TabIndex = 58;
            this.lblBX.Text = "B.X:";
            // 
            // lblExtremoB
            // 
            this.lblExtremoB.AutoSize = true;
            this.lblExtremoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtremoB.Location = new System.Drawing.Point(188, 225);
            this.lblExtremoB.Name = "lblExtremoB";
            this.lblExtremoB.Size = new System.Drawing.Size(102, 22);
            this.lblExtremoB.TabIndex = 57;
            this.lblExtremoB.Text = "Extremo B";
            // 
            // lblAY
            // 
            this.lblAY.AutoSize = true;
            this.lblAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAY.Location = new System.Drawing.Point(55, 324);
            this.lblAY.Name = "lblAY";
            this.lblAY.Size = new System.Drawing.Size(43, 20);
            this.lblAY.TabIndex = 56;
            this.lblAY.Text = "A.Y:";
            // 
            // lblAX
            // 
            this.lblAX.AutoSize = true;
            this.lblAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAX.Location = new System.Drawing.Point(56, 261);
            this.lblAX.Name = "lblAX";
            this.lblAX.Size = new System.Drawing.Size(43, 20);
            this.lblAX.TabIndex = 55;
            this.lblAX.Text = "A.X:";
            // 
            // lblExtremoA
            // 
            this.lblExtremoA.AutoSize = true;
            this.lblExtremoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtremoA.Location = new System.Drawing.Point(35, 225);
            this.lblExtremoA.Name = "lblExtremoA";
            this.lblExtremoA.Size = new System.Drawing.Size(102, 22);
            this.lblExtremoA.TabIndex = 54;
            this.lblExtremoA.Text = "Extremo A";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(74, 748);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(216, 25);
            this.lblResultados.TabIndex = 53;
            this.lblResultados.Text = "Resultados: pendientes";
            // 
            // txtPuntoY
            // 
            this.txtPuntoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoY.Location = new System.Drawing.Point(202, 462);
            this.txtPuntoY.Name = "txtPuntoY";
            this.txtPuntoY.Size = new System.Drawing.Size(100, 26);
            this.txtPuntoY.TabIndex = 52;
            // 
            // txtPuntoX
            // 
            this.txtPuntoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntoX.Location = new System.Drawing.Point(66, 462);
            this.txtPuntoX.Name = "txtPuntoX";
            this.txtPuntoX.Size = new System.Drawing.Size(100, 26);
            this.txtPuntoX.TabIndex = 51;
            // 
            // lblPuntoY
            // 
            this.lblPuntoY.AutoSize = true;
            this.lblPuntoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoY.Location = new System.Drawing.Point(198, 439);
            this.lblPuntoY.Name = "lblPuntoY";
            this.lblPuntoY.Size = new System.Drawing.Size(42, 20);
            this.lblPuntoY.TabIndex = 50;
            this.lblPuntoY.Text = "P.Y:";
            // 
            // lblPuntoX
            // 
            this.lblPuntoX.AutoSize = true;
            this.lblPuntoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoX.Location = new System.Drawing.Point(68, 438);
            this.lblPuntoX.Name = "lblPuntoX";
            this.lblPuntoX.Size = new System.Drawing.Size(42, 20);
            this.lblPuntoX.TabIndex = 49;
            this.lblPuntoX.Text = "P.X:";
            // 
            // btnProyeccion
            // 
            this.btnProyeccion.BackColor = System.Drawing.Color.Tomato;
            this.btnProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProyeccion.Location = new System.Drawing.Point(91, 514);
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Size = new System.Drawing.Size(188, 53);
            this.btnProyeccion.TabIndex = 48;
            this.btnProyeccion.Text = "Punto más cercano";
            this.btnProyeccion.UseVisualStyleBackColor = false;
            this.btnProyeccion.Click += new System.EventHandler(this.btnProyeccion_Click);
            // 
            // btnPuntoDentro
            // 
            this.btnPuntoDentro.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPuntoDentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntoDentro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPuntoDentro.Location = new System.Drawing.Point(210, 79);
            this.btnPuntoDentro.Name = "btnPuntoDentro";
            this.btnPuntoDentro.Size = new System.Drawing.Size(139, 67);
            this.btnPuntoDentro.TabIndex = 47;
            this.btnPuntoDentro.Text = "Comprobar punto";
            this.btnPuntoDentro.UseVisualStyleBackColor = false;
            this.btnPuntoDentro.Click += new System.EventHandler(this.btnPuntoDentro_Click);
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimetro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPerimetro.Location = new System.Drawing.Point(202, 638);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(128, 67);
            this.btnPerimetro.TabIndex = 46;
            this.btnPerimetro.Text = "Calcular perímetro";
            this.btnPerimetro.UseVisualStyleBackColor = false;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.PaleGreen;
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(56, 638);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(117, 67);
            this.btnArea.TabIndex = 45;
            this.btnArea.Text = "Calcular área";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // tabTransformaciones
            // 
            this.tabTransformaciones.Controls.Add(this.lblTituloEscalamiento);
            this.tabTransformaciones.Controls.Add(this.lblTituloRotacion);
            this.tabTransformaciones.Controls.Add(this.lblTitulo);
            this.tabTransformaciones.Controls.Add(this.btnLimpiar2);
            this.tabTransformaciones.Controls.Add(this.btnEscalar);
            this.tabTransformaciones.Controls.Add(this.btnRotar);
            this.tabTransformaciones.Controls.Add(this.btnTrasladar);
            this.tabTransformaciones.Controls.Add(this.txtEscalaY);
            this.tabTransformaciones.Controls.Add(this.txtEscalaX);
            this.tabTransformaciones.Controls.Add(this.txtRotacion);
            this.tabTransformaciones.Controls.Add(this.txtTrasladarY);
            this.tabTransformaciones.Controls.Add(this.txtTrasladarX);
            this.tabTransformaciones.Controls.Add(this.lblEscalaY);
            this.tabTransformaciones.Controls.Add(this.lblEscalaX);
            this.tabTransformaciones.Controls.Add(this.lblRotacion);
            this.tabTransformaciones.Controls.Add(this.lblTrasladarY);
            this.tabTransformaciones.Controls.Add(this.lblTrasladarX);
            this.tabTransformaciones.Location = new System.Drawing.Point(4, 29);
            this.tabTransformaciones.Name = "tabTransformaciones";
            this.tabTransformaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransformaciones.Size = new System.Drawing.Size(402, 931);
            this.tabTransformaciones.TabIndex = 2;
            this.tabTransformaciones.Text = "Transformaciones";
            this.tabTransformaciones.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar2.Location = new System.Drawing.Point(100, 636);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(172, 60);
            this.btnLimpiar2.TabIndex = 13;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = false;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEscalar
            // 
            this.btnEscalar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscalar.ForeColor = System.Drawing.Color.OldLace;
            this.btnEscalar.Location = new System.Drawing.Point(210, 492);
            this.btnEscalar.Name = "btnEscalar";
            this.btnEscalar.Size = new System.Drawing.Size(162, 80);
            this.btnEscalar.TabIndex = 12;
            this.btnEscalar.Text = "Aplicar escalamiento";
            this.btnEscalar.UseVisualStyleBackColor = false;
            this.btnEscalar.Click += new System.EventHandler(this.btnEscalar_Click);
            // 
            // btnRotar
            // 
            this.btnRotar.BackColor = System.Drawing.Color.Thistle;
            this.btnRotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRotar.Location = new System.Drawing.Point(229, 302);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(143, 60);
            this.btnRotar.TabIndex = 11;
            this.btnRotar.Text = "Aplicar rotación";
            this.btnRotar.UseVisualStyleBackColor = false;
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // btnTrasladar
            // 
            this.btnTrasladar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTrasladar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrasladar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrasladar.Location = new System.Drawing.Point(229, 110);
            this.btnTrasladar.Name = "btnTrasladar";
            this.btnTrasladar.Size = new System.Drawing.Size(143, 64);
            this.btnTrasladar.TabIndex = 10;
            this.btnTrasladar.Text = "Aplicar traslación";
            this.btnTrasladar.UseVisualStyleBackColor = false;
            this.btnTrasladar.Click += new System.EventHandler(this.btnTrasladar_Click);
            // 
            // txtEscalaY
            // 
            this.txtEscalaY.Location = new System.Drawing.Point(50, 574);
            this.txtEscalaY.Name = "txtEscalaY";
            this.txtEscalaY.Size = new System.Drawing.Size(100, 26);
            this.txtEscalaY.TabIndex = 9;
            // 
            // txtEscalaX
            // 
            this.txtEscalaX.Location = new System.Drawing.Point(50, 492);
            this.txtEscalaX.Name = "txtEscalaX";
            this.txtEscalaX.Size = new System.Drawing.Size(100, 26);
            this.txtEscalaX.TabIndex = 8;
            // 
            // txtRotacion
            // 
            this.txtRotacion.Location = new System.Drawing.Point(50, 336);
            this.txtRotacion.Name = "txtRotacion";
            this.txtRotacion.Size = new System.Drawing.Size(149, 26);
            this.txtRotacion.TabIndex = 7;
            // 
            // txtTrasladarY
            // 
            this.txtTrasladarY.Location = new System.Drawing.Point(61, 190);
            this.txtTrasladarY.Name = "txtTrasladarY";
            this.txtTrasladarY.Size = new System.Drawing.Size(100, 26);
            this.txtTrasladarY.TabIndex = 6;
            // 
            // txtTrasladarX
            // 
            this.txtTrasladarX.Location = new System.Drawing.Point(61, 110);
            this.txtTrasladarX.Name = "txtTrasladarX";
            this.txtTrasladarX.Size = new System.Drawing.Size(100, 26);
            this.txtTrasladarX.TabIndex = 5;
            // 
            // lblEscalaY
            // 
            this.lblEscalaY.AutoSize = true;
            this.lblEscalaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscalaY.Location = new System.Drawing.Point(46, 537);
            this.lblEscalaY.Name = "lblEscalaY";
            this.lblEscalaY.Size = new System.Drawing.Size(80, 20);
            this.lblEscalaY.TabIndex = 4;
            this.lblEscalaY.Text = "Escala Y";
            // 
            // lblEscalaX
            // 
            this.lblEscalaX.AutoSize = true;
            this.lblEscalaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscalaX.Location = new System.Drawing.Point(46, 455);
            this.lblEscalaX.Name = "lblEscalaX";
            this.lblEscalaX.Size = new System.Drawing.Size(80, 20);
            this.lblEscalaX.TabIndex = 3;
            this.lblEscalaX.Text = "Escala X";
            // 
            // lblRotacion
            // 
            this.lblRotacion.AutoSize = true;
            this.lblRotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotacion.Location = new System.Drawing.Point(46, 302);
            this.lblRotacion.Name = "lblRotacion";
            this.lblRotacion.Size = new System.Drawing.Size(160, 20);
            this.lblRotacion.TabIndex = 2;
            this.lblRotacion.Text = "Ángulo de rotación";
            // 
            // lblTrasladarY
            // 
            this.lblTrasladarY.AutoSize = true;
            this.lblTrasladarY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrasladarY.Location = new System.Drawing.Point(46, 152);
            this.lblTrasladarY.Name = "lblTrasladarY";
            this.lblTrasladarY.Size = new System.Drawing.Size(123, 22);
            this.lblTrasladarY.TabIndex = 1;
            this.lblTrasladarY.Text = "Traslación Y";
            // 
            // lblTrasladarX
            // 
            this.lblTrasladarX.AutoSize = true;
            this.lblTrasladarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrasladarX.Location = new System.Drawing.Point(46, 75);
            this.lblTrasladarX.Name = "lblTrasladarX";
            this.lblTrasladarX.Size = new System.Drawing.Size(123, 22);
            this.lblTrasladarX.TabIndex = 0;
            this.lblTrasladarX.Text = "Traslación X";
            // 
            // pnlLienzo
            // 
            this.pnlLienzo.BackColor = System.Drawing.Color.White;
            this.pnlLienzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLienzo.Location = new System.Drawing.Point(404, 0);
            this.pnlLienzo.Name = "pnlLienzo";
            this.pnlLienzo.Size = new System.Drawing.Size(674, 964);
            this.pnlLienzo.TabIndex = 1;
            this.pnlLienzo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLienzo_Paint);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(35, 589);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(173, 25);
            this.lblArea.TabIndex = 72;
            this.lblArea.Text = "Área y Perímetro";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(26, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 25);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Traslación";
            // 
            // lblTituloRotacion
            // 
            this.lblTituloRotacion.AutoSize = true;
            this.lblTituloRotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRotacion.Location = new System.Drawing.Point(30, 255);
            this.lblTituloRotacion.Name = "lblTituloRotacion";
            this.lblTituloRotacion.Size = new System.Drawing.Size(96, 25);
            this.lblTituloRotacion.TabIndex = 15;
            this.lblTituloRotacion.Text = "Rotación";
            // 
            // lblTituloEscalamiento
            // 
            this.lblTituloEscalamiento.AutoSize = true;
            this.lblTituloEscalamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEscalamiento.Location = new System.Drawing.Point(30, 413);
            this.lblTituloEscalamiento.Name = "lblTituloEscalamiento";
            this.lblTituloEscalamiento.Size = new System.Drawing.Size(141, 25);
            this.lblTituloEscalamiento.TabIndex = 16;
            this.lblTituloEscalamiento.Text = "Escalamiento";
            // 
            // lblNumeroLados
            // 
            this.lblNumeroLados.AutoSize = true;
            this.lblNumeroLados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroLados.Location = new System.Drawing.Point(175, 266);
            this.lblNumeroLados.Name = "lblNumeroLados";
            this.lblNumeroLados.Size = new System.Drawing.Size(207, 22);
            this.lblNumeroLados.TabIndex = 34;
            this.lblNumeroLados.Text = "Número de puntas (N)";
            // 
            // txtNumeroLados
            // 
            this.txtNumeroLados.Location = new System.Drawing.Point(205, 297);
            this.txtNumeroLados.Name = "txtNumeroLados";
            this.txtNumeroLados.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroLados.TabIndex = 35;
            this.txtNumeroLados.Text = "5";
            // 
            // FrmFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 964);
            this.Controls.Add(this.pnlLienzo);
            this.Controls.Add(this.pnlControles);
            this.Name = "FrmFiguras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Figuras y geometría";
            this.pnlControles.ResumeLayout(false);
            this.tabsHerramientas.ResumeLayout(false);
            this.tabFiguras.ResumeLayout(false);
            this.tabFiguras.PerformLayout();
            this.tabGeometria.ResumeLayout(false);
            this.tabGeometria.PerformLayout();
            this.tabTransformaciones.ResumeLayout(false);
            this.tabTransformaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.TabControl tabsHerramientas;
        private System.Windows.Forms.TabPage tabFiguras;
        private System.Windows.Forms.Button btnLimpiarF;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.TextBox txtRadioLado;
        private System.Windows.Forms.TextBox txtCentroY;
        private System.Windows.Forms.TextBox txtCentroX;
        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblCentroY;
        private System.Windows.Forms.Label lblCentroX;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.TabPage tabGeometria;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblPuntoDentro;
        private System.Windows.Forms.Label lblProyeccion;
        private System.Windows.Forms.TextBox txtPuntoPY;
        private System.Windows.Forms.TextBox txtPuntoPX;
        private System.Windows.Forms.Label lblPuntoPY;
        private System.Windows.Forms.Label lblPuntoPX;
        private System.Windows.Forms.TextBox txtBY;
        private System.Windows.Forms.TextBox txtBX;
        private System.Windows.Forms.TextBox txtAY;
        private System.Windows.Forms.TextBox txtAX;
        private System.Windows.Forms.Label lblPuntoP;
        private System.Windows.Forms.Label lblBY;
        private System.Windows.Forms.Label lblBX;
        private System.Windows.Forms.Label lblExtremoB;
        private System.Windows.Forms.Label lblAY;
        private System.Windows.Forms.Label lblAX;
        private System.Windows.Forms.Label lblExtremoA;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.TextBox txtPuntoY;
        private System.Windows.Forms.TextBox txtPuntoX;
        private System.Windows.Forms.Label lblPuntoY;
        private System.Windows.Forms.Label lblPuntoX;
        private System.Windows.Forms.Button btnProyeccion;
        private System.Windows.Forms.Button btnPuntoDentro;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.TabPage tabTransformaciones;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnEscalar;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.Button btnTrasladar;
        private System.Windows.Forms.TextBox txtEscalaY;
        private System.Windows.Forms.TextBox txtEscalaX;
        private System.Windows.Forms.TextBox txtRotacion;
        private System.Windows.Forms.TextBox txtTrasladarY;
        private System.Windows.Forms.TextBox txtTrasladarX;
        private System.Windows.Forms.Label lblEscalaY;
        private System.Windows.Forms.Label lblEscalaX;
        private System.Windows.Forms.Label lblRotacion;
        private System.Windows.Forms.Label lblTrasladarY;
        private System.Windows.Forms.Label lblTrasladarX;
        private System.Windows.Forms.Panel pnlLienzo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblTituloRotacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloEscalamiento;
        private System.Windows.Forms.TextBox txtNumeroLados;
        private System.Windows.Forms.Label lblNumeroLados;
    }
}