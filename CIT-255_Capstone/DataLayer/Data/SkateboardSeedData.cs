using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIT_255_Capstone.Models;

namespace CIT_255_Capstone.DataLayer.Data
{
   public class SkateboardSeedData
    {
        public static List<Skateboard> GenerateListOfSkateboards()
        {
            List<Skateboard> skateboards = new List<Skateboard>()
            {
                new Skateboard()
                {
                    Id = 1,
                    CompanyName = "Enjoy",
                    Age = 9,
                    WoodType = "Bamboo",
                    ImageFilePath ="Enjoy.jpg",
                    Rating = 3,
                    Pros = "Luie Brletta",
                    Size = 4
                },

                new Skateboard()
                {
                    Id = 2,
                    CompanyName = "Krooked",
                    Age = 12,
                    WoodType = "Hardwood",
                    ImageFilePath ="Krooked.jpg",
                    Rating = 4,
                    Pros = "Gonz",
                    Size = 5
                },

                new Skateboard()
                {
                    Id = 3,
                    CompanyName = "Element",
                    Age = 15,
                    WoodType = "Bamboo",
                    ImageFilePath ="Element.jpg",
                    Rating = 2,
                    Pros = "Nyjah",
                    Size = 4
                }

            };

            return skateboards;

        }
        }

    }

