using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapanyagok.Models;
using Tapanyagok.Repositories;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Presenters
{
    class TablazatPresenter
    {
        private TapanyagRepository repo;
        private ITablazatView view;

        public TablazatPresenter(ITablazatView tablazatView)
        {
            this.repo = new TapanyagRepository();
            this.view = tablazatView;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllTapanyag(
                page: view.page,
                itemsPerPage: view.itemsPerPage,
                search: view.search,
                sortBy: view.sortBy,
                ascending: view.ascending);
            view.totalItems = repo.TotalItems;
        }

        public void Add(tapanyag tapanyag)
        {
            //repo.GetAllTapanyag().Add(tapanyag);
            view.bindingList.Add(tapanyag);
            repo.Insert(tapanyag);
        }

        public void Remove(int index)
        {
            var tapanyag = view.bindingList.ElementAt(index);
            //repo.GetAllTapanyag().RemoveAt(index);
            view.bindingList.Remove(tapanyag);
            //view.bindingList.RemoveAt(index); ?
            if (tapanyag.id > 0)
            {
                repo.Delete(tapanyag.id);
            }
        }

        public void Modifiy(int index, tapanyag param)
        {
            var regiTapanyag = view.bindingList.ElementAt(index);
            // ??
            if (regiTapanyag != null)
            {
                regiTapanyag.id = param.id;
                regiTapanyag.nev = param.nev;
                regiTapanyag.energia = param.energia;
                regiTapanyag.szenhidrat = param.szenhidrat;
                regiTapanyag.feherje = param.feherje;
                regiTapanyag.zsir = param.zsir;
            }
            if (regiTapanyag.id > 0)
            {
                repo.Update(regiTapanyag);
            }
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
