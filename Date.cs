using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassConsole {
    public class Date {
        private int Year;
        private int Month;
        private int Day;
        private int Hours;
        private int Minutes;

        public Date() {}

        public Date(int Year, int Month, int Day, int Hours, int Minutes) {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
            this.Hours = Hours;
            this.Minutes = Minutes;
        }

        public Date(int Day, int Hours, int Minutes) {
            this.Day = Day;
            this.Hours = Hours;
            this.Minutes = Minutes;
        }

        public Date(Date date) {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }

        public void SetYear(int Year) {
            this.Year = Year;
        }

        public int GetYear() {
            return Year;
        }

        public void SetMonth(int Month) {
            this.Month = Month;
        }

        public int GetMonth() {
            return Month;
        }

        public void SetDay(int Day) {
            this.Day = Day;
        }

        public int GetDay() {
            return Day;
        }

        public void SetHours(int Hours) {
            this.Hours = Hours;
        }

        public int GetHours() {
            return Hours;
        }

        public void SetMinutes(int Minutes) {
            this.Minutes = Minutes;
        }

        public int GetMinutes() {
            return Minutes;
        }

        public DateTime ToDateTime() {
            return new DateTime(Year, Month, Day, Hours, Minutes, 0);
        }
    }
}
