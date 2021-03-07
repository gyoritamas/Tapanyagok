using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tapanyagok.Models;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Views
{
    public partial class TapanyagForm : Form, ITapanyagView
    {
        private int Id;

        public TapanyagForm()
        {
            InitializeComponent();

        }

        public tapanyag tapanyag
        {
            get
            {
                string nev = nevTextBox.Text;
                decimal energia = Convert.ToDecimal(energiaNUD.Value);
                decimal feherje = Convert.ToDecimal(feherjeNUD.Value);
                decimal zsir = Convert.ToDecimal(zsirNUD.Value);
                decimal szenhidrat = Convert.ToDecimal(szenhidratNUD.Value);
                var tapanyag = new tapanyag(nev, energia, feherje, zsir, szenhidrat);

                tapanyag.id = this.Id > 0 ? Id : 0;

                return tapanyag;
            }
            set
            {
                Id = value.id;
                nevTextBox.Text = value.nev;
                energiaNUD.Value = value.energia;
                feherjeNUD.Value = value.feherje;
                zsirNUD.Value = value.zsir;
                szenhidratNUD.Value = value.szenhidrat;
            }
        }
    }
}
