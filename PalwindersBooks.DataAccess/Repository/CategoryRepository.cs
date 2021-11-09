using PalwindersBooks.DataAccess.Repository.IRepository;
using PalwindersBooks.Models;
using PalwindersBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace PalwindersBooks.DataAccess.Repository
{
    public class  CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
