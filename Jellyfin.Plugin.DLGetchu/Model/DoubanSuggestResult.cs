using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.DLGetchu.Model;

public class DoubanSuggestResult
{
    [JsonPropertyName("cards")]
    public List<DoubanSuggest>? Cards { get; set; }
}
