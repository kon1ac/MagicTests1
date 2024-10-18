using System.Text.RegularExpressions;

namespace PasswordCheck
{
    public class PassCheck
    {
        public int CheckPassword(string password)
        {
            int score = 0;
            if (Regex.IsMatch(password, @"\d"))
                score++;
            if (Regex.IsMatch(password, @"[a-z]"))
                score++;
            if (Regex.IsMatch(password, @"[A-Z]"))
                score++;
            if (Regex.IsMatch(password, @"\W"))
                score++;
            if (password.Length > 10)
                score++;
            return score;
        }
    }
}