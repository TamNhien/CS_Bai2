using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai2
{
    internal class Video
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string MainActor { get; set; }
        public string MainActress { get; set; }
        public int YearOfProduction { get; set; }
        public string ProductionCompany { get; set; }

        public Video(string title, string genre, string director, string mainActor, string mainActress, int yearOfProduction, string productionCompany)
        {
            Title = title;
            Genre = genre;
            Director = director;
            MainActor = mainActor;
            MainActress = mainActress;
            YearOfProduction = yearOfProduction;
            ProductionCompany = productionCompany;
        }
    }
}
