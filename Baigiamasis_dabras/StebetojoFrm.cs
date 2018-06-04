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
    public partial class StebetojoFrm : Form
    {
        public StebetojoFrm()
        {
            InitializeComponent();
            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Donc3vAs\source\repos\Baigiamasis_dabras\Baigiamasis_dabras\Data.mdf;Integrated Security=True");
            con.Open();
            var cmd = new SqlCommand("SELECT Vartotojas FROM Vartotojai", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Vartotojas"].ToString() != "Stebetojas")
                {
                    string VartName = reader["Vartotojas"].ToString();
                    comboBox1.Items.Add(VartName);
                }
            }
            con.Close();
            cmd.Dispose();
            reader.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                comboBox2.Visible = true;
                label2.Visible = true;
            }
            comboBox2.Items.Clear();
            comboBox2.Text = null;
            button1.Visible = false;
            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Donc3vAs\source\repos\Baigiamasis_dabras\Baigiamasis_dabras\Data.mdf;Integrated Security=True");
            con.Open();
            var cmd = new SqlCommand("SELECT Session FROM Ivykiai WHERE Vartotojas = '"+comboBox1.Text+"'", con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Sess = reader["Session"].ToString();
                if (!comboBox2.Items.Contains(Sess))
                {
                    comboBox2.Items.Add(Sess);
                }
                
            }
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                button1.Visible = true;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                button1.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AtkurimoFrm Atkfrm = new AtkurimoFrm();
                Atkfrm.Show();
                Atkfrm.label1.Text = comboBox1.Text;
                Atkfrm.label2.Text = comboBox2.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }

        }

    }
}
