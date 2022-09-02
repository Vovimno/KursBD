namespace KursBD
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string YearOfRelease { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int IdDevelopers { get; set; }
        public int IdPublishers { get; set; }
        public string ImageURL { get; set; }

    }
}
