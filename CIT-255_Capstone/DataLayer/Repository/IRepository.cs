using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIT_255_Capstone.Models;

namespace CIT_255_Capstone.DataLayer.Repository
{
    public interface IRepository
    {
        IEnumerable<Skateboard> GetAll();
        Skateboard GetById(int id);
        void Add(Skateboard skateboard);
        void Update(Skateboard skateboard);
        void Delete(int id);
    }
}
