using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domeni;

namespace Forme
{
    public partial class FrmPrijaviSe : Form
    {
        KontrolerKorisnickogInterfejsa kki = new KontrolerKorisnickogInterfejsa();
        public FrmPrijaviSe()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            kki.Prijavi(txtUser, txtPass, cbAdmin);
        }
    }
}
