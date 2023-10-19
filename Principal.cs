using System.Net.NetworkInformation;

namespace PreguntasGV
{
    public partial class Principal : Form
    {
        private int njugadores { get; set; }
        private string dificultad { get; set; }
        private string modo { get; set; }
        private int totalPreguntas { get; set; }
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool VerificarConexionInternet()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("www.google.com");

                if (reply != null && reply.Status == IPStatus.Success)
                    {return true;}
                else
                {
                    MessageBox.Show("Error", "No hay conexión a Internet.\nVerifique su red y vuelva a intentarlo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Error", "Ha habido un error en la red.\nVerifique su red y vuelva a intentarlo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            if (VerificarConexionInternet())
            {
                RadioButton selectedRadioButton = pnlAjustes.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);

                switch (selectedRadioButton.Name)
                {
                    case "radFacil":
                        dificultad = "easy";
                        break;
                    case "radNormal":
                        dificultad = "medium";
                        break;
                    case "radDificil":
                        dificultad = "hard";
                        break;
                    default:
                        break;
                }
                njugadores = int.Parse(cmbJugadores.Text);
                modo = "normal";
                totalPreguntas = int.Parse(cmbNPreguntas.Text);

                this.Hide();
                Preguntas fPreguntas = new Preguntas(njugadores, dificultad, totalPreguntas,modo);
                fPreguntas.ShowDialog();
                this.Show();
            }
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            cmbJugadores.SelectedIndex = 0;
            cmbNPreguntas.SelectedIndex = 9;
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            pnlAjustes.Visible = !pnlAjustes.Visible;
        }

        private void btnContraReloj_Click(object sender, EventArgs e)
        {
            if (VerificarConexionInternet())
            {
                RadioButton selectedRadioButton = pnlAjustes.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);

                switch (selectedRadioButton.Name)
                {
                    case "radFacil":
                        dificultad = "easy";
                        break;
                    case "radNormal":
                        dificultad = "medium";
                        break;
                    case "radDificil":
                        dificultad = "hard";
                        break;
                    default:
                        break;
                }
                njugadores = 1;
                modo = "contrareloj";
                totalPreguntas = int.Parse(cmbNPreguntas.Text);

                this.Hide();
                Preguntas fPreguntas = new Preguntas(njugadores, dificultad, totalPreguntas,modo);
                fPreguntas.ShowDialog();
                this.Show();
            }
        }
    }
}
