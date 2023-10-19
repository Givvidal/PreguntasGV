namespace PreguntasGV
{
    partial class Principal
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
            btnNuevoJuego = new Button();
            label1 = new Label();
            btnSalir = new Button();
            cmbJugadores = new ComboBox();
            label2 = new Label();
            radFacil = new RadioButton();
            radNormal = new RadioButton();
            radDificil = new RadioButton();
            btnAjustes = new Button();
            pnlAjustes = new Panel();
            cmbNPreguntas = new ComboBox();
            label3 = new Label();
            btnContraReloj = new Button();
            panel1 = new Panel();
            pnlAjustes.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoJuego
            // 
            btnNuevoJuego.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoJuego.Location = new Point(18, 14);
            btnNuevoJuego.Name = "btnNuevoJuego";
            btnNuevoJuego.Size = new Size(262, 74);
            btnNuevoJuego.TabIndex = 0;
            btnNuevoJuego.Text = "Nuevo Juego";
            btnNuevoJuego.UseVisualStyleBackColor = true;
            btnNuevoJuego.Click += btnNuevoJuego_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(136, 133, 254);
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 0);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(363, 60);
            label1.TabIndex = 1;
            label1.Text = "PreguntasGV";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(30, 318);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(262, 54);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cmbJugadores
            // 
            cmbJugadores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJugadores.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cmbJugadores.FormattingEnabled = true;
            cmbJugadores.Items.AddRange(new object[] { "2", "4", "6", "8" });
            cmbJugadores.Location = new Point(306, 49);
            cmbJugadores.Name = "cmbJugadores";
            cmbJugadores.Size = new Size(87, 33);
            cmbJugadores.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(304, 22);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 4;
            label2.Text = "Jugadores";
            // 
            // radFacil
            // 
            radFacil.AutoSize = true;
            radFacil.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radFacil.Location = new Point(22, 82);
            radFacil.Name = "radFacil";
            radFacil.Size = new Size(71, 28);
            radFacil.TabIndex = 5;
            radFacil.Text = "Facil";
            radFacil.UseVisualStyleBackColor = true;
            // 
            // radNormal
            // 
            radNormal.AutoSize = true;
            radNormal.Checked = true;
            radNormal.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radNormal.Location = new Point(22, 116);
            radNormal.Name = "radNormal";
            radNormal.Size = new Size(93, 28);
            radNormal.TabIndex = 6;
            radNormal.TabStop = true;
            radNormal.Text = "Normal";
            radNormal.UseVisualStyleBackColor = true;
            // 
            // radDificil
            // 
            radDificil.AutoSize = true;
            radDificil.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radDificil.Location = new Point(22, 150);
            radDificil.Name = "radDificil";
            radDificil.Size = new Size(81, 28);
            radDificil.TabIndex = 7;
            radDificil.Text = "Dificil";
            radDificil.UseVisualStyleBackColor = true;
            // 
            // btnAjustes
            // 
            btnAjustes.BackgroundImage = Properties.Resources.ajustes;
            btnAjustes.BackgroundImageLayout = ImageLayout.Zoom;
            btnAjustes.Location = new Point(399, 27);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Size = new Size(33, 31);
            btnAjustes.TabIndex = 9;
            btnAjustes.UseVisualStyleBackColor = true;
            btnAjustes.Click += btnAjustes_Click;
            // 
            // pnlAjustes
            // 
            pnlAjustes.BackColor = SystemColors.ControlDarkDark;
            pnlAjustes.BorderStyle = BorderStyle.FixedSingle;
            pnlAjustes.Controls.Add(cmbNPreguntas);
            pnlAjustes.Controls.Add(label3);
            pnlAjustes.Controls.Add(radDificil);
            pnlAjustes.Controls.Add(radFacil);
            pnlAjustes.Controls.Add(radNormal);
            pnlAjustes.Location = new Point(309, 201);
            pnlAjustes.Name = "pnlAjustes";
            pnlAjustes.Size = new Size(137, 183);
            pnlAjustes.TabIndex = 10;
            pnlAjustes.Visible = false;
            // 
            // cmbNPreguntas
            // 
            cmbNPreguntas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNPreguntas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cmbNPreguntas.FormattingEnabled = true;
            cmbNPreguntas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbNPreguntas.Location = new Point(21, 35);
            cmbNPreguntas.Name = "cmbNPreguntas";
            cmbNPreguntas.Size = new Size(87, 29);
            cmbNPreguntas.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(17, 7);
            label3.Name = "label3";
            label3.Size = new Size(99, 24);
            label3.TabIndex = 8;
            label3.Text = "Preguntas";
            // 
            // btnContraReloj
            // 
            btnContraReloj.Font = new Font("Snap ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnContraReloj.Location = new Point(30, 209);
            btnContraReloj.Name = "btnContraReloj";
            btnContraReloj.Size = new Size(262, 72);
            btnContraReloj.TabIndex = 11;
            btnContraReloj.Text = "ContraReloj";
            btnContraReloj.UseVisualStyleBackColor = true;
            btnContraReloj.Click += btnContraReloj_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 62, 77);
            panel1.Controls.Add(btnNuevoJuego);
            panel1.Controls.Add(cmbJugadores);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 107);
            panel1.TabIndex = 12;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(473, 408);
            Controls.Add(panel1);
            Controls.Add(btnContraReloj);
            Controls.Add(pnlAjustes);
            Controls.Add(btnAjustes);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Principal";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            pnlAjustes.ResumeLayout(false);
            pnlAjustes.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevoJuego;
        private Label label1;
        private Button btnSalir;
        private ComboBox cmbJugadores;
        private Label label2;
        private RadioButton radFacil;
        private RadioButton radNormal;
        private RadioButton radDificil;
        private Button btnAjustes;
        private Panel pnlAjustes;
        private Button btnContraReloj;
        private Panel panel1;
        private Label label3;
        private ComboBox cmbNPreguntas;
    }
}