namespace Lab_06._Class
{
    public class MyDate
    {
        // Thuoc tinh
        private int _day;
        private int _month;
        private int _year;

        // Constructor
        // Khong co tham so 
        public MyDate()
        {
            _day = 1;
            _month = 1;
            _year = 2005;
        }
        // Constructor co tham so: Day, Month, Year
        public MyDate(int Day, int Month, int Year)
        {
            _day = Day;
            _month = Month;
            _year = Year;
        }

        // Getter va setter
        public int GetDay()
        {
            return _day;
        }
        public void SetDay(int Day)
        {
            _day = Day;
        }

        public int GetMonth()
        {
            return _month;
        }

        public void SetMonth(int Month)
        {
            _month = Month;
        }

        public int GetYear()
        {
            return _year;
        }

        public void SetYear(int Year)
        {
            _year = Year;
        }

    }
}
