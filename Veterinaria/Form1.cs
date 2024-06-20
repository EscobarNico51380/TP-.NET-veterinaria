namespace Veterinaria
{
    public partial class Form1 : Form
    {
        private List<Alumno> alum = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
            Coneccion coneccion = new Coneccion();


            alum = coneccion.ObtenerClientes();


            dataGridView1.DataSource = alum;

            

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
