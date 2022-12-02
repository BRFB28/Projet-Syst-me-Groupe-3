using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GesRestaurant.View
{
    public partial class Form2 : Form
    {
        SqlConnection cnx;
        public Form2()
        {
            InitializeComponent();
            cnx = new SqlConnection(@"Data Source=PCVairelles;Initial Catalog=GesRestauration;Integrated Security=True");
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            cnx.Open();
            String sql = "insert into Recette(Nom, Prix)values("+ textBox1.Text + ",'" + textBox2.Text + ")";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
    }
}
