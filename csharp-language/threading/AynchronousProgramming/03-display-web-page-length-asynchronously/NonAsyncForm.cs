using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace test
{
    class NonAsyncForm : Form
    {
        Label label;
        Button button;

        public NonAsyncForm()
        {
            label = new Label { Location = new Point(10, 20), Text = "Length" };
            button = new Button { Location = new Point(10, 50), Text = "Click" };
            button.Click += DisplayWebSiteLength;
            AutoSize = true;
            Controls.Add(label);
            Controls.Add(button);
        }

        void DisplayWebSiteLength(object sender, EventArgs e)
        {
            label.Text = "Fetching...";
            using (WebClient client = new WebClient())
            {
                string text = client.DownloadString("https://en.wikipedia.org/wiki/United_States");
                label.Text = text.Length.ToString();
            }
        }

        
    }
}
