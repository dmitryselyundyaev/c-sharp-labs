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
    public partial class DataChange : Form
    {
        public DataChange()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
