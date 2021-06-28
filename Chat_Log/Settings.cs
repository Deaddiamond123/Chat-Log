    namespace Chat_Log
{
    public class Settings
    {
        //Specify the limit of the Queue.
        public int MaxLogMessages { get; set; } = 300;
        /* Depending on the number, will change the language of the plugin
         * 0 = English
         * 1 = Spanish
         * 2 = French 
         * 3 = Polish */
        public int Language { get; set; } = 0;
        public string _Available_languages { get; set; } = "0 = English; 1 = Spanish; 2 = French; 3 = Polish.";
    }
}