using Newtonsoft.Json;
using System.Web;
using static PreguntasGV.DecoJSON;

namespace PreguntasGV
{
    public partial class Preguntas : Form
    {
        private int jugadorActual = 0;
        private int preguntaActual = 1;
        private int _totalPreguntas;
        private int preguntasRespondidasPorJugador = 0;
        private int njugadores { get; set; }
        private string dificultad { get; set; }
        private string modo { get; set; }
        private RootObject _result;
        private List<JugadorDTO> jugadores = new List<JugadorDTO>();
        string tipo = "multiple";
        private TimeSpan tiempoRestante;

        public Preguntas(int njugadores, string dificultad, int totalPreguntas, string modo)
        {
            InitializeComponent();
            this.dificultad = dificultad;
            this.modo = modo;
            this._totalPreguntas = totalPreguntas;
            btnSiguiente.Visible = false;
            lblNPregunta.Text = preguntaActual.ToString();
            toolTip1.SetToolTip(btnEditNom, "Cambiar nombre");
            toolTip2.SetToolTip(btnSiguiente, "Siguiente");

            //Jugadores
            for (int i = 0; i < njugadores; i++)
            {
                JugadorDTO jugador = new JugadorDTO
                {
                    Id = i + 1,
                    Nombre = $"Jugador {i + 1}",
                    Puntos = 0
                };

                this.jugadores.Add(jugador);
            }
            MostrarJugador();
            CargarNuevaPregunta();
        }

