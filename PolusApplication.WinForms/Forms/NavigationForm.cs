namespace PolusApplication.WinForms.Forms;

public partial class NavigationForm : Form
{
    public NavigationForm()
    {
        InitializeComponent();
    }

    private void ButtonBack_Click(object sender, EventArgs e) => Close();

    private void ButtonAddRequest_Click(object sender, EventArgs e)
    {
        var form = new AddRequestForm();

        NavigateTo(form);
    }

    private void ButtonRequests_Click(object sender, EventArgs e)
    {
        var form = new RequestsForm();

        NavigateTo(form);
    }

    private void ButtonComments_Click(object sender, EventArgs e)
    {
        var form = new CommentsForm();

        NavigateTo(form);
    }

    private void NavigateTo(Form form)
    {
        Hide();
        form.ShowDialog();
        Show();
    }
}
