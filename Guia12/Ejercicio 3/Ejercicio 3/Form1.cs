namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form2 fDialogo = new Form2();

            //lsbListado.Items.Clear();   
            //int n = 1;
            //while (n <= 10 && fDialogo.ShowDialog()==DialogResult.OK)
            //{
            //    lsbListado.Items.Add($"{fDialogo.tbValor.Text}");
            //    lbCantidad.Text = "" + n;
            //    //reinicializar
            //    fDialogo.tbValor.Clear();
            //   n++;
            //}

            //lsbListado.Items.Clear();
            //int n = 1;
            //fDialogo.ShowDialog();
            //while (n <= 10 && fDialogo.DialogResult == DialogResult.OK)
            //{
            //    lsbListado.Items.Add($"{fDialogo.tbValor.Text}");
            //    lbCantidad.Text = "" + n;
            //    //reinicializar
            //    fDialogo.tbValor.Clear();
            //    fDialogo.ShowDialog();
            //    n++;
            //}

            lsbListado.Items.Clear();
            fDialogo.ShowDialog();
            for (int n = 1; n <= 10 && fDialogo.DialogResult == DialogResult.OK; n++)
            {
                lsbListado.Items.Add($"{fDialogo.tbValor.Text}");
                lbCantidad.Text = "" + n;
                //reinicializar
                fDialogo.tbValor.Clear();
                fDialogo.ShowDialog();

            }

           
        }

        private void lbCantidad_Click(object sender, EventArgs e)
        {

        }
    }
}
