namespace WinFormsTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }

        private void muestraTabla()
        {
            //int n = this.textBoxNum.Text;   //es como un get, se necesita convertir
            int n = Convert.ToInt32(this.textBoxNum.Text);
            string tabla = "";
            for (int i = 0; i < 10; i++)
            {
                tabla = tabla +"        " + n + " x " + i + " = " + (n * i) + "\n";      //es como un cout
            }
            this.richTextBoxResultados.AppendText(tabla);   //se le agrega texto a la tabla rich
        }

    }
}
