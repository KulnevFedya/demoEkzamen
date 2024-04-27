using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportShop
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                Image selectedImage = Image.FromFile(selectedImagePath);
                pictureBoxNewProduct.Image = selectedImage;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    Image selectedImage = pictureBoxNewProduct.Image;

                    //Сохранение фотографии в указанную директорию с выбранным названием
                    //selectedImage.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки фото!", "Ошибка");

            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalog_Form form = new Catalog_Form();
            form.Show();
        }
    }
}