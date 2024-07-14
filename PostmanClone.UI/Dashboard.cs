using PostmanClone.Library;

namespace PostmanClone.UI
{
    public partial class Dashboard : Form
    {
        private readonly IApiAccess _apiAccess = new ApiAccess();

        public Dashboard()
        {
            InitializeComponent();
            httpVerpSelection.SelectedItem = "GET";
        }

        private async void callAPI_Click(object sender, EventArgs e)
        {
            stripStatus.Text = "Calling API...";
            resultWindow.Text = string.Empty;
            if (_apiAccess.IsValidUrl(apiText.Text) == false)
            {
                stripStatus.Text = "Invalid URL";
                return;
            }

            HttpAction action;
            if (Enum.TryParse(httpVerpSelection.SelectedItem!.ToString(), out action) == false)
            {
                stripStatus.Text = "Invalid HTTP Verb";
                return;
            }


            try
            {

                resultWindow.Text = await _apiAccess.CallApiAsync(apiText.Text, bodyText.Text, action);
                callData.SelectedTab = outputTab;
                outputTab.Focus();
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
