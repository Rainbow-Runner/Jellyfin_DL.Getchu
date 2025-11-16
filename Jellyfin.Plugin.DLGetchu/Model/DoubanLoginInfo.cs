using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.DLGetchu.Model
{
    public class DoubanLoginInfo
    {
        public string Name { get; set; }
        public bool IsLogined { get; set; }
    }
}