using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDiTest.ViewModels
{
    public class TitleVM
    {
        public TitleVM(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}
