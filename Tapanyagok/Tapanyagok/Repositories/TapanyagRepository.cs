using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapanyagok.Models;

namespace Tapanyagok.Repositories
{
    class TapanyagRepository
    {
        TpContext db = new TpContext();

        private int _totalItems;

        public BindingList<tapanyag> GetAllTapanyag(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.tapanyag.OrderBy(x => x.nev).AsQueryable();
            
            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                int.TryParse(search, out int ertek);

                query = query.Where(x =>
                    x.nev.Contains(search) ||
                    x.energia.Equals(ertek) ||
                    x.feherje.Equals(ertek) ||
                    x.zsir.Equals(ertek) ||
                    x.szenhidrat.Equals(ertek));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "nev":
                        query = ascending ? query.OrderBy(x => x.nev) : query.OrderByDescending(x => x.nev);
                        break;
                    case "energia":
                        query = ascending ? query.OrderBy(x => x.energia) : query.OrderByDescending(x => x.energia);
                        break;
                    case "feherje":
                        query = ascending ? query.OrderBy(x => x.feherje) : query.OrderByDescending(x => x.feherje);
                        break;
                    case "zsir":
                        query = ascending ? query.OrderBy(x => x.zsir) : query.OrderByDescending(x => x.zsir);
                        break;
                    case "szenhidrat":
                        query = ascending ? query.OrderBy(x => x.szenhidrat) : query.OrderByDescending(x => x.szenhidrat);
                        break;
                    default:
                        break;
                }
            }

            // Összes találat kiszámítása
            _totalItems = query.Count();

            // Oldaltördelés
            if (page + itemsPerPage > 0)
            {
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            }

            return new BindingList<tapanyag>(query.ToList());
        }

        public int TotalItems
        {
            get { return _totalItems; }
        }

        public bool Exists(int id)
        {
            return db.tapanyag.Any(x => x.id.Equals(id));
        }

        public tapanyag GetTapanyag(int id)
        {
            return db.tapanyag.AsNoTracking().SingleOrDefault(x => x.id == id);
        }

        public void Insert(tapanyag tapanyag)
        {
            db.tapanyag.Add(tapanyag);
        }

        public void Update(tapanyag param)
        {
            var tapanyag = db.tapanyag.Find(param.id);
            if (tapanyag != null)
            {
                db.Entry(tapanyag).CurrentValues.SetValues(param);
            }
        }

        public void Delete(int id)
        {
            var tapanyag = db.tapanyag.Find(id);
            db.tapanyag.Remove(tapanyag);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
