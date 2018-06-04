using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baigiamasis_dabras
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        DataLDataContext db = new DataLDataContext();
        private void LoginB_Click(object sender, EventArgs e)
        {
            var usr = db.Vartotojais.Where(c => c.Vartotojas == UserBox.Text).Single();
            string pass = usr.Slaptazodis;
            if (usr == null && pass != PassBox.Text)
            {
                MessageBox.Show("Prisijungimo vardas arba slaptažodis yra neteisingas", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UserBox.Text == "Stebetojas")
                {
                    StebetojoFrm Sfrm = new StebetojoFrm();
                    Sfrm.Show();
                }
                else
                {
                    MainFrm mainFrm = new MainFrm();
                    mainFrm.Show();
                    mainFrm.Vardaslabel.Text = UserBox.Text;
                    try
                    {
                        string x = (from Ivykiai in db.Ivykiais
                                    where Ivykiai.Vartotojas == UserBox.Text
                                    select Ivykiai.Session).Max().ToString();
                        if (x is null)
                        {
                            mainFrm.Sessionlabel.Text = "1";
                        }
                        else
                        {
                            mainFrm.Sessionlabel.Text = Convert.ToString(int.Parse(x) + 1);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                this.Hide();
            }
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }
    }
}
