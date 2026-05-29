using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CyberBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Chatbot bot;
        private bool waitingForName = true;  // ✅ flag

        public MainWindow()
        {
            InitializeComponent();
            bot = new Chatbot();
            bot.SetUI(AddMessage);
            bot.StartChatbot();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string userText = UserInput.Text.Trim();
            if (string.IsNullOrEmpty(userText)) return;

            AddMessage("You", userText);

            if (waitingForName)   // ✅ handle name first
            {
                bot.SetUserName(userText);
                waitingForName = false;  // ✅ switch to conversation mode
            }
            else
            {
                string response = ResponseSystem.GetResponse(userText.ToLower());
                AddMessage("Bot", response);
            }

            UserInput.Clear();
        }

        private void AddMessage(string sender, string message)
        {
            TextBlock msgBlock = new TextBlock
            {
                Text = $"{sender}: {message}",
                Foreground = sender == "Bot" ? System.Windows.Media.Brushes.Yellow : System.Windows.Media.Brushes.White,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(5)
            };
            ChatPanel.Children.Add(msgBlock);
        }
    }
}

