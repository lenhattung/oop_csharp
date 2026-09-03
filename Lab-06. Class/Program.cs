using Lab_06._Class;

MyDate d1 = new MyDate(1, 5, 2005);
MyDate d2 = new MyDate(1, 6, 2005);
MyDate d3 = new MyDate(1, 7, 2005);
MyDate d4 = new MyDate(1, 8, 2005);

Student st1 = new Student("SV01", "Le Nhat Tung", 19, 9.0);
st1.SetDateOfBirth(d1);


st1.PrintInfo();