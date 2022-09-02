namespace KursBD.Class
{
    public class Reviews
    {
        public string reviews { get; set; } 
        public string Login { get; set; }
        public string Nickname { get; set; }
        
        public override string ToString()
        {
            var str = string.Empty;
            
            if (!string.IsNullOrWhiteSpace(reviews))
                str += $"Review: {reviews} ";
            
            if (!string.IsNullOrWhiteSpace(Login))
                str += $"Login: {Login} ";
            
            if (!string.IsNullOrWhiteSpace(Nickname))
                str += $"Nickname: {Nickname} ";
            
            return str.Trim();
        }
    }
}
