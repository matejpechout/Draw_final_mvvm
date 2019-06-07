using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DrawNew
{
    interface IPicturePicker       
    {       
            Task<Stream> GetImageStreamAsync();        
    }
}

