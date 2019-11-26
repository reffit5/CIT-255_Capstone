using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIT_255_Capstone.Models;
using CIT_255_Capstone.DataLayer;

namespace CIT_255_Capstone.DataLayer.Repository
{
    public class SkateboardRepository : IRepository, IDisposable
    {
        List<Skateboard> _skateboard;

        public void Add(Skateboard skateboard)
        {
            _skateboard.Add(skateboard);
        }

        public void Delete(int id)
        {
            _skateboard.Remove(_skateboard.FirstOrDefault(c => c.Id == id));
        }

        public void Update()
        {

        }

        public IEnumerable<Skateboard> GetAll()
        {
            return _skateboard;
        }

        public Skateboard GetById(int id)
        {
            return _skateboard.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Skateboard skateboard)
        {
            _skateboard.Remove(_skateboard.FirstOrDefault(c => c.Id == skateboard.Id));
            _skateboard.Add(skateboard);
        }

        public void Dispose()
        {
            _skateboard = null;
        }
    }
}
