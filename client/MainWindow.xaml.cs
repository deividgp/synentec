using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using client.Models;
using client.Services;

namespace client;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    HttpClient client = new HttpClient();
    UserService userService;
    User user = new();

    public MainWindow()
    {
        client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        userService = new(client);
        InitializeComponent();
    }

    private async void btnLoadUsers_Click(object sender, RoutedEventArgs e)
    {
        dgUser.DataContext = await userService.GetUsers();
    }

    private async void btnSaveUser_Click(object sender, RoutedEventArgs e)
    {
        if(user.Id == 0 || user == null)
        {
            user = new()
            {
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                Fullname = txtFullname.Text,
                Role = txtRole.Text,
            };
            await userService.SaveUser(user);
        }
        else
        {
            user.Username = txtUsername.Text;
            user.Email = txtEmail.Text;
            user.Fullname = txtFullname.Text;
            user.Role = txtRole.Text;

            await userService.EditUser(user);
        }

        user = new();
    }

    private async void dgUser_Initialized(object sender, EventArgs e)
    {
        dgUser.DataContext = await userService.GetUsers();
    }

    private async void btnDeleteUser_Click(object sender, RoutedEventArgs e)
    {
        User userAux = ((FrameworkElement)sender).DataContext as User;

        if (userAux == null) return;

        await userService.DeleteUser(userAux.Id);
        dgUser.DataContext = await userService.GetUsers();
    }

    private async void btnEditUser_Click(object sender, RoutedEventArgs e)
    {
        user = ((FrameworkElement)sender).DataContext as User;

        if (user == null) return;

        txtUsername.Text = user.Username;
        txtEmail.Text = user.Email;
        txtRole.Text = user.Role;
        txtFullname.Text = user.Fullname;
    }
}
