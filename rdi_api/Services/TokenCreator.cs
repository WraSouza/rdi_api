using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rdi_api.Services
{
    public class TokenCreator
    {
        public static string token { get; set; }
        public static DateTime TokenCreationTime { get; set; }

        public static string CreateToken(string _cardnumber)
        {
            token = _cardnumber.Substring(12);
            
            return token;
        }

        public static DateTime TokenTime()
        {
            TokenCreationTime = DateTime.Now;

            return TokenCreationTime;
        }

        public static bool ValidateToken(DateTime creationTime)
        {
            bool tokenvalidate = false;
            int currentMinute = DateTime.Now.Minute;
            //int creationRange = creationTime.Minute - TokenCreationTime.Minute;

            //Verifica se o minuto atual é menor do que o minuto criado pois pode ter sido criado no fim da hora anterior.
            if(currentMinute >= creationTime.Minute)
            {
                int creationRange = currentMinute - creationTime.Minute;
                if(creationRange < 10)
                {
                    tokenvalidate = true;
                }
                
            }
            else
            {
                int minutesleft = (60 - creationTime.Minute) + DateTime.Now.Minute;

                if(minutesleft < 30)
                {
                    tokenvalidate = true;
                }
            }            

            return tokenvalidate;
        }

    }
}
