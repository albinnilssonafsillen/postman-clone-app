using PostmanClone.Library;

namespace PostmanClone.UI
{
    public partial class Dashboard : Form
    {
        private readonly IApiAccess _apiAccess = new ApiAccess();

        public Dashboard()
        {
            InitializeComponent();
        }

        private async void callAPI_Click(object sender, EventArgs e)
        {
            stripStatus.Text = "Calling API...";
            resultWindow.Text = string.Empty;

            try
            {
                if (_apiAccess.IsValidUrl(apiText.Text) == false)
                {
                    stripStatus.Text = "Invalid URL";
                    return;
                }
                else
                {
                    resultWindow.Text = await _apiAccess.CallApiAsync(apiText.Text);
                    stripStatus.Text = "Ready";
                }
            }
            catch (Exception ex)
            {
                resultWindow.Text = "Error happend" + ex.Message;
                stripStatus.Text = "Error";
            }
        }
    }
}
