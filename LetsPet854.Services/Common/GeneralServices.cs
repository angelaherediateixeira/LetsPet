using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Business.Common
{
    public class GeneralServices
    {
        string DefaultTextFormat(string userInput)
        {
            return CapitalizeLettersAfterSpace(userInput).Trim();
        }

        string CapitalizeLettersAfterSpace(string text)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(text);
        }
    }
}
