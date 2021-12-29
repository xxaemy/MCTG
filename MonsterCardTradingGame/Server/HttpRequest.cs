﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCardTradingGame.Server
{
    class HttpRequest
    {
        public string Method { get; private set; } // GET, POST 
        public string Path { get; private set; } // api/controller
        public string Version { get; private set; }
        public string Content { get; set; } //only post
        public Dictionary<string, string> Headers { get; set; }

        public HttpRequest(string method, string path, string version, Dictionary<string, string> headers)
        {
            this.Method = method;
            this.Path = path;
            this.Version = version;
            this.Headers = headers;
        }
    }
}
