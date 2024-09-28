using System.IO.Ports;
using System.Runtime.Serialization;
//namespace PuertoSerie

namespace PuertoSerie
{
    public partial class frmSerie : Form
    {
        SerialPort spConexion = new SerialPort(); // Puerto para conexión Bluetooth
        SerialPort spEnvio = new SerialPort();    // Puerto para enviar datos
        SerialPort spRecepcion = new SerialPort(); // Puerto para recibir datos
        String escala = "C";
        public frmSerie()
        {
            InitializeComponent();
        }

        private void frmSerie_Load(object sender, EventArgs e)
        {
            string[] puertos1 = SerialPort.GetPortNames();
            string[] puertos2 = SerialPort.GetPortNames();
            string[] puertos3 = SerialPort.GetPortNames();

            cmbEntrada.DataSource = puertos2;
            cmbSalida.DataSource = puertos3;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                spRecepcion.PortName = cmbEntrada.Text; // Seleccionar puerto de conexión
                spRecepcion.BaudRate = 9600; // Ajustar baud rate según tu módulo Bluetooth
                spRecepcion.Open(); // Abrir conexión
                MessageBox.Show("Conectado");

                spEnvio.PortName = cmbSalida.Text;
                spEnvio.BaudRate = 9600;
                spEnvio.Open();
                // Suscribirse a eventos de datos recibidos
                spRecepcion.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           /* try
            {
                if (spRecepcion.IsOpen)
                {
                    spRecepcion.WriteLine(txtEnviar.Text); // Enviar datos
                    txtEnviar.Clear(); // Limpiar el TextBox
                }
                else
                {
                    MessageBox.Show("Conexión no está abierta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort actualSP = (SerialPort)sender;
            string inData = actualSP.ReadLine().Trim();
            int temp = 0;
            int.TryParse(inData, out temp);
            termometro.Invoke(new MethodInvoker(delegate
            {
                if ( escala == "F" )
                {
                    termometro.Maximum = 200;
                } else
                {
                    termometro.Maximum = 100;
                }
                termometro.Value = temp;
            }));
            rtbLog.Invoke(new MethodInvoker(delegate
            {
                rtbLog.AppendText(inData + "\n"); // Mostrar datos en el RichTextBox
            }));
            lblTemp.Invoke(new MethodInvoker(delegate
            {
                lblTemp.Text = inData + "°" + escala;
            }));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string[] puertos1 = SerialPort.GetPortNames();
            string[] puertos2 = SerialPort.GetPortNames();
            string[] puertos3 = SerialPort.GetPortNames();

            cmbEntrada.DataSource = puertos2;
            cmbSalida.DataSource = puertos3;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTemp_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            /* try
             {
                 if (spRecepcion.IsOpen)
                 {
                     spRecepcion.WriteLine("f"); // Enviar datos
                 }
                 else
                 {
                     MessageBox.Show("Conexión no está abierta.");
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             } */
        }

        private void rbFarenheit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEscala_Click(object sender, EventArgs e)
        {
           try
             {
                 if (spRecepcion.IsOpen)
                 {
                    if ( escala == "F")
                    {
                        escala = "C";
                    }
                    else
                    {
                        escala = "F";
                    }
                    spRecepcion.WriteLine("f"); // Enviar datos
                }
                else
                 {
                     MessageBox.Show("Conexión no está abierta.");
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
        }
    }
}