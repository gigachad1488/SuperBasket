using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Markup.Xaml;

namespace slovopacana100procentov.Views;

public partial class MessageBox : Window
{
    public MessageBox(MessageBoxType type, string text)
    {
        InitializeComponent();

        this.text.Text = text;

        if (type == MessageBoxType.Ok)
        {
            Button b = new Button();
            b.Content = "OK";
            b.Width = 200;
            b.Height = 80;
            b.Click += delegate { Close(null); };
            buttonsPanel.Children.Add(b);
        }
        else
        {
            Button b = new Button();
            b.Content = "YES";
            b.Width = 200;
            b.Height = 80;
            b.Click += delegate { Close(true); };
            
            Button bb = new Button();
            bb.Content = "NO";
            bb.Width = 200;
            bb.Height = 80;
            bb.Click += delegate { Close(false); };
            buttonsPanel.Children.Add(b);
            buttonsPanel.Children.Add(bb);
        }
    }
}

public enum MessageBoxType
{
    Ok,
    YesNo
}