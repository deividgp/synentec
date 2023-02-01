using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models;

public class User
{
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; } = string.Empty;
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; } = string.Empty;
    [JsonProperty(PropertyName = "fullname")]
    public string Fullname { get; set; } = string.Empty;
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; } = string.Empty;
}
