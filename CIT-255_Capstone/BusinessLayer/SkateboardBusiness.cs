using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIT_255_Capstone.Models;
using CIT_255_Capstone.DataLayer.Repository;

namespace CIT_255_Capstone.BusinessLayer
{
    public enum FileIoMessage
    {
        None,
        Complete,
        FileAccessError,
        RecordNotFound
    }
    public class SkateboardBusiness
    {
        public FileIoMessage FileIoStatus { get; set; }
        public SkateboardBusiness()
        {

        }

        private List<Skateboard> SkateboardList()
        {
            List<Skateboard> skateboards = new List<Skateboard>();
            FileIoStatus = FileIoMessage.None;

            using (SkateboardRepository sbReposotory = new SkateboardRepository())
            {
                try
                {
                    skateboards = sbReposotory.GetAll() as List<Skateboard>;

                    FileIoStatus = FileIoMessage.Complete;
                }
                catch (Exception)
                {
                    FileIoStatus = FileIoMessage.FileAccessError;
                }
            };

            return skateboards;
        }

        public List<Skateboard> AllSkateboards()
        {
            return SkateboardList() as List<Skateboard>;
        }

        public Skateboard SkateboardById(int id)
        {
            List<Skateboard> skateboards = SkateboardList();
            Skateboard skateboard = skateboards.FirstOrDefault(c => c.Id == id);

            if (skateboard == null)
            {
                FileIoStatus = FileIoMessage.RecordNotFound;
            }
            else
            {
                FileIoStatus = FileIoMessage.Complete;
            }

            return skateboard;
        }

        public void AddFlinstoneCharacter(Skateboard skateboard)
        {
            FileIoStatus = FileIoMessage.None;

            using (SkateboardRepository sbRepository = new SkateboardRepository())
            {
                try
                {
                    sbRepository.Add(skateboard);
                    FileIoStatus = FileIoMessage.Complete;
                }
                catch (Exception)
                {
                    FileIoStatus = FileIoMessage.FileAccessError;

                }


            }

        }

        public void DeleteSkateboard(Skateboard skateboard)
        {
            FileIoStatus = FileIoMessage.None;

            using (SkateboardRepository sbRepository = new SkateboardRepository())
            {
                try
                {
                    sbRepository.Delete(skateboard.Id);
                    FileIoStatus = FileIoMessage.Complete;
                }
                catch (Exception)
                {
                    FileIoStatus = FileIoMessage.FileAccessError;

                }


            }
        }

        public void UpdateSkateboard(Skateboard skateboard)
        {
            FileIoStatus = FileIoMessage.None;

            using (SkateboardRepository sbRepository = new SkateboardRepository())
            {
                try
                {
                    sbRepository.Update(skateboard);
                    FileIoStatus = FileIoMessage.Complete;
                }
                catch (Exception)
                {
                    FileIoStatus = FileIoMessage.FileAccessError;

                }


            }
        }

    }
}
