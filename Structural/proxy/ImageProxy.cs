using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.proxy
{
    internal class ImageProxy : IImage
    {
        private string _filename;
        private HighResImage _realImage;

        public ImageProxy(string filename)
        {
            _filename = filename;
        }
        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new HighResImage(_filename);
            }
            _realImage.Display();
        }
    }
}
