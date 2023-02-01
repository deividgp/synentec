using client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace client.Services;

public class UserService
{
    readonly HttpClient Client;

    public UserService(HttpClient client)
    {
        Client = client;
    }

    public async Task<List<User>?> GetUsers()
    {
        string response = await Client.GetStringAsync("users");
        return JsonConvert.DeserializeObject<List<User>>(response);
    }

    public async Task SaveUser(User user)
    {
        await Client.PostAsJsonAsync("users/", user);
    }

    public async Task EditUser(User user)
    {
        string convert = JsonConvert.SerializeObject(user, Formatting.Indented);
        Trace.WriteLine(convert);
        await Client.PutAsJsonAsync("users/" + user.Id + "/", convert);
    }

    public async Task DeleteUser(int userId)
    {
        await Client.DeleteAsync("users/" + userId);
    }
}
