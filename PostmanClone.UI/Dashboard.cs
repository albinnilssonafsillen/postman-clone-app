using PostmanClone.Library;

namespace PostmanClone.UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void callAPI_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(apiText.Text.ToLower()) || !apiText.Text.StartsWith("https://"))
                {
                    stripStatus.Text = "Error in Api Url. Must contain value and start with https://";
                    return;
                }
                stripStatus.Text = "Calling API...";

                PostManLibrary library = new PostManLibrary();

                int callType = 1;
                var res = await library.Call(apiText.Text, callType);



                await Task.Delay(2000);

                stripStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultWindow.Text = "Error happend" + ex.Message;
                stripStatus.Text = "Error";
            }
        }
    }
}
