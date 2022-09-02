using Npgsql;
using System.Data;

namespace KursBD.Class
{
    public class Context
    {
        private readonly db database;

        public Context(db database)
        {
            this.database = database;
        }

        public List<Game> GetAllGames()
        {
            var table = new DataTable();
            var adapter = new NpgsqlDataAdapter();
            var command = new NpgsqlCommand("SELECT * FROM \"Games\" ", database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            var list = new List<Game>();
            foreach (DataRow item in table.Rows)
            {

                var game = new Game
                {
                    Id = (int)item.ItemArray[0],
                    Name = (string)item.ItemArray[1],
                    YearOfRelease = ((DateTime)item.ItemArray[2]).ToLongDateString(),
                    Price = decimal.Parse(item.ItemArray[3].ToString()),
                    Description = (string)item.ItemArray[4],
                    IdDevelopers = (int)item.ItemArray[5],
                    IdPublishers = (int)item.ItemArray[6],
                    ImageURL = item.ItemArray[7] is DBNull ? null : (string)item.ItemArray[7],

                };
                list.Add(game);
            }

            return list.OrderBy(g => g.Id).ToList();
        }

        public SystemRequirements GetSystemRequirements(int gameId)
        {
            var table = new DataTable();
            var adapter = new NpgsqlDataAdapter();
            var command = new NpgsqlCommand($"SELECT * FROM \"SystemRequirements\" WHERE \"idGame\" = {gameId}", database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0) return null;

            DataRow item = table.Rows[0];
            return new SystemRequirements
            {
                Id = (int)item.ItemArray[0],
                OC = (string)item.ItemArray[1],
                CPU = (string)item.ItemArray[2],
                RAM = (string)item.ItemArray[3],
                GPU = (string)item.ItemArray[4],
                DirectX = (string)item.ItemArray[5],
                DiskSpace = (string)item.ItemArray[6]

            };
        }

        public Developers GetDevelopers(int developerId)
        {
            var table = new DataTable();
            var adapter = new NpgsqlDataAdapter();
            var command = new NpgsqlCommand($"SELECT * FROM \"Developers\" WHERE \"id\" = {developerId}", database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0) return null;

            DataRow item = table.Rows[0];
            return new Developers
            {
                Id = (int)item.ItemArray[0],
                NameDeveloper = (string)item.ItemArray[1],

            };
        }
        public Publishers GetPublishers(int publisherId)
        {
            var table = new DataTable();
            var adapter = new NpgsqlDataAdapter();
            var command = new NpgsqlCommand($"SELECT * FROM \"Publishers\" WHERE \"id\" = {publisherId}", database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0) return null;

            DataRow item = table.Rows[0];
            return new Publishers
            {
                Id = (int)item.ItemArray[0],
                NamePublisher = (string)item.ItemArray[1]
            };
        }

        public Tags GetTags(int gameId)
        {
            var table = new DataTable();
            var adapter = new NpgsqlDataAdapter();
            var command = new NpgsqlCommand($"select TGS.\"Name\" from public.\"TagsGame\" TG inner join public.\"Tags\" TGS on TG.\"idTags\" = TGS.id Where TG.\"idGame\" = {gameId}", database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0) return null;

            var list = new List<string>();
            foreach (DataRow item in table.Rows)
            {
                foreach (string value in item.ItemArray)
                {
                    list.Add(value);
                }
            }

            return new Tags
            {
                Tag1 = list.Distinct().Aggregate(string.Empty, (acc, cur) => $"{acc}, {cur}").Trim(new[] { ' ', ',' }),
                
            };
        }

        public List<Reviews> GetReviews(int gameId)
        {
            var table = new DataTable();
            var adapter = new NpgsqlDataAdapter();
            var command = new NpgsqlCommand($"Select R.\"Review\", U.\"Login\", U.\"Nickname\" From public.\"Reviews\" R Inner join public.\"Users\" U on R.\"IdUser\" = U.\"id\" Where R.\"idGame\" = {gameId}", database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 0) return null;

            var list = new List<Reviews>();
            foreach (DataRow item in table.Rows)
            {
                list.Add(new Reviews
                {
                    reviews = (string)item.ItemArray[0],
                    Login = (string)item.ItemArray[1],
                    Nickname = item.ItemArray[2] is DBNull ? null : (string)item.ItemArray[2]
                });
            }

            return list;
        }
    }
}
