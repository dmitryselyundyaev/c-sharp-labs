using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlReader
{
    public partial class CinemaUpdate : Form
    {
        public CinemaUpdate()
        {
            InitializeComponent();
        }

        private void CinemaUpdate_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if((double.Parse(textBoxPrice.Text) < 900000000) && (double.Parse(textBoxIncome.Text) < 900000000) && (double.Parse(textBoxProfit.Text) < 900000000) && (!string.IsNullOrEmpty(textBoxCountry.Text)))
                {
                    if ((double.Parse(textBoxPrice.Text) > -10000000) && (double.Parse(textBoxIncome.Text) > -10000000) && (double.Parse(textBoxProfit.Text) > -10000000)
                        && (!string.IsNullOrEmpty(textBoxNameOfFilm.Text)) && (!string.IsNullOrEmpty(textBoxProducer.Text)))
                    {
                        DialogResult = DialogResult.OK;
                    }
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }
    }
}
