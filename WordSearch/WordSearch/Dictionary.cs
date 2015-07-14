using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    class DictionaryLookup
    {
        Dictionary<string , Words> _wordSearch = new Dictionary<string, Words>();

        public DictionaryLookup()
        {
            _wordSearch.Add("dead", new Words { Word = "dead"});
            _wordSearch.Add("hast", new Words { Word = "hast"});

        } 
        public Words Count(string id)
        {
            return _wordSearch[id];
        }

    }
}
