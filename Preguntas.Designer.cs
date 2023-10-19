namespace PreguntasGV
{
    partial class Preguntas
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
            components = new System.ComponentModel.Container();
            lblPregunta = new Label();
            btnRespuesta1 = new Button();
            btnRespuesta2 = new Button();
            btnRespuesta3 = new Button();
            btnRespuesta4 = new Button();
            lblJugador = new Label();
            lblRespuesta = new Label();
            btnSiguiente = new Button();
            lblPuntos = new Label();
            lblNPregunta = new Label();
            label2 = new Label();
            btnEditNom = new Button();
            toolTip1 = new ToolTip(components);
            txtNombre = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimpoText = new Label();
            lblTiempo = new Label();
            toolTip2 = new ToolTip(components);
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPregunta.BackColor = SystemColors.AppWorkspace;
            lblPregunta.Font = new Font("Swis721 Blk BT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPregunta.Location = new Point(22, 82);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(1220, 168);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "¿Aqui va una Pregunta?";
            lblPregunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRespuesta1
            // 
            btnRespuesta1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRespuesta1.BackColor = Color.CadetBlue;
            btnRespuesta1.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRespuesta1.Location = new Point(113, 353);
            btnRespuesta1.Name = "btnRespuesta1";
            btnRespuesta1.Size = new Size(453, 105);
            btnRespuesta1.TabIndex = 1;
            btnRespuesta1.Text = "Pregunta 1";
            btnRespuesta1.UseVisualStyleBackColor = false;
            btnRespuesta1.Click += btnRespuesta1_Click;
            // 
            // btnRespuesta2
            // 
            btnRespuesta2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRespuesta2.BackColor = Color.CadetBlue;
            btnRespuesta2.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRespuesta2.Location = new Point(647, 353);
            btnRespuesta2.Name = "btnRespuesta2";
            btnRespuesta2.Size = new Size(453, 105);
            btnRespuesta2.TabIndex = 2;
            btnRespuesta2.Text = "Pregunta 2";
            btnRespuesta2.UseVisualStyleBackColor = false;
            btnRespuesta2.Click += btnRespuesta2_Click;
            // 
            // btnRespuesta3
            // 
            btnRespuesta3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRespuesta3.BackColor = Color.CadetBlue;
            btnRespuesta3.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRespuesta3.Location = new Point(113, 520);
            btnRespuesta3.Name = "btnRespuesta3";
            btnRespuesta3.Size = new Size(453, 105);
            btnRespuesta3.TabIndex = 3;
            btnRespuesta3.Text = "Pregunta 3";
            btnRespuesta3.UseVisualStyleBackColor = false;
            btnRespuesta3.Click += btnRespuesta3_Click;
            // 
            // btnRespuesta4
            // 
            btnRespuesta4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRespuesta4.BackColor = Color.CadetBlue;
            btnRespuesta4.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRespuesta4.Location = new Point(647, 520);
            btnRespuesta4.Name = "btnRespuesta4";
            btnRespuesta4.Size = new Size(453, 105);
            btnRespuesta4.TabIndex = 4;
            btnRespuesta4.Text = "Pregunta 4";
            btnRespuesta4.UseVisualStyleBackColor = false;
            btnRespuesta4.Click += btnRespuesta4_Click;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblJugador.Location = new Point(573, 20);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(146, 29);
            lblJugador.TabIndex = 5;
            lblJugador.Text = "Jugador X";
            lblJugador.TextAlign = ContentAlignment.TopRight;
            // 
            // lblRespuesta
            // 
            lblRespuesta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRespuesta.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRespuesta.Location = new Point(414, 286);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(382, 48);
            lblRespuesta.TabIndex = 6;
            lblRespuesta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.BackColor = Color.SkyBlue;
            btnSiguiente.BackgroundImage = Properties.Resources.proximo;
            btnSiguiente.BackgroundImageLayout = ImageLayout.Zoom;
            btnSiguiente.FlatStyle = FlatStyle.Popup;
            btnSiguiente.Location = new Point(1121, 257);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(121, 60);
            btnSiguiente.TabIndex = 7;
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Visible = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblPuntos
            // 
            lblPuntos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Swis721 Blk BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuntos.ForeColor = Color.DarkGray;
            lblPuntos.Location = new Point(723, 17);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(32, 32);
            lblPuntos.TabIndex = 8;
            lblPuntos.Text = "0";
            // 
            // lblNPregunta
            // 
            lblNPregunta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNPregunta.AutoSize = true;
            lblNPregunta.Font = new Font("Swis721 Blk BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNPregunta.ForeColor = Color.DarkGray;
            lblNPregunta.Location = new Point(196, 20);
            lblNPregunta.Name = "lblNPregunta";
            lblNPregunta.Size = new Size(32, 32);
            lblNPregunta.TabIndex = 10;
            lblNPregunta.Text = "0";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 22);
            label2.Name = "label2";
            label2.Size = new Size(141, 29);
            label2.TabIndex = 9;
            label2.Text = "Pregunta:";
            // 
            // btnEditNom
            // 
            btnEditNom.BackgroundImage = Properties.Resources.editar;
            btnEditNom.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditNom.Location = new Point(469, 17);
            btnEditNom.Name = "btnEditNom";
            btnEditNom.Size = new Size(38, 34);
            btnEditNom.TabIndex = 11;
            btnEditNom.UseVisualStyleBackColor = true;
            btnEditNom.Click += btnEditNom_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Swis721 Blk BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(520, 16);
            txtNombre.MaxLength = 13;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 33);
            txtNombre.TabIndex = 12;
            txtNombre.Visible = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblTimpoText
            // 
            lblTimpoText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTimpoText.AutoSize = true;
            lblTimpoText.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimpoText.Location = new Point(912, 20);
            lblTimpoText.Name = "lblTimpoText";
            lblTimpoText.Size = new Size(118, 29);
            lblTimpoText.TabIndex = 13;
            lblTimpoText.Text = "Tiempo:";
            lblTimpoText.Visible = false;
            // 
            // lblTiempo
            // 
            lblTiempo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Swis721 Blk BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTiempo.ForeColor = Color.DarkGray;
            lblTiempo.Location = new Point(1036, 20);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(78, 32);
            lblTiempo.TabIndex = 14;
            lblTiempo.Text = "0:00";
            lblTiempo.Visible = false;
            // 
            // Preguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1254, 687);
            Controls.Add(lblTiempo);
            Controls.Add(lblTimpoText);
            Controls.Add(txtNombre);
            Controls.Add(btnEditNom);
            Controls.Add(lblNPregunta);
            Controls.Add(label2);
            Controls.Add(lblPuntos);
            Controls.Add(btnSiguiente);
            Controls.Add(lblRespuesta);
            Controls.Add(lblJugador);
            Controls.Add(btnRespuesta4);
            Controls.Add(btnRespuesta3);
            Controls.Add(btnRespuesta2);
            Controls.Add(btnRespuesta1);
            Controls.Add(lblPregunta);
            MaximumSize = new Size(1270, 750);
            MinimumSize = new Size(1270, 726);
            Name = "Preguntas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preguntas";
            FormClosed += Preguntas_FormClosed;
            Load += Preguntas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPregunta;
        private Button btnRespuesta1;
        private Button btnRespuesta2;
        private Button btnRespuesta3;
        private Button btnRespuesta4;
        private Label lblJugador;
        private Label lblRespuesta;
        private Button btnSiguiente;
        private Label lblPuntos;
        private Label lblNPregunta;
        private Label label2;
        private Button btnEditNom;
        private ToolTip toolTip1;
        private TextBox txtNombre;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimpoText;
        private Label lblTiempo;
        private ToolTip toolTip2;
    }
}