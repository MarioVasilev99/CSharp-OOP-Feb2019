namespace Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Smartphone : ICallable, IBrowsable
    {
        private string[] numbersToCall;
        private string[] websitesToBrowse;

        public Smartphone(string[] numbersToCall, string[] sitesToBrowse)
        {
            this.NumbersToCall = numbersToCall;
            this.SitesToBrowse = sitesToBrowse;
        }

        public string[] NumbersToCall
        {
            set
            {
                string[] validNumbers = this.ValidateNumbers(value);
                this.numbersToCall = validNumbers;
            }
        }

        public string[] SitesToBrowse
        {
            set
            {
                string[] validWebsites = this.ValidateWebSites(value);
                this.websitesToBrowse = validWebsites;
            }
        }

        public string Call()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var number in numbersToCall)
            {
                if (number == "Invalid number!")
                {
                    stringBuilder.AppendLine(number);
                }
                else
                {
                    stringBuilder.AppendLine($"Calling... {number}");
                }
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public string Browse()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var site in websitesToBrowse)
            {
                if (site == "Invalid URL!")
                {
                    stringBuilder.AppendLine(site);
                }
                else
                {
                    stringBuilder.AppendLine($"Browsing: {site}!");
                }
            }

            return stringBuilder.ToString().TrimEnd();
        }

        private string[] ValidateNumbers(string[] value)
        {
            var validNumbers = new List<string>();

            foreach (var number in value)
            {
                if (number.All(c => char.IsDigit(c)))
                {
                    validNumbers.Add(number);
                }
                else
                {
                    validNumbers.Add("Invalid number!");
                }
            }

            return validNumbers.ToArray();
        }

        private string[] ValidateWebSites(string[] sites)
        {
            var validWebSites = new List<string>();

            foreach (var site in sites)
            {
                if (!site.Any(c => char.IsDigit(c)))
                {
                    validWebSites.Add(site);
                }
                else
                {
                    validWebSites.Add("Invalid URL!");
                }
            }

            return validWebSites.ToArray();
        }
    }
}
