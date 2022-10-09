namespace Domain
{
    public class AppWord
    {
        public string WordString {get; set;}
        public string PicturePath {get; set;}
        public string AudioPath {get; set;}
        public WordLanguage Language {get; set;}

        public AppWord()
        {
        }
        public AppWord(string wordString, string picturePath, string audioPath,
        WordLanguage language) : base()
        {
            WordString = wordString;
            PicturePath = picturePath;
            AudioPath = audioPath;
            Language = language;
        }
    }
}