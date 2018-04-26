using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class frmMetodichka : Form
    {
        public frmMetodichka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void frmMetodichka_Load(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + "\\методичка.pdf";
            webBrowser1.Navigate(filename);
        }
    }
}
