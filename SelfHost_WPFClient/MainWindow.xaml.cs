using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace SelfHost_WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Main_Loaded(object sender, RoutedEventArgs e)
        {
            var url = "http://localhost:8090/";           
            HubConnection hubConnection = new HubConnection(url);
            hubConnection.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            var proxy = hubConnection.CreateHubProxy("NotificationHub");
                      

            try
            {
                Serverdata.Text = "Connection to Server";
                hubConnection.Start().Wait();

                connectionID.Content =  hubConnection.ConnectionId.ToString();

                //var txt = proxy.Invoke("GetArraymsg", "AnbuSai");

                var text = proxy.Invoke<string[]>("Get").Result;

                #region
                //proxy.Invoke<string>("Get", new { message = "Test" }).ContinueWith(task =>
                //{
                //    Console.WriteLine("Value from server {0}", task.Result);
                //});

                //proxy.Invoke("Get", Serverdata.Text).Wait();

                //string[] wordsToSend = new[] { "one", "two", "three", "four" };
                //foreach (string word in wordsToSend)
                //{
                //    var a = proxy.Invoke<string>("GetArraymsg", word).Start;
                //}                
                #endregion

                if (text.Any())
                {
                    Serverdata.Text = string.Empty;
                    Dispatcher.Invoke(() =>
                    {
                        text.ToList().ForEach(p =>
                        {
                            Serverdata.Text += $" {p} \n"; //$"Server Text: {p} \n";
                        });

                    });
                }

                //if (txt != null)
                //{
                //    txtName.Text = txt.Status.ToString();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
