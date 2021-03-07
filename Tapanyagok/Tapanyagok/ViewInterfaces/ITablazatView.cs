using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapanyagok.Models;

namespace Tapanyagok.ViewInterfaces
{
    interface ITablazatView
    {
        BindingList<tapanyag> bindingList { get; set; }
        int page { get; set; }
        int itemsPerPage { get; set; }
        string search { get; set; }
        string sortBy { get; set; }
        bool ascending { get; set; }
        int totalItems { set; }
    }
}
