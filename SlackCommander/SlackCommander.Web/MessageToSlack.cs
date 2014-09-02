﻿namespace SlackCommander.Web
{
    public class MessageToSlack
    {
        public string username { get; set; }
        public string icon_url { get; set; }
        public string icon_emoji { get; set; }
        public string channel { get; set; }
        public string text { get; set; }
        public bool unfurl_links { get; set; }
    }
}