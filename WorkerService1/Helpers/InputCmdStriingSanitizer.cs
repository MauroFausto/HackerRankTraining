using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankService.Helpers
{
    public class InputCmdStriingSanitizer
    {
        private readonly string _stringToSanitize = "";

        public InputCmdStriingSanitizer(string stringToSanitize)
        {
            _stringToSanitize = stringToSanitize;
        }

        public string FirstLayerSanitizer()
        {


            return _stringToSanitize;
        }
    }
}
