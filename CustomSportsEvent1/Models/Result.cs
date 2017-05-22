namespace CustomSportsEvent1.Models
{
    public class Result
    { public string playerId { get; set; }
        public string result { get; set; }
    }
    public class RootObject
    {
        public Result person { get; set; }
    }
}