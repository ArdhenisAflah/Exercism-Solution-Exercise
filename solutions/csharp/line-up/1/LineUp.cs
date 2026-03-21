public static class LineUp
{
    public static string Format(string name, int number)
    {
        return $"{name}, you are the {number}{((number % 10 == 1 && number < 100 && number != 11 ) || (number > 99 && number % 100 != 11 && number % 10 == 1) ? "st" : (number % 10 == 2 && number < 100 && number != 12 ) || (number > 99 && number % 100 != 12 && number % 10 == 2) ?  "nd" : (number % 10 == 3 && number < 100 && number != 13 ) || (number > 99 && number % 100 != 13 && number % 10 == 3) ? "rd" : "th")} customer we serve today. Thank you!";
    }
}
