using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelestialWeaver
{
    public partial class FormHistory : Form
    {
        Form1 pForm;
        public FormHistory(Form1 form)
        {
            InitializeComponent();
            pForm = form;
        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] msg = lbHistory.SelectedItem.ToString().Split('|');
            pForm.LoadHistory(msg[1], msg[2]);
        }
    }
}
