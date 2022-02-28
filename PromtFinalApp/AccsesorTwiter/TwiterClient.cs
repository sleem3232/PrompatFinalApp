namespace TwiterAccsessor
{
    internal class TwiterClient
    {
        private object aPIkey;
        private object aPISecret;
        private object aPIToken;
        private object aPITokenSecret;

        public TwiterClient(string aPIKEY, string aPISECRET, string aPIToken)
        {
            aPIkey = aPIKEY;
            aPISecret = aPISECRET;
            this.aPIToken = aPIToken;
        }

        public TwiterClient(object aPIkey, object aPISecret, object aPIToken, object aPITokenSecret)
        {
            this.aPIkey = aPIkey;
            this.aPISecret = aPISecret;
            this.aPIToken = aPIToken;
            this.aPITokenSecret = aPITokenSecret;
        }

        public object Tweets { get; internal set; }
    }
}