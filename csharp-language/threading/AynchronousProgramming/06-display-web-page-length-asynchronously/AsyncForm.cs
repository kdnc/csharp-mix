using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    class AsyncForm : Form
    {
        Label label;
        Button button;

        public AsyncForm()
        {
            label = new Label { Location = new Point(10, 20), Text = "Length" };
            button = new Button { Location = new Point(10, 50), Text = "Click" };
            button.Click += DisplayWebSiteLength;
            AutoSize = true;
            Controls.Add(label);
            Controls.Add(button);
        }

        /* 
        CODE BLOCK EXPLANATION - 4
        * The syntax for an async method declaration is exactly the same as for any other
        method, except it has to include the asynccontextual keyword.
        */
        async void DisplayWebSiteLength(object sender, EventArgs e)
        {
            label.Text = "Fetching...";
            using (HttpClient client = new HttpClient())
            {
                /* 
                CODE BLOCK EXPLANATION - 3
                * The execution flow in an asynchronous method in C# 5 typically follows these lines:
	                1 Do some work. 
	                2 Start an asynchronous operation, and remember the token it returns. 
	                3 Possibly do some more work. (Often you can’t make any further progress until
	                the asynchronous operation has completed, in which case this step is empty.) 
	                4 Wait for the asynchronous operation to complete (via the token). 
	                5 Do some more work. 
	                6 Finish.
                */
                Task<string> task = client.GetStringAsync("https://en.wikipedia.org/wiki/United_States");
                string text = await task;
                label.Text = text.Length.ToString();
            }
        }

        
    }
}
