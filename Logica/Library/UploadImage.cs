using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class UploadImage
    {
        private OpenFileDialog fd = new OpenFileDialog();

        public void CargarImagen (PictureBox pb)
        {
            pb.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg;*.png;*.jpeg";
            fd.ShowDialog();

            if(fd.FileName != string.Empty)
            {
                pb.ImageLocation = fd.FileName;
            }
        }
    }
}
