using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        Server s;
        public FrmServer()
        {
            InitializeComponent();
            btnPokreniServer.Enabled = true;
            btnZaustavi.Enabled = false;
        }

        private void btnPokreniServer_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.PokreniServer())
            {
                Thread nit = new Thread(s.Osluskuj);
                nit.IsBackground = true;
                nit.Start();
                lblServerStanje.Text = " Server je pokrenut";
                btnPokreniServer.Enabled = false;
                btnZaustavi.Enabled = true;
            }
            else lblServerStanje.Text = " Nije moguće pokrenuti server";
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (s.ZaustaviServer())
            {
                lblServerStanje.Text = " Server je zaustavljen";
                btnPokreniServer.Enabled = true;
                btnZaustavi.Enabled = false;
            }
            else
            {
                lblServerStanje.Text = "Nije moguće zaustaviti server";
            }
        }
    }
}
