using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfanityCleaner
{
    class ProfanityCleaner
    {
        Dictionary<string, string> _profanity = new Dictionary<string, string>();
        
        public ProfanityCleaner()
        {
            _profanity.Add("darn", "d**n");
            _profanity.Add("gosh", "g**h");
            _profanity.Add("yuck", "y**k");
        }
        public string Clean(string value)
        {
            return _profanity[value];
        }
    }
}
