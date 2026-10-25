namespace GeoLab2D
{
    partial class FrmGeoLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeoLab));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblParrafo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblLista1 = new System.Windows.Forms.Label();
            this.btnFigura = new System.Windows.Forms.Button();
            this.btnVectores = new System.Windows.Forms.Button();
            this.lblLista2 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblFrase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlInicio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurasToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1821, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.figurasToolStripMenuItem.Text = "Figuras";
            this.figurasToolStripMenuItem.Click += new System.EventHandler(this.figurasToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.archivoToolStripMenuItem.Text = "Vectores";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // pnlInicio
            // 
            this.pnlInicio.AutoScroll = true;
            this.pnlInicio.BackColor = System.Drawing.Color.LightCyan;
            this.pnlInicio.Controls.Add(this.label1);
            this.pnlInicio.Controls.Add(this.lblFrase);
            this.pnlInicio.Controls.Add(this.panel2);
            this.pnlInicio.Controls.Add(this.panel1);
            this.pnlInicio.Controls.Add(this.lblParrafo);
            this.pnlInicio.Controls.Add(this.lblDescripcion);
            this.pnlInicio.Controls.Add(this.lblSubtitulo);
            this.pnlInicio.Controls.Add(this.lblTitulo);
            this.pnlInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInicio.Location = new System.Drawing.Point(0, 36);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(1821, 1014);
            this.pnlInicio.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(745, 84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(389, 85);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GeoLab2D";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(775, 192);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(307, 32);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Geometría y Vectores";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(589, 256);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(673, 29);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Explora, calcula y transforma el mundo de la geometría en 2D.";
            // 
            // lblParrafo
            // 
            this.lblParrafo.AutoSize = true;
            this.lblParrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParrafo.Location = new System.Drawing.Point(415, 312);
            this.lblParrafo.Name = "lblParrafo";
            this.lblParrafo.Size = new System.Drawing.Size(1015, 50);
            this.lblParrafo.TabIndex = 3;
            this.lblParrafo.Text = resources.GetString("lblParrafo.Text");
            this.lblParrafo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnFigura);
            this.panel1.Controls.Add(this.lblLista1);
            this.panel1.Controls.Add(this.lblTitulo1);
            this.panel1.Location = new System.Drawing.Point(464, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 317);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnVectores);
            this.panel2.Controls.Add(this.lblLista2);
            this.panel2.Controls.Add(this.lblTitulo2);
            this.panel2.Location = new System.Drawing.Point(964, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 317);
            this.panel2.TabIndex = 5;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(24, 30);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(191, 22);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "Figuras y Geometría";
            // 
            // lblLista1
            // 
            this.lblLista1.AutoSize = true;
            this.lblLista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista1.Location = new System.Drawing.Point(24, 78);
            this.lblLista1.Name = "lblLista1";
            this.lblLista1.Size = new System.Drawing.Size(403, 140);
            this.lblLista1.TabIndex = 1;
            this.lblLista1.Text = "Dibujo de figuras geométricas.\n\nCálculo de área y perímetro.\n\nComprobación de pun" +
    "tos dentro o fuera de un polígono.\n\nProyección de puntos sobre segmentos.";
            // 
            // btnFigura
            // 
            this.btnFigura.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFigura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFigura.Location = new System.Drawing.Point(124, 239);
            this.btnFigura.Name = "btnFigura";
            this.btnFigura.Size = new System.Drawing.Size(200, 60);
            this.btnFigura.TabIndex = 2;
            this.btnFigura.Text = "Abrir Figuras";
            this.btnFigura.UseVisualStyleBackColor = false;
            this.btnFigura.Click += new System.EventHandler(this.btnFigura_Click);
            // 
            // btnVectores
            // 
            this.btnVectores.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVectores.ForeColor = System.Drawing.Color.Snow;
            this.btnVectores.Location = new System.Drawing.Point(141, 239);
            this.btnVectores.Name = "btnVectores";
            this.btnVectores.Size = new System.Drawing.Size(203, 60);
            this.btnVectores.TabIndex = 5;
            this.btnVectores.Text = "Abrir Vectores";
            this.btnVectores.UseVisualStyleBackColor = false;
            this.btnVectores.Click += new System.EventHandler(this.btnVectores_Click);
            // 
            // lblLista2
            // 
            this.lblLista2.AutoSize = true;
            this.lblLista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista2.Location = new System.Drawing.Point(34, 78);
            this.lblLista2.Name = "lblLista2";
            this.lblLista2.Size = new System.Drawing.Size(264, 100);
            this.lblLista2.TabIndex = 4;
            this.lblLista2.Text = "Representación gráfica de vectores.\n\nCálculo de magnitud y dirección.\n\nProducto p" +
    "unto y determinante.";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(25, 30);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(89, 22);
            this.lblTitulo2.TabIndex = 3;
            this.lblTitulo2.Text = "Vectores";
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(470, 779);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(981, 32);
            this.lblFrase.TabIndex = 6;
            this.lblFrase.Text = "Aprende, experimenta y visualiza las matemáticas en dos dimensiones.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 854);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grupo 8 - Chiriboga Kerlly, Silva Erick, Delgado Juan";
            // 
            // FrmGeoLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1821, 1050);
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FrmGeoLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeoLab 2D - Diseñador y analizador geométrico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlInicio.ResumeLayout(false);
            this.pnlInicio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFigura;
        private System.Windows.Forms.Label lblLista1;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblParrafo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Button btnVectores;
        private System.Windows.Forms.Label lblLista2;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label label1;
    }
}