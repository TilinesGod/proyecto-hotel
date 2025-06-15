using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace WinFormsApp6
{
    [Serializable]
    public struct Habitaciones
    {
        public int numero;
        public string tipo;
        public int capacidad;
        public string[] caracteristicas;
        public int tarifa_base;
    }
    [Serializable]
    public struct Cliente
    {
        public string id;
        public string nombre;
        public string documento_identidad;
        public string direccion;
        public string telefono;
        public string email;
        public string preferencias;
    }
    [Serializable]
    public struct Reserva
    {
        public int id;
        public int id_habitacion;
        public string fecha_entrada;
        public string fecha_salida;
        public string numero_personas;
        public string estado;
        public string servicios_adicionales;
        public int tarifa_total;
        public string metodo_pago;
    }
    [Serializable]
    public struct Servicio
    {
        public int id;
        public string nombre;
        public string descripcion;
        public int precio;
        public string disponibilidad;
    }
    public partial class Form1 : Form
    {
        public string ArchivoHoteles = "hoteles.bin";
        public string ArchivoHabitaciones = "habitaciones.bin";
        public string ArchivoReservas = "Reservas.bin";
        public string ArchivoServicios = "Servicios.bin";
        public string ArchivoClientes = "Clientes.bin";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reservación reservación = new Reservación();
            reservación.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReservacionClientes abrir = new ReservacionClientes();
            abrir.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
