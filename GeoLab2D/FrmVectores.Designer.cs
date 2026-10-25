namespace GeoLab2D
{
    partial class FrmVectores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLienzo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLimpiar3 = new System.Windows.Forms.Button();
            this.btnDibujarVectores = new System.Windows.Forms.Button();
            this.txtV2Y = new System.Windows.Forms.TextBox();
            this.txtV2X = new System.Windows.Forms.TextBox();
            this.txtV1Y = new System.Windows.Forms.TextBox();
            this.txtV1X = new System.Windows.Forms.TextBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnDeterminante = new System.Windows.Forms.Button();
            this.btnProductoPunto = new System.Windows.Forms.Button();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.btnMagnitud = new System.Windows.Forms.Button();
            this.lblV2Y = new System.Windows.Forms.Label();
            this.lblV2X = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.lblV1Y = new System.Windows.Forms.Label();
            this.lblV1X = new System.Windows.Forms.Label();
            this.lblV1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiar3);
            this.panel1.Controls.Add(this.btnDibujarVectores);
            this.panel1.Controls.Add(this.txtV2Y);
            this.panel1.Controls.Add(this.txtV2X);
            this.panel1.Controls.Add(this.txtV1Y);
            this.panel1.Controls.Add(this.txtV1X);
            this.panel1.Controls.Add(this.lblResultados);
            this.panel1.Controls.Add(this.btnDeterminante);
            this.panel1.Controls.Add(this.btnProductoPunto);
            this.panel1.Controls.Add(this.btnDireccion);
            this.panel1.Controls.Add(this.btnMagnitud);
            this.panel1.Controls.Add(this.lblV2Y);
            this.panel1.Controls.Add(this.lblV2X);
            this.panel1.Controls.Add(this.lblV2);
            this.panel1.Controls.Add(this.lblV1Y);
            this.panel1.Controls.Add(this.lblV1X);
            this.panel1.Controls.Add(this.lblV1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 696);
            this.panel1.TabIndex = 0;
            // 
            // pnlLienzo
            // 
            this.pnlLienzo.BackColor = System.Drawing.Color.White;
            this.pnlLienzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLienzo.Location = new System.Drawing.Point(338, 0);
            this.pnlLienzo.Name = "pnlLienzo";
            this.pnlLienzo.Size = new System.Drawing.Size(540, 696);
            this.pnlLienzo.TabIndex = 1;
            this.pnlLienzo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLienzo_Paint);
            // 
            // btnLimpiar3
            // 
            this.btnLimpiar3.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnLimpiar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar3.Location = new System.Drawing.Point(65, 586);
            this.btnLimpiar3.Name = "btnLimpiar3";
            this.btnLimpiar3.Size = new System.Drawing.Size(185, 57);
            this.btnLimpiar3.TabIndex = 33;
            this.btnLimpiar3.Text = "Limpiar";
            this.btnLimpiar3.UseVisualStyleBackColor = false;
            this.btnLimpiar3.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDibujarVectores
            // 
            this.btnDibujarVectores.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnDibujarVectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujarVectores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDibujarVectores.Location = new System.Drawing.Point(65, 246);
            this.btnDibujarVectores.Name = "btnDibujarVectores";
            this.btnDibujarVectores.Size = new System.Drawing.Size(200, 49);
            this.btnDibujarVectores.TabIndex = 32;
            this.btnDibujarVectores.Text = "Dibujar vectores";
            this.btnDibujarVectores.UseVisualStyleBackColor = false;
            this.btnDibujarVectores.Click += new System.EventHandler(this.btnDibujarVectores_Click);
            // 
            // txtV2Y
            // 
            this.txtV2Y.Location = new System.Drawing.Point(191, 205);
            this.txtV2Y.Name = "txtV2Y";
            this.txtV2Y.Size = new System.Drawing.Size(100, 26);
            this.txtV2Y.TabIndex = 31;
            // 
            // txtV2X
            // 
            this.txtV2X.Location = new System.Drawing.Point(44, 205);
            this.txtV2X.Name = "txtV2X";
            this.txtV2X.Size = new System.Drawing.Size(100, 26);
            this.txtV2X.TabIndex = 30;
            // 
            // txtV1Y
            // 
            this.txtV1Y.Location = new System.Drawing.Point(195, 84);
            this.txtV1Y.Name = "txtV1Y";
            this.txtV1Y.Size = new System.Drawing.Size(100, 26);
            this.txtV1Y.TabIndex = 29;
            // 
            // txtV1X
            // 
            this.txtV1X.Location = new System.Drawing.Point(44, 84);
            this.txtV1X.Name = "txtV1X";
            this.txtV1X.Size = new System.Drawing.Size(100, 26);
            this.txtV1X.TabIndex = 28;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(36, 504);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(120, 25);
            this.lblResultados.TabIndex = 27;
            this.lblResultados.Text = "Resultados: ";
            // 
            // btnDeterminante
            // 
            this.btnDeterminante.BackColor = System.Drawing.Color.Pink;
            this.btnDeterminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeterminante.Location = new System.Drawing.Point(179, 420);
            this.btnDeterminante.Name = "btnDeterminante";
            this.btnDeterminante.Size = new System.Drawing.Size(140, 59);
            this.btnDeterminante.TabIndex = 26;
            this.btnDeterminante.Text = "Determinante";
            this.btnDeterminante.UseVisualStyleBackColor = false;
            this.btnDeterminante.Click += new System.EventHandler(this.btnDeterminante_Click);
            // 
            // btnProductoPunto
            // 
            this.btnProductoPunto.BackColor = System.Drawing.Color.HotPink;
            this.btnProductoPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoPunto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductoPunto.Location = new System.Drawing.Point(32, 420);
            this.btnProductoPunto.Name = "btnProductoPunto";
            this.btnProductoPunto.Size = new System.Drawing.Size(137, 59);
            this.btnProductoPunto.TabIndex = 25;
            this.btnProductoPunto.Text = "Producto punto";
            this.btnProductoPunto.UseVisualStyleBackColor = false;
            this.btnProductoPunto.Click += new System.EventHandler(this.btnProductoPunto_Click);
            // 
            // btnDireccion
            // 
            this.btnDireccion.BackColor = System.Drawing.Color.Thistle;
            this.btnDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDireccion.Location = new System.Drawing.Point(179, 336);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(140, 63);
            this.btnDireccion.TabIndex = 24;
            this.btnDireccion.Text = "Calcular dirección";
            this.btnDireccion.UseVisualStyleBackColor = false;
            this.btnDireccion.Click += new System.EventHandler(this.btnDireccion_Click);
            // 
            // btnMagnitud
            // 
            this.btnMagnitud.BackColor = System.Drawing.Color.Violet;
            this.btnMagnitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagnitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMagnitud.Location = new System.Drawing.Point(32, 336);
            this.btnMagnitud.Name = "btnMagnitud";
            this.btnMagnitud.Size = new System.Drawing.Size(137, 63);
            this.btnMagnitud.TabIndex = 23;
            this.btnMagnitud.Text = "Calcular magnitud";
            this.btnMagnitud.UseVisualStyleBackColor = false;
            this.btnMagnitud.Click += new System.EventHandler(this.btnMagnitud_Click);
            // 
            // lblV2Y
            // 
            this.lblV2Y.AutoSize = true;
            this.lblV2Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV2Y.Location = new System.Drawing.Point(187, 165);
            this.lblV2Y.Name = "lblV2Y";
            this.lblV2Y.Size = new System.Drawing.Size(124, 20);
            this.lblV2Y.TabIndex = 22;
            this.lblV2Y.Text = "Coordenada Y";
            // 
            // lblV2X
            // 
            this.lblV2X.AutoSize = true;
            this.lblV2X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV2X.Location = new System.Drawing.Point(44, 164);
            this.lblV2X.Name = "lblV2X";
            this.lblV2X.Size = new System.Drawing.Size(124, 20);
            this.lblV2X.TabIndex = 21;
            this.lblV2X.Text = "Coordenada X";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV2.Location = new System.Drawing.Point(36, 129);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(77, 20);
            this.lblV2.TabIndex = 20;
            this.lblV2.Text = "Vector 2";
            // 
            // lblV1Y
            // 
            this.lblV1Y.AutoSize = true;
            this.lblV1Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV1Y.Location = new System.Drawing.Point(187, 52);
            this.lblV1Y.Name = "lblV1Y";
            this.lblV1Y.Size = new System.Drawing.Size(124, 20);
            this.lblV1Y.TabIndex = 19;
            this.lblV1Y.Text = "Coordenada Y";
            // 
            // lblV1X
            // 
            this.lblV1X.AutoSize = true;
            this.lblV1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV1X.Location = new System.Drawing.Point(40, 51);
            this.lblV1X.Name = "lblV1X";
            this.lblV1X.Size = new System.Drawing.Size(124, 20);
            this.lblV1X.TabIndex = 18;
            this.lblV1X.Text = "Coordenada X";
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV1.Location = new System.Drawing.Point(36, 19);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(77, 20);
            this.lblV1.TabIndex = 17;
            this.lblV1.Text = "Vector 1";
            // 
            // FrmVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 696);
            this.Controls.Add(this.pnlLienzo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Operaciones con vectores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlLienzo;
        private System.Windows.Forms.Button btnLimpiar3;
        private System.Windows.Forms.Button btnDibujarVectores;
        private System.Windows.Forms.TextBox txtV2Y;
        private System.Windows.Forms.TextBox txtV2X;
        private System.Windows.Forms.TextBox txtV1Y;
        private System.Windows.Forms.TextBox txtV1X;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnDeterminante;
        private System.Windows.Forms.Button btnProductoPunto;
        private System.Windows.Forms.Button btnDireccion;
        private System.Windows.Forms.Button btnMagnitud;
        private System.Windows.Forms.Label lblV2Y;
        private System.Windows.Forms.Label lblV2X;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label lblV1Y;
        private System.Windows.Forms.Label lblV1X;
        private System.Windows.Forms.Label lblV1;
    }
}