using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassConsole {
    public class Airplane {
        private string StartCity;
        private string FinishCity;

        private Date StartDate;
        private Date FinishDate;

        public Airplane() {}

        public Airplane(string StartCity, string FinishCity) {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
        }

        public Airplane(Date StartDate, Date FinishDate) {
            this.StartDate = StartDate;
            this.FinishDate = FinishDate;
        }

        public Airplane(string StartCity, string FinishCity, Date StartDate, Date FinishDate) {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            this.StartDate = StartDate;
            this.FinishDate = FinishDate;
        }

        public Airplane(Airplane airplane) {
            StartCity = airplane.getStartCity();
            FinishCity = airplane.getFinishCity();
            StartDate = airplane.GetStartDate();
            FinishDate = airplane.GetFinishDate();
        }

        public double GetTotalTime() {
            TimeSpan totalSpan = FinishDate.ToDateTime().Subtract(StartDate.ToDateTime());

            return totalSpan.TotalMinutes;
        }

        public bool IsArrivingToday() {
            return (StartDate.GetYear() == FinishDate.GetYear() && StartDate.GetMonth() == FinishDate.GetMonth()) &&
                StartDate.GetDay() == FinishDate.GetDay();
        }

        public void setStartCity(string StartCity) {
            this.StartCity = StartCity;
        }

        public string getStartCity() {
            return StartCity;
        }

        public void setFinishCity(string FinishCity) {
            this.FinishCity = FinishCity;
        }

        public string getFinishCity() {
            return FinishCity;
        }

        public void SetStartDate(Date StartDate) {
            this.StartDate = StartDate;
        }

        public Date GetStartDate() {
            return StartDate;
        }

        public void SetFinishDate(Date FinishDate) {
            this.FinishDate = FinishDate;
        }

        public Date GetFinishDate() {
            return FinishDate;
        }
    }
}
