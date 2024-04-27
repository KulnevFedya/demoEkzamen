using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportShop
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalog_Form form = new Catalog_Form();
            form.Show();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program_class.connection);
            string Sql = "select [Postal_code] from [dbo].[PointOfIssue]";
            con.Open();
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                comboBoxPointOfIssues.Items.Add(DR[0]);
            }


            con.Close();
        }
    }
}
