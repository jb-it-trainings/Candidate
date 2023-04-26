using System.Collections.Generic;

namespace Candidate
{
    /// <summary>
    /// Class that holds multiple Languages Information
    /// </summary>
    public class Languages
    {
        public List<Language> LanguageList { get; set; }
    }

    /// <summary>
    /// Class that holds one Language Information
    /// </summary>
    public class Language
    {
        public string LanguageName { get; set; }
        public string Proficiency { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
        public bool Speak { get; set; }
    }
}
