using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Baigiamasis_dabras
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        DataLDataContext db = new DataLDataContext();        
        public async void MainFrm_Load(object sender, EventArgs e)
        {
            Task laikoTarpas = new Task(LaikoTarpas);
            laikoTarpas.Start();
            GetDate();
        }
        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.Show();
            db.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Tekstas("textBox1_TextChanged", textBox1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Tekstas("textBox3_TextChanged", textBox3);
        }    
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Tekstas("textBox4_TextChanged", textBox4);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Tekstas("textBox5_TextChanged", textBox5);
            Filtras();
            Timer.Text = "20";
        }       

        public void button1_Click(object sender, EventArgs e)
        {
            Mygtukas("button1_Click", "Irašymas");          
            Irasymas();
            GetDate();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Mygtukas("button2_Click", "Ištrynimas");
            Istrinimas();
            GetDate();
        } 
        private void checkBox1_Click(object sender, EventArgs e)
        {
            CheBox("checkBox1_Click", checkBox1);
        }










        //Metodai
        public void GetDate()
        {
            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Donc3vAs\source\repos\Baigiamasis_dabras\Baigiamasis_dabras\Data.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Vardas, Numeris, Elpastas, Vip, id from Klientai";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void LaikoTarpas()
        {
            while (int.Parse(Timer.Text) > 0)
            {
                Thread.Sleep(1000);
                Timer.Text = Convert.ToString(int.Parse(Timer.Text) - 1);
                if (Timer.Text == "0")
                {
                    MessageBox.Show("Jūsų sesija baigėsi", "Atsijungta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        public void Irasymas()
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Įveskite Varda");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
            }
            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Įveskite telefono nr.");
                return;
            }
            else if (!Regex.IsMatch(textBox3.Text, @"^(\+370[0-9]{8})$"))
            {
                errorProvider1.SetError(textBox3, "Neteisingas telefono nr.");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox3, null);
            }

            if (!Regex.IsMatch(textBox4.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$") && textBox4.Text != "")
            {
                errorProvider1.SetError(textBox4, "Įveskite teisingą el. paštą");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox4, null);
            }
            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Donc3vAs\source\repos\Baigiamasis_dabras\Baigiamasis_dabras\Data.mdf;Integrated Security=True");
            con.Open();
            var cmd = new SqlCommand("INSERT INTO Klientai (Vardas, Numeris, Elpastas, Vip) VALUES (@Vardas, @Numeris, @Elpastas, @Vip)", con);
            var cmdtikrinimui = new SqlCommand("INSERT INTO Klientaitikrint (Vardas, Numeris, Elpastas, Vip, Vartotojas, Session, Veiksmas) " +
                "VALUES (@Vardas, @Numeris, @Elpastas, @Vip, @Vartotojas, @Session, @Veiksmas)", con);
            cmd.Parameters.Add("@Vardas", textBox1.Text);
            cmd.Parameters.Add("@Numeris", textBox3.Text);
            cmd.Parameters.Add("@Elpastas", textBox4.Text);
            cmd.Parameters.Add("@Vip", (checkBox1.Checked) ? "Taip" : "Ne");
            cmd.ExecuteNonQuery();
            cmdtikrinimui.Parameters.Add("@Vardas", textBox1.Text);
            cmdtikrinimui.Parameters.Add("@Numeris", textBox3.Text);
            cmdtikrinimui.Parameters.Add("@Elpastas", textBox4.Text);
            cmdtikrinimui.Parameters.Add("@Vip", (checkBox1.Checked) ? "Taip" : "Ne");
            cmdtikrinimui.Parameters.Add("@Vartotojas", Vardaslabel.Text);
            cmdtikrinimui.Parameters.Add("@Session", int.Parse(Sessionlabel.Text));
            cmdtikrinimui.Parameters.Add("@Veiksmas", "Irašymas");
            cmdtikrinimui.ExecuteNonQuery();
            textBox1.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            con.Close();
            cmd.Dispose();
            cmdtikrinimui.Dispose();
        }
        public void Istrinimas()
        {
            try
            {
                var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Donc3vAs\source\repos\Baigiamasis_dabras\Baigiamasis_dabras\Data.mdf;Integrated Security=True");
                con.Open();
                var cmd = new SqlCommand("DELETE FROM Klientai WHERE Vardas = @Vardas AND Numeris = @Numeris AND Elpastas = @Elpastas AND Vip = @Vip", con);
                var cmdtikrinimui = new SqlCommand("INSERT INTO Klientaitikrint (Vardas, Numeris, Elpastas, Vip, Vartotojas, Session, Veiksmas) " +
                    "VALUES (@Vardas, @Numeris, @Elpastas, @Vip, @Vartotojas, @Session, @Veiksmas)", con);
                cmd.Parameters.AddWithValue("@Vardas", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Vardas"].Value.ToString());
                cmd.Parameters.AddWithValue("@Numeris", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Numeris"].Value.ToString());
                cmd.Parameters.AddWithValue("@Elpastas", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Elpastas"].Value.ToString());
                cmd.Parameters.AddWithValue("@Vip", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Vip"].Value.ToString());
                cmd.ExecuteNonQuery();
                cmdtikrinimui.Parameters.Add("@Vardas", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Vardas"].Value.ToString());
                cmdtikrinimui.Parameters.Add("@Numeris", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Numeris"].Value.ToString());
                cmdtikrinimui.Parameters.Add("@Elpastas", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Elpastas"].Value.ToString());
                cmdtikrinimui.Parameters.Add("@Vip", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Vip"].Value.ToString());
                cmdtikrinimui.Parameters.Add("@Vartotojas", Vardaslabel.Text);
                cmdtikrinimui.Parameters.Add("@Session", int.Parse(Sessionlabel.Text));
                cmdtikrinimui.Parameters.Add("@Veiksmas", "Ištrynimas");
                cmdtikrinimui.ExecuteNonQuery();
                con.Close();
                cmd.Dispose();
                cmdtikrinimui.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Nėra duomenų arba nepažymėjote ką norite trinti");
            }
        }

        public void Tekstas(string eveName, TextBox textboxName)
        {
            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Donc3vAs\source\repos\Baigiamasis_dabras\Baigiamasis_dabras\Data.mdf;Integrated Security=True");
            con.Open();
            var cmd = new SqlCommand("INSERT INTO Ivykiai (Vartotojas, Session, Eventas, Tekstas, TikslusLaikas, Tarpas) VALUES (@Vartotojas, @Session, @Eventas, @Tekstas, @TikslusLaikas, @Tarpas)", con);
            cmd.Parameters.Add("@Vartotojas", Vardaslabel.Text);
            cmd.Parameters.Add("@Session", int.Parse(Sessionlabel.Text));
            cmd.Parameters.Add("@Eventas", eveName);
            cmd.Parameters.Add("@Tekstas", textboxName.Text);
            cmd.Parameters.Add("@TikslusLaikas", DateTime.Now);
            cmd.Parameters.Add("@Tarpas", (20 - int.Parse(Timer.Text)) * 1000);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            Timer.Text = "20";
        }        
        public void CheBox(string eveName, CheckBox checkBoxname)
        {
            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Donc3vAs\source\repos\Baigiamasis_dabras\Baigiamasis_dabras\Data.mdf;Integrated Security=True");
            con.Open();
            var cmd = new SqlCommand("INSERT INTO Ivykiai (Vartotojas, Session, Eventas, Tekstas, TikslusLaikas, Tarpas) VALUES (@Vartotojas, @Session, @Eventas, @Tekstas, @TikslusLaikas, @Tarpas)", con);
            cmd.Parameters.Add("@Vartotojas", Vardaslabel.Text);
            cmd.Parameters.Add("@Session", int.Parse(Sessionlabel.Text));
            cmd.Parameters.Add("@Eventas", eveName);
            cmd.Parameters.Add("@Tekstas", checkBoxname.Checked);
            cmd.Parameters.Add("@TikslusLaikas", DateTime.Now);
            cmd.Parameters.Add("@Tarpas", (20 - int.Parse(Timer.Text)) * 1000);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            Timer.Text = "20";
        }
        public void Mygtukas(string eveName, string tekst)
        {
            var con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Donc3vAs\source\repos\Baigiamasis_dabras\Baigiamasis_dabras\Data.mdf;Integrated Security=True");
            con.Open();
            var cmd = new SqlCommand("INSERT INTO Ivykiai (Vartotojas, Session, Eventas, Tekstas, TikslusLaikas, Tarpas) VALUES (@Vartotojas, @Session, @Eventas, @Tekstas, @TikslusLaikas, @Tarpas)", con);
            cmd.Parameters.Add("@Vartotojas", Vardaslabel.Text);
            cmd.Parameters.Add("@Session", int.Parse(Sessionlabel.Text));
            cmd.Parameters.Add("@Eventas", eveName);
            cmd.Parameters.Add("@Tekstas", tekst);
            cmd.Parameters.Add("@TikslusLaikas", DateTime.Now);
            cmd.Parameters.Add("@Tarpas", (20 - int.Parse(Timer.Text)) * 1000);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            Timer.Text = "20";
        }
            private void Filtras()
        {
            dataGridView1.DataSource = from a in db.GetTable<Klientai>()
                                       where a.Elpastas.Contains(textBox5.Text) || a.Vardas.Contains(textBox5.Text) ||
                                       a.Numeris.Contains(textBox5.Text) || a.Vip.Contains(textBox5.Text)
                                       select a;
        }
    }
}
