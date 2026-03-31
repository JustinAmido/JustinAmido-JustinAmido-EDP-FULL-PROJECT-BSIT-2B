using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm2
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            this.Load += frmHome_Load;
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            MakeButtonRound(btnBck);
            btnBck.FlatStyle = FlatStyle.Flat;
            btnBck.FlatAppearance.BorderSize = 0;
            btnBck.BackColor = Color.Transparent;
        }
        private void MakeButtonRound(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pricebook frm = new Pricebook();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Register frm = new Register ();
            frm.Show();
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            StoreStatus frm = new StoreStatus();
            frm.Show();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            Vendors frm = new Vendors();
            frm.Show();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            Users frm = new Users();
            frm.Show();
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            TimeClock frm = new TimeClock();
            frm.Show();
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
