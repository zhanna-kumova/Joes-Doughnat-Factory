using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joes_Doughnat_Factory
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnuMake_Click(object sender, EventArgs e)
        {

        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) { 
                errorProvider1.SetError(txtQuantity, " Please enter a numeric value ");
        }else{
                errorProvider1.SetError(txtQuantity, " ");
        } }

        private void TxtQuantity_Validating(object sender, CancelEventArgs e)
        {
            // Проверить, пусто ли поле.
            if (txtQuantity.Text == " ")
            {
                errorProvider1.SetError(txtQuantity, " Please, enter a quantity");
                e.Cancel = true;
            }
            // Проверить, допустимо ли введенное значение.
            else if (errorProvider1.GetError(txtQuantity) != " ")
            {
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtQuantity, " ");
            }
        }
    }
}
