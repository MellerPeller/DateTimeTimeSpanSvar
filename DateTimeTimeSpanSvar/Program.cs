namespace DateTimeTimeSpanSvar
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DateTime & TimeSpan: Svar till uppgifter:");
            Console.WriteLine("Uppgift 1: " + Uppgift1());
            Console.WriteLine("Uppgift 2: " + Uppgift2());
            Console.WriteLine("Uppgift 3; " + Uppgift3());
            Console.WriteLine("Uppgift 4; " + Uppgift4());
            Console.WriteLine("Uppgift 5; " + Uppgift5());
            Console.WriteLine("Uppgift 6; " + Uppgift6());

        }

        public static string Uppgift1()
        {
            DateTime Avatar1 = new DateTime(2009, 12, 18);
            DateTime Avatar2 = new DateTime(2022, 12, 8);

            TimeSpan AvatarWait = Avatar2 - Avatar1;
            int AvatarWaitDays = (int)AvatarWait.TotalDays;

            return AvatarWaitDays.ToString();
        }

        public static string Uppgift2()
        {
            DateTime birthDay = new DateTime(2007, 2, 19);
            TimeSpan age = DateTime.Now - birthDay;
            int totaldays = (int)age.TotalDays;
            int totalhours = (int)age.TotalHours;
            int totalminutes = (int)age.TotalMinutes;
            int totalseconds = (int)age.TotalSeconds;
            
            string birthDayAge = totaldays + " " + totalhours + " " + totalminutes + " " + totalseconds;

            return birthDayAge;
        }

        public static string Uppgift3() 
        {
            DateTime birthDay = new DateTime(2007, 2, 19);
            TimeSpan age = DateTime.Now - birthDay;
            TimeSpan doubleAge = age * 2;

            

            return doubleAge.ToString();

        }

        public static string Uppgift4() 
        {
            DateTime dt1 = new DateTime(2022, 3, 26);
            DateTime dt2 = new DateTime(2022, 3, 27);

            TimeSpan ts1 = dt2 - dt1;

            int totalhours = (int)ts1.TotalHours;

            return totalhours.ToString();

        }

        public static string Uppgift5()
        {
            DateTime januari23 = new DateTime(2023, 1, 1);
            DateTime januari24 = new DateTime(2024, 1, 1);
            DateTime januari25 = new DateTime(2025, 1, 1);

            TimeSpan ts23To24 = januari24 - januari23;
            TimeSpan ts24To25 = januari25 - januari24;

            int totaldays1 = (int)ts23To24.TotalDays;
            int totaldays2 = (int)ts24To25.TotalDays;

            return "Från 2023/1/1 till 2024/1/1 " + totaldays1 + "dagar. Från 2024/1/1 till 2025/1/1 var det " + totaldays2 + " dagar."; 

        }

        public static string Uppgift6() 
        {
           
            TimeSpan ts1 = new TimeSpan(0, 1, 59, 30);
            TimeSpan ts2 = new TimeSpan(0, 2, 0, 30);

            TimeSpan ts3 =  ts2 - ts1;

            int totalSeconds = (int)ts3.TotalSeconds;

            return totalSeconds.ToString();
        }
    }
}
