using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTestApp.Controls.TabTypes
{
    class CodeEditor : MahApps.Metro.Controls.MetroTabItem
    {

       

        public CodeEditor(string file)
        {
            this.Header = Path.GetFileName(file);
            //this.CloseButtonEnabled = true;
            //this.Style = (Style)FindResource("TabItem.VisualStudio");

         
        }
    }
}
