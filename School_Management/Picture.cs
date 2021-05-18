using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class Picture
    {
        public Image Content { get; set; }

        public Picture()
        {

        }
        public Picture(Image content)
        {
            try
            {
                Content = content;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public byte[] toByteArray()
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(Content, typeof(byte[]));
                return image;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Image ByteArrToImage(byte[] arr)
        {
            try
            {
                MemoryStream stream = new MemoryStream(arr);
                Image image = Image.FromStream(stream);
                return image;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
