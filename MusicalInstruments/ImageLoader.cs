using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalInstruments
{
    public partial class ImageLoader : Form
    {
        private Image image;

        public ImageLoader ()
        {
            InitializeComponent();
        }

        public ImageLoader (Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        private void btnCancel_Click (object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOpen_Click (object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Загрузить изображение";
                dlg.Filter = "Изображения (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pictureBox1.Image = new Bitmap(dlg.FileName);

                    image = pictureBox1.Image;
                }
            }
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            this.Image = pictureBox1.Image;
            this.DialogResult = DialogResult.OK;
        }
    }
}
