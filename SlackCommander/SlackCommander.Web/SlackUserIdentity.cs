﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy.Security;

namespace SlackCommander.Web
{
    public class SlackUserIdentity : IUserIdentity
    {
        public IEnumerable<string> Claims
        {
            get { return Enumerable.Empty<string>(); }
        }

        public string UserName
        {
            get { return "dummy-username"; }
        }
    }
}