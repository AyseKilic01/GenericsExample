using GenericsExample.GenericsClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericsExample
{
    public partial class MainForm : Form
    {
        Utilities utilities = new Utilities();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> result = utilities.BuildList<string>("Malatya","Ankara","İstanbul");
            foreach (var i in result)
            {
                lstSehir.Items.Add(i);
            }

        }
    }
}
