using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading;

namespace LanguageTranslator {
	public class Translator {
		// In this example I use constants to determine the language direction
		// Though a better solution is to use an enum. I did not use an enum because you 
		// have as of yet not learned what an enum is. What this example is meant to illustrate
		// is that you can define constant numeric values
		public const int EnglishToGerman = 1;
		public const int FrenchToGerman = 2;
		public const int GermanToEnglish = 3;
		public const int FrenchToEnglish = 4;
		
		public const int UnitedStates = 1;
		public const int Germany = 2;
		public const int Canada = 3;
		
	    public static string TranslateHello( int language, string input) {
	        string temp = input.ToLower().Trim();
			switch( language) {
				case EnglishToGerman: {
					if (temp.CompareTo("hello") == 0) {
						return "hallo";
					}
					break;
				}
				case FrenchToGerman: {
					if (temp.CompareTo("allo") == 0) {
						return "hallo";
					}			
					break;
				}
				case GermanToEnglish: {
					if( temp.CompareTo( "aufwiedersehen") == 0) {
						return "goodbye";
					}
					break;
				}
				case FrenchToEnglish : {
					if( temp.CompareTo( "aurevoir") == 0) {
						return "goodbye";
					}
					break;
				}
			}
	        return "";
	    }
		public static string ConvertNumberToString( int fromCountry, int toCountry, double number) {
			CultureInfo current = Thread.CurrentThread.CurrentCulture;
			string retval = "";
			if( UnitedStates == fromCountry && Germany == toCountry) {
				Thread.CurrentThread.CurrentCulture = new CultureInfo( "de-DE");
				retval = number.ToString("0.00");
			}
			Thread.CurrentThread.CurrentCulture = current;
			return retval
		}
	}
}