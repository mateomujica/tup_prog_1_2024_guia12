using System.Diagnostics.Eventing.Reader;

namespace Ejercciio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {

            //double valor = Convert.ToDouble(txtValor.Text);
            // lbMostrarValor.Text = ""+valor;
             Form2 fModal = new Form2();
            if (fModal.ShowDialog()==DialogResult.OK)
            {
                lbMostrarValor.Text = fModal.tbValor.Text; 
            }
            else
            {
                lbMostrarValor.Text = "Valor no encontado";
            }
            

            
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void lbMostrarValor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
