
namespace MysticPartyTracker.Models
{
    public class Dice
    {
        public int Side { get; set; }
        public int Quantity { get; set; }

        public Dice(int side, int quantity)
        {
            Quantity = quantity;
            Side = side;
        }

        public int Roll()
        {
            return new Random().Next(Side) + 1;
        }

        public List<int> RollDices()
        {
            List<int> dices = new List<int>([]);
            for (int i = 0; i < Quantity; i++)
            {
                dices.Add(Roll());
            }
            return dices;
        }

        
        public class Result
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public int Level { get; set; }
            public string Url { get; set; }
        }

        public class Response
        {
            public int Count { get; set; }
            public List<Result> Results { get; set; }
        }
    }
}