        private void btnRespuesta1_Click(object sender, EventArgs e)
        {
            string respuestaSeleccionada = btnRespuesta1.Text;
            string respuestaCorrecta = _result.results[0].correct_answer; 

            if (respuestaSeleccionada == respuestaCorrecta)
            {
                btnRespuesta1.BackColor = Color.Green;
                btnRespuesta1.ForeColor = Color.White;
                lblRespuesta.Text = "¡CORRECTO!";
                lblRespuesta.ForeColor = Color.White;
                lblRespuesta.BackColor = Color.Green;
                RespuestaCorrecta();
            }
            else
            {
                btnRespuesta1.BackColor = Color.Red;
                btnRespuesta1.ForeColor = Color.White;
                lblRespuesta.Text = "¡INCORRECTO!";
                lblRespuesta.ForeColor = Color.White;
                lblRespuesta.BackColor = Color.Red;

                if (btnRespuesta2.Text == respuestaCorrecta)
                {
                    btnRespuesta2.BackColor = Color.Green;
                    btnRespuesta2.ForeColor = Color.White;
                }
                else if (btnRespuesta3.Text == respuestaCorrecta)
                {
                    btnRespuesta3.BackColor = Color.Green;
                    btnRespuesta3.ForeColor = Color.White;
                }
                else if (btnRespuesta4.Text == respuestaCorrecta)
                {
                    btnRespuesta4.BackColor = Color.Green;
                    btnRespuesta4.ForeColor = Color.White;
                }
            }
            btnRespuesta1.Enabled = false;
            btnRespuesta2.Enabled = false;
            btnRespuesta3.Enabled = false;
            btnRespuesta4.Enabled = false;
            btnSiguiente.Visible = true;
        }
        private void btnRespuesta2_Click(object sender, EventArgs e)
        {
            string respuestaSeleccionada = btnRespuesta2.Text;
            string respuestaCorrecta = _result.results[0].correct_answer;

            if (respuestaSeleccionada == respuestaCorrecta)
            {
                btnRespuesta2.BackColor = Color.Green;
                btnRespuesta2.ForeColor = Color.White;
                lblRespuesta.Text = "¡CORRECTO!";
                lblRespuesta.ForeColor = Color.White;
                lblRespuesta.BackColor = Color.Green;
                RespuestaCorrecta();
            }
            else
            {
                btnRespuesta2.BackColor = Color.Red;
                btnRespuesta2.ForeColor = Color.White;
                lblRespuesta.Text = "¡INCORRECTO!";
                lblRespuesta.ForeColor = Color.White;
                lblRespuesta.BackColor = Color.Red;

                if (btnRespuesta1.Text == respuestaCorrecta)
                {
                    btnRespuesta1.BackColor = Color.Green;
                    btnRespuesta1.ForeColor = Color.White;
                }
                else if (btnRespuesta3.Text == respuestaCorrecta)
                {
                    btnRespuesta3.BackColor = Color.Green;
                    btnRespuesta3.ForeColor = Color.White;
                }
                else if (btnRespuesta4.Text == respuestaCorrecta)
                {
                    btnRespuesta4.BackColor = Color.Green;
                    btnRespuesta4.ForeColor = Color.White;
                }
            }
            btnRespuesta1.Enabled = false;
            btnRespuesta2.Enabled = false;
            btnRespuesta3.Enabled = false;
            btnRespuesta4.Enabled = false;
            btnSiguiente.Visible = true;
        }
        private void btnRespuesta3_Click(object sender, EventArgs e)
        {
            string respuestaSeleccionada = btnRespuesta3.Text;
            string respuestaCorrecta = _result.results[0].correct_answer;

            if (respuestaSeleccionada == respuestaCorrecta)
            {
                btnRespuesta3.BackColor = Color.Green;
                btnRespuesta3.ForeColor = Color.White;
                lblRespuesta.Text = "¡CORRECTO!";
                lblRespuesta.ForeColor = Color.White;
                lblRespuesta.BackColor = Color.Green;
                RespuestaCorrecta();
            }
            else
            {
                btnRespuesta3.BackColor = Color.Red;
                btnRespuesta3.ForeColor = Color.White;
                lblRespuesta.Text = "¡INCORRECTO!";
                lblRespuesta.ForeColor = Color.White;
                lblRespuesta.BackColor = Color.Red;

                if (btnRespuesta2.Text == respuestaCorrecta)
                {
                    btnRespuesta2.BackColor = Color.Green;
                    btnRespuesta2.ForeColor = Color.White;
                }
                else if (btnRespuesta1.Text == respuestaCorrecta)
                {
                    btnRespuesta1.BackColor = Color.Green;
                    btnRespuesta1.ForeColor = Color.White;
                }
                else if (btnRespuesta4.Text == respuestaCorrecta)
                {
                    btnRespuesta4.BackColor = Color.Green;
                    btnRespuesta4.ForeColor = Color.White;
                }
            }
            btnRespuesta1.Enabled = false;
            btnRespuesta2.Enabled = false;
            btnRespuesta3.Enabled = false;
            btnRespuesta4.Enabled = false;
            btnSiguiente.Visible = true;
        }
        private void btnRespuesta4_Click(object sender, EventArgs e)
        {
            string respuestaSeleccionada = btnRespuesta4.Text;
            string respuestaCorrecta = _result.results[0].correct_answer;

            if (respuestaSeleccionada == respuestaCorrecta)
            {
                btnRespuesta4.BackColor = Color.Green;
                btnRespuesta4.ForeColor = Color.White;
                lblRespuesta.Text = "¡CORRECTO!";
                lblRespuesta.ForeColor = Color.White;
                lblRespuesta.BackColor = Color.Green;
                RespuestaCorrecta();
            }
            else
            {
                btnRespuesta4.BackColor = Color.Red;
                btnRespuesta4.ForeColor = Color.White;
                lblRespuesta.Text = "¡INCORRECTO!";
                lblRespuesta.ForeColor = Color.White;
                lblRespuesta.BackColor = Color.Red;

                if (btnRespuesta2.Text == respuestaCorrecta)
                {
                    btnRespuesta2.BackColor = Color.Green;
                    btnRespuesta2.ForeColor = Color.White;
                }
                else if (btnRespuesta3.Text == respuestaCorrecta)
                {
                    btnRespuesta3.BackColor = Color.Green;
                    btnRespuesta3.ForeColor = Color.White;
                }
                else if (btnRespuesta1.Text == respuestaCorrecta)
                {
                    btnRespuesta1.BackColor = Color.Green;
                    btnRespuesta1.ForeColor = Color.White;
                }
            }
            btnRespuesta1.Enabled = false;
            btnRespuesta2.Enabled = false;
            btnRespuesta3.Enabled = false;
            btnRespuesta4.Enabled = false;
            btnSiguiente.Visible = true;
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ResetearColores();
            preguntasRespondidasPorJugador++;

            if (preguntasRespondidasPorJugador >= jugadores.Count)//todos los jugadores han respondido la pregunta
            {
                preguntaActual++;
                lblNPregunta.Text = preguntaActual.ToString();
                
                if (preguntaActual > _totalPreguntas && preguntasRespondidasPorJugador % 2 == 0) // se ha respondido todas preguntas
                {
                    int maxPuntos = jugadores.Max(j => j.Puntos);
                    var ganadores = jugadores.Where(j => j.Puntos == maxPuntos).ToList();

                    if (ganadores.Count == 1) // comprobar ganador o un empate
                    {
                        this.Hide();
                        MessageBox.Show("FELICIDADES!!!!!!", $"{ganadores[0].Nombre} gana con {maxPuntos} puntos.",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        preguntasRespondidasPorJugador = 0;
                        jugadorActual = 0;
                        lblRespuesta.Text = "Desempate.";
                        lblRespuesta.ForeColor = Color.Black;
                    }
                }
                else
                {
                    preguntasRespondidasPorJugador = 0;
                    jugadorActual++;
                    if (jugadorActual >= jugadores.Count)
                    {
                        jugadorActual = 0; 
                    }
                    MostrarJugador();
                    CargarNuevaPregunta();
                }
            }
            else
            {
                jugadorActual++;
                if (jugadorActual >= jugadores.Count)
                {
                    jugadorActual = 0; 
                }
                MostrarJugador();
                CargarNuevaPregunta();
            }
        }
        private void Preguntas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void MostrarJugador()
        {
            if (jugadorActual < jugadores.Count)
            {
                lblJugador.Text = jugadores[jugadorActual].Nombre;
                lblPuntos.Text = $"Puntos: {jugadores[jugadorActual].Puntos}";
            }
        }
        private async void CargarNuevaPregunta()
        {
            // Llamado de API pregunta y respuesta
            string apiUrl = $"https://opentdb.com/api.php?amount=1&difficulty={dificultad}&type={tipo}";

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = httpClient.GetAsync(apiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    //Deserializa el JSON en un objeto
                    string jsonResponse = response.Content.ReadAsStringAsync().Result;
                    RootObject result = JsonConvert.DeserializeObject<RootObject>(jsonResponse);
                    _result = result;

                    // PREGUNTA Y RESPUESTAS
                    string respuestaCorrecta = result.results[0].correct_answer;
                    List<string> respuestasIncorrectas = result.results[0].incorrect_answers;

                    List<string> todasLasRespuestas = new List<string>(respuestasIncorrectas);
                    todasLasRespuestas.Add(respuestaCorrecta);

                    Random random = new Random();
                    List<string> respuestasMezcladas = todasLasRespuestas.OrderBy(x => random.Next()).ToList();

                    lblPregunta.Text = HttpUtility.HtmlDecode(result.results[0].question);
                    btnRespuesta1.Text = HttpUtility.HtmlDecode(respuestasMezcladas[0]);
                    btnRespuesta2.Text = HttpUtility.HtmlDecode(respuestasMezcladas[1]);
                    btnRespuesta3.Text = HttpUtility.HtmlDecode(respuestasMezcladas[2]);
                    btnRespuesta4.Text = HttpUtility.HtmlDecode(respuestasMezcladas[3]);
                    await Task.Delay(500);
                    btnRespuesta1.Enabled = true;
                    btnRespuesta2.Enabled = true;
                    btnRespuesta3.Enabled = true;
                    btnRespuesta4.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al obtener preguntas de la API.");
                }
            }
        }

        private void ResetearColores()
        {
            btnRespuesta1.BackColor = Color.CadetBlue;
            btnRespuesta1.ForeColor = SystemColors.ControlText;
            btnRespuesta2.BackColor = Color.CadetBlue;
            btnRespuesta2.ForeColor = SystemColors.ControlText;
            btnRespuesta3.BackColor = Color.CadetBlue;
            btnRespuesta3.ForeColor = SystemColors.ControlText;
            btnRespuesta4.BackColor = Color.CadetBlue;
            btnRespuesta4.ForeColor = SystemColors.ControlText;

            lblRespuesta.Text = string.Empty;
            lblRespuesta.BackColor = Color.DarkSlateGray;
            btnSiguiente.Visible = false;
        }
        private void RespuestaCorrecta()
        {
            if (jugadorActual < jugadores.Count)
            {
                jugadores[jugadorActual].Puntos++;  // Aumentar los puntos del jugador actual
                lblPuntos.Text = $"{jugadores[jugadorActual].Puntos} puntos.";
            }
        }
        private void btnEditNom_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = true;
            txtNombre.PlaceholderText = lblJugador.Text;
            btnEditNom.Enabled = false;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                jugadores[jugadorActual].Nombre = txtNombre.Text;
                btnEditNom.Enabled = true;
                lblJugador.Text = jugadores[jugadorActual].Nombre;
                txtNombre.Visible = false;
            }
        }
        private void ActualizarTiempoRestante()
        {
            lblTiempo.Text = tiempoRestante.ToString(@"mm\:ss");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoRestante = tiempoRestante.Subtract(TimeSpan.FromSeconds(0.5));
            ActualizarTiempoRestante();

            if (tiempoRestante.TotalSeconds <= 0)
            {
                timer1.Stop();
                this.Hide();
                MessageBox.Show($"Has acertado {jugadores[jugadorActual].Puntos} preguntas.", "Tiempo Agotado!!!!!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Preguntas_Load(object sender, EventArgs e)
        {
            if (modo == "normal")
            {
                timer1.Enabled = false;
            }
            else if (modo == "contrareloj")
            {
                lblJugador.Visible = false;
                txtNombre.Visible = false;
                btnEditNom.Visible = false;
                lblTiempo.Visible = true;
                lblTimpoText.Visible = true;

                timer1.Interval = 1000;
                timer1.Tick += timer1_Tick;
                tiempoRestante = TimeSpan.FromMinutes(2); // Duración 2 minutos
                ActualizarTiempoRestante();
                timer1.Start();
            }
        }
    }
}