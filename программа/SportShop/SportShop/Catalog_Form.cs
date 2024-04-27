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
    public partial class Catalog_Form : Form
    {
        public Catalog_Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization form = new Authorization();
            form.Show();
        }

        private void Catalog_Form_Load(object sender, EventArgs e)
        {
            if (Program_class.role == 3 || Program_class.role == 0)
            {
                btnAdminForm.Visible = false;
            }
            SqlConnection con = new SqlConnection(Program_class.connection);
            DataSet dataset = new DataSet();

            SqlCommand profiletext = new SqlCommand();
            profiletext.CommandText = $"Select [ProductArticleNumber], [ProductName],[UnitOfMeasurement],[ProductCost],[ProductDiscountMaxAmount],[ProductManufacturer],[ProductProvider],[ProductCategory],[ProductDiscountAmount],[ProductQuantityInStock],[ProductDescription], [ProductPhoto] from [dbo].[Product]";
            profiletext.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
            adapter.Fill(dataset);

            datagridForProducts.DataSource = dataset.Tables[0];

            if (datagridForProducts.DataSource != null)
            {
                datagridForProducts.Columns[0].Visible = false;
                datagridForProducts.Columns[11].Visible = false;
            }
            datagridForProducts.Columns[1].HeaderText = "Название";
            datagridForProducts.Columns[2].HeaderText = "Единица измерения";
            datagridForProducts.Columns[3].HeaderText = "Цена";
            datagridForProducts.Columns[4].HeaderText = "Максимальная скидка";
            datagridForProducts.Columns[5].HeaderText = "Производитель";
            datagridForProducts.Columns[6].HeaderText = "Поставщик";
            datagridForProducts.Columns[7].HeaderText = "Категория";
            datagridForProducts.Columns[8].HeaderText = "Скидка";
            datagridForProducts.Columns[9].HeaderText = "Количество на складе";
            datagridForProducts.Columns[10].HeaderText = "Описание";

            string Sql = "select distinct [ProductManufacturer] from [dbo].[Product]";
            con.Open();
            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader DR = cmd.ExecuteReader();

            comboBoxFilters.Items.Add("Все производители");
            while (DR.Read())
            {
                comboBoxFilters.Items.Add(DR[0]);
            }


            con.Close();

        }
        int selected_product = 0;
        /// <summary>
        /// Если пользователь выберет товар в таблице, то информация о нем выведется в специальном окне с информацией
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagridForProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != null & e.RowIndex != -1)
                {
                    DataGridViewRow productdata = datagridForProducts.Rows[e.RowIndex];

                    if (productdata.Cells[11].Value.ToString() != "")
                    {
                        String imagename = Program_class.folder + productdata.Cells[11].Value.ToString();
                        picBoxForProducts.Image = Image.FromFile(imagename);
                    }
                    else
                    {
                        String imagename = Program_class.folder + "picture.png";
                        picBoxForProducts.Image = Image.FromFile(imagename);
                    }      

                    lblProductName.Text = productdata.Cells[1].Value.ToString();
                    lblProductCost.Text = "" + productdata.Cells[3].Value.ToString();
                    lblProductDescription.Text = productdata.Cells[10].Value.ToString();
                    lblAmountOnStock.Text = "" + productdata.Cells[9].Value.ToString();

                }
            
            }
            catch
            {
                MessageBox.Show("Ошибка выбора товара!", "Ошибка!");
            }
           
        }
        /// <summary>
        /// Сортировка товаров по убыванию цены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            datagridForProducts.Sort(datagridForProducts.Columns[3], ListSortDirection.Descending);
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            datagridForProducts.Sort(datagridForProducts.Columns[3], ListSortDirection.Ascending);
        }

        private void btnAdminForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm form = new adminForm();
            form.Show();
        }

        private void btncart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart form = new Cart();
            form.Show();
        }
        /// <summary>
        /// Если изменятся данные в поле для поиска, то данные в таблице изменятся
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program_class.connection);
                DataSet dataset = new DataSet();

                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = $"Select * FROM Product where [ProductName] like '%{txtBoxSearch.Text}%'";
                profiletext.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
                adapter.Fill(dataset);
                int cnt_rows = 0;
                cnt_rows = dataset.Tables[0].Rows.Count;

                datagridForProducts.DataSource = dataset.Tables[0];

                if (datagridForProducts.DataSource != null)
                {
                    datagridForProducts.Columns[0].Visible = false;
                    datagridForProducts.Columns[11].Visible = false;
                }

                lblAmountProducts.Text = $"{cnt_rows}/37 продуктов показывается";

                con.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка поиска товара", "Ошибка!");
            }

    
        }
        /// <summary>
        /// Фильтры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manufacture = comboBoxFilters.SelectedItem.ToString();
            if (manufacture == "")
            {
                SqlConnection con = new SqlConnection(Program_class.connection);
                DataSet dataset = new DataSet();

                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = $"Select * FROM Product_catalog";
                profiletext.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
                adapter.Fill(dataset);
                int cnt_rows = 0;
                cnt_rows = dataset.Tables[0].Rows.Count;

                datagridForProducts.DataSource = dataset.Tables[0];
                con.Close();


            }
            else
            {
                SqlConnection con = new SqlConnection(Program_class.connection);
                DataSet dataset = new DataSet();

                SqlCommand profiletext = new SqlCommand();
                profiletext.CommandText = $"Select * FROM [dbo].[Product] where [ProductManufacturer] = '{manufacture}'";
                profiletext.Connection = con;
                SqlDataAdapter adapter = new SqlDataAdapter(profiletext);
                adapter.Fill(dataset);
                int cnt_rows = 0;
                cnt_rows = dataset.Tables[0].Rows.Count;

                datagridForProducts.DataSource = dataset.Tables[0];
                con.Close();

                cnt_rows = dataset.Tables[0].Rows.Count;

                lblAmountProducts.Text = $"{cnt_rows}/37 продуктов показывается";
            }
        }
    }
}
