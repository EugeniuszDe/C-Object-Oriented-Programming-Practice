using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment4
{
    /// <summary>
    /// Converts words to digits
    /// </summary>
    public class Digitizer
    {
        #region Fields

        Dictionary<string, int> countDictionary = new Dictionary<string, int>();

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Digitizer()
        {
            countDictionary.Add("zero", 0);
            countDictionary.Add("one", 1);
            countDictionary.Add("two", 2);
            countDictionary.Add("three", 3);
            countDictionary.Add("four", 4);
            countDictionary.Add("five", 5);
            countDictionary.Add("six", 6);
            countDictionary.Add("seven", 7);
            countDictionary.Add("eight", 8);
            countDictionary.Add("nine", 9);

        }

        #endregion

        #region Public methods

        /// <summary>
        /// Converts the given word to the corresponding digit.
        /// If the word isn't a valid digit name, returns -1
        /// </summary>
        /// <param name="word">word to convert</param>
        /// <returns>corresponding digit or -1</returns>
        public int ConvertWordToDigit(string word)
        {
            string newValue = word.ToLower();
            if (countDictionary.ContainsKey(newValue))
            {
                return countDictionary[newValue];
            }
            else
            {
                return -1;
            }
        }

        #endregion
    }
}
