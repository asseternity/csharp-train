namespace WritingTracker
{
    class TrackerManager
    {
        public static List<Day> currentWeek = new List<Day>();
        public static void CreateWeek()
        {
            Day Monday = new Day();
            Monday.DayOfTheWeek = "Monday";
            Monday.DidWriting = false;
            Day Tuesday = new Day();
            Tuesday.DayOfTheWeek = "Tuesday";
            Tuesday.DidWriting = false;
            Day Wednesday = new Day();
            Wednesday.DayOfTheWeek = "Wednesday";
            Wednesday.DidWriting = false;
            Day Thursday = new Day();
            Thursday.DayOfTheWeek = "Thursday";
            Thursday.DidWriting = false;
            Day Friday = new Day();
            Friday.DayOfTheWeek = "Friday";
            Friday.DidWriting = false;
            Day Saturday = new Day();
            Saturday.DayOfTheWeek = "Saturday";
            Saturday.DidWriting = false;
            Day Sunday = new Day();
            Sunday.DayOfTheWeek = "Sunday";
            Sunday.DidWriting = false;

            currentWeek.Add(Monday);
            currentWeek.Add(Tuesday);
            currentWeek.Add(Wednesday);
            currentWeek.Add(Thursday);
            currentWeek.Add(Friday);
            currentWeek.Add(Saturday);
            currentWeek.Add(Sunday);                                                            
        }
        public static void AddEntry(int dayNumber, string entryText)
        {
            currentWeek[dayNumber-1].Entry = entryText;
        }
        public static void WroteToday(int dayNumber)
        {
            currentWeek[dayNumber-1].DidWriting = true;
        }
    }
}