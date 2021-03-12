using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Data
{
    public interface IInfo
    {
        IEnumerable<News> GetAll();
        News GetById(int id);
    }
}
