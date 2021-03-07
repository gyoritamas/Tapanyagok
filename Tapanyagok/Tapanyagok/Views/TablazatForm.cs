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
using Tapanyagok.Presenters;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Views
{
    public partial class TablazatForm : Form, ITablazatView
    {
        private TablazatPresenter presenter;
        private int _totalItems;
        private int pageCount;
        private int sortIndex;

        public TablazatForm()
        {
            InitializeComponent();
            presenter = new TablazatPresenter(this);
            Init();
        }

        public void Init()
        {
            page = 1;
            itemsPerPage = 25;
            sortBy = "nev";
            sortIndex = 0;
            ascending = true;
        }

        public BindingList<tapanyag> bindingList
        {
            get => (BindingList<tapanyag>)dataGridView.DataSource;
            set => dataGridView.DataSource = value;
        }
        public int page { get; set; }
        public int itemsPerPage { get; set; }

        public string search
        {
            get => keresesTextBox.Text;

        }

        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems
        {
            get => _totalItems;
            set
            {
                _totalItems = value;
                pageCount = (value - 1) / itemsPerPage + 1;
                pagesLabel.Text = page.ToString() + "/" + pageCount.ToString();
            }
        }

        private void TablazatForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        #region Menü elemek
        private void mentesMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }
        private void ujMenuItem_Click(object sender, EventArgs e)
        {
            NewDGRow();
        }
        private void torlesMenuItem_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void keresesMenuItem_Click(object sender, EventArgs e)
        {
            page = 1;
            presenter.LoadData();
        }
        #endregion

        #region Context menü elemek
        private void szerkesztesContextMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows != null)
            {
                var index = dataGridView.SelectedCells[0].RowIndex;

                dataGridView.ClearSelection();
                dataGridView.Rows[index].Selected = true;
                EditDGRow(index);
            }

        }
        private void torlesContextMenuItem_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }
        #endregion

        #region Navigációs gombok

        private void FirstButton_Click(object sender, EventArgs e)
        {
            page = 1;
            presenter.LoadData();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (page != 1)
            {
                page--;
                presenter.LoadData();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (page != pageCount)
            {
                page++;
                presenter.LoadData();
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            page = pageCount;
            presenter.LoadData();
        }

        #endregion

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }

            switch (e.ColumnIndex)
            {
                case 1:
                    sortBy = "nev";
                    break;
                case 2:
                    sortBy = "energia";
                    break;
                case 3:
                    sortBy = "feherje";
                    break;
                case 4:
                    sortBy = "zsir";
                    break;
                case 5:
                    sortBy = "szenhidrat";
                    break;
                default:
                    break;
            }

            sortIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        private void NewDGRow()
        {
            using (var tapanyagForm = new TapanyagForm())
            {
                DialogResult dialogResult = tapanyagForm.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    presenter.Add(tapanyagForm.tapanyag);
                    tapanyagForm.Close();
                }

                RefreshView();
            }
        }

        private void EditDGRow(int index)
        {
            var editedTapanyag = (tapanyag)dataGridView.Rows[index].DataBoundItem;
            using (var tapanyagForm = new TapanyagForm())
            {
                tapanyagForm.tapanyag = editedTapanyag;

                DialogResult dialogResult = tapanyagForm.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    presenter.Modifiy(index, tapanyagForm.tapanyag);
                    tapanyagForm.Close();
                }
            }
        }

        private void DelDGRow()
        {
            while (dataGridView.SelectedRows.Count > 0)
            {
                presenter.Remove(dataGridView.SelectedRows[0].Index);
            }
        }

        private void RefreshView()
        {
            presenter.Save();
            presenter.LoadData();
        }
    }
}
