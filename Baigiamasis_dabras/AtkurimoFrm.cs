using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baigiamasis_dabras
{
    public partial class AtkurimoFrm : Form
    {
        public AtkurimoFrm()
        {
            InitializeComponent();
        }

        private void AtkurimoFrm_Load(object sender, EventArgs e)
        {        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task keitimas = new Task(Keitimas);
            keitimas.Start();            
        }

        public void Keitimas()
        {           
            DataLDataContext db = new DataLDataContext();
            var lentele = from a in db.GetTable<Ivykiai>()
                    where a.Vartotojas == label1.Text &&
                    a.Session == Convert.ToInt32(label2.Text)
                    select a;
            List<List<string>> naujas = new List<List<string>>();
            int sk = 0;
            int sec = 0;
            foreach (var item in lentele)
            {
                if (item.Eventas == "textBox1_TextChanged")
                {                    
                    Thread.Sleep(100);
                    textBox1.Text = item.Tekstas;
                    Thread.Sleep(Convert.ToInt32(item.Tarpas));
                    sec += 50 + Convert.ToInt32(item.Tarpas);
                }
                if (item.Eventas == "textBox3_TextChanged")
                {
                    Thread.Sleep(100);
                    textBox3.Text = item.Tekstas;
                    Thread.Sleep(Convert.ToInt32(item.Tarpas));
                    sec += 50 + Convert.ToInt32(item.Tarpas);
                }
                if (item.Eventas == "textBox4_TextChanged")
                {
                    Thread.Sleep(100);
                    textBox4.Text = item.Tekstas;
                    Thread.Sleep(Convert.ToInt32(item.Tarpas));
                    sec += 50 + Convert.ToInt32(item.Tarpas);
                }
                if (item.Eventas == "textBox5_TextChanged")
                {
                    Thread.Sleep(100);
                    textBox5.Text = item.Tekstas;
                    Thread.Sleep(Convert.ToInt32(item.Tarpas));
                    sec += 50 + Convert.ToInt32(item.Tarpas);
                }
                if (item.Eventas == "checkBox1_Click")
                {
                    Thread.Sleep(100);
                    checkBox1.Checked = (item.Tekstas == "1") ? true : false;
                    Thread.Sleep(Convert.ToInt32(item.Tarpas));
                    sec += 50 + Convert.ToInt32(item.Tarpas);
                }
                if (item.Eventas == "button1_Click")
                {
                    Thread.Sleep(100);
                    button1.BackColor = Color.White;
                    Thread.Sleep(100);
                    button1.BackColor = default(Color);
                    Thread.Sleep(Convert.ToInt32(item.Tarpas));
                    sec += 50 + Convert.ToInt32(item.Tarpas);
                }
                if (item.Eventas == "button2_Click")
                {
                    Thread.Sleep(100);
                    button2.BackColor = Color.White;
                    Thread.Sleep(100);
                    button2.BackColor = default(Color);
                    Thread.Sleep(Convert.ToInt32(item.Tarpas));
                    sec += 50 + Convert.ToInt32(item.Tarpas);
                }
                sk += 1;     
            }
            db.Dispose();
            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Donc3vAs\source\repos\Baigiamasis_dabras\Baigiamasis_dabras\Data.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Vardas, Numeris, Elpastas, Vip, Veiksmas, Vartotojas, Session FROM Klientaitikrint WHERE Vartotojas = '" + label1.Text + "' AND Session = '" + label2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}