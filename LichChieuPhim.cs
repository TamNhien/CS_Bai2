using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai2
{
    internal class LichChieuPhim : Video
    {
        public string ShowDate { get; set; }
        public string ShowTime { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public double TicketPrice { get; set; }

        public LichChieuPhim(string title, string genre, string director, string mainActor, string mainActress, int yearOfProduction, string productionCompany, string showDate, string showTime, string startTime, string endTime, double ticketPrice)
            : base(title, genre, director, mainActor, mainActress, yearOfProduction, productionCompany)
        {
            ShowDate = showDate;
            ShowTime = showTime;
            StartTime = startTime;
            EndTime = endTime;
            TicketPrice = ticketPrice;
        }

        public void ApplyDiscount()
        {
            if (ShowDate == "Wednesday" || ShowDate == "Thursday")
            {
                TicketPrice *= 0.5;
            }
        }

        public override string ToString()
        {
            return $"Title: {Title}, Genre: {Genre}, Director: {Director}, Main Actor: {MainActor}, Main Actress: {MainActress}, Year: {YearOfProduction}, Production: {ProductionCompany}, Date: {ShowDate}, Time: {ShowTime}, Start: {StartTime}, End: {EndTime}, Price: {TicketPrice:C}";
        }
    }
}
