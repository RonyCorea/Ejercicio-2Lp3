namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Nombre = new string[3];
        int[] Edad = new int[3];
        int contadorNombre = -1;
        int contadorEdad = -1;
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            contadorNombre = contadorNombre + 1;
            contadorEdad = contadorEdad + 1;
            Nombre[contadorNombre] = NombreTextBox.Text;
            Edad[contadorEdad] = Convert.ToInt32(EdadTextBox.Text);
            LimpiarDatos();
        }

        private void MostrarDatosButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Nombre.Length; i++)
            {
                MostrarDatosComboBox.Items.Add(Nombre[i] + "   " + Edad[i]);
            }
        }
        public void LimpiarDatos()
        {
            NombreTextBox.Text = "";
            EdadTextBox.Text = Convert.ToString(" ");
        }
    }
}