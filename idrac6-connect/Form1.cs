using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idrac6_connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "iDRAC6 Client";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var host = textBox2.Text;
            var username = textBox1.Text;
            var password = textBox3.Text;
            Debug.WriteLine(host);
            System.Diagnostics.Process.Start(".\\lib\\lib\\Java64\\bin\\java", "-cp .\\lib\\avctKVM.jar -Djava.library.path=.\\lib com.avocent.idrac.kvm.Main ip=" + host + " kmport=5900 vport=5900 user=" + username + " passwd=" + password + " apcp=1 version=2 vmprivilege=true 'helpurl = https://%drachost%:443/help/contents.html'");
        }
    }
}
