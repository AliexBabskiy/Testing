using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Pass
    {
        public int CheckPasswordNumber(string password)
        {
            int score = 0;
            if (password.Any(char.IsNumber)) score++;
            return score;
        }
        public int CheckPasswordLower(string password)
        {
            int score = 0;
            if (password.Any(char.IsLower)) score++;
            return score;
        }
        public int CheckPasswordUpper(string password)
        {
            int score = 0;
            if (password.Any(char.IsUpper)) score++;
            return score;
        }
        public int CheckPasswordSymbol(string password)
        {
            int score = 0;
            if (password.Any(c => char.IsPunctuation(c) || char.IsSymbol(c))) score++;
            return score;
        }
        public int CheckPasswordLength(string password)
        {
            int score = 0;
            if (password.Length >= 10) score++;
            return score;
        }
    }
}
