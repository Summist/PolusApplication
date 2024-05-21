using Microsoft.EntityFrameworkCore;
using PolusApplication.WinForms.Database;
using PolusApplication.WinForms.Database.Entities;
using PolusApplication.WinForms.Informations;

namespace PolusApplication.WinForms.Forms;

public partial class RequestsForm : Form
{
    public RequestsForm()
    {
        InitializeComponent();
        InitializeRequests();

        SelectedRequestInfo.Info = null!;
    }

    private void InitializeRequests()
    {
        using (var dbContext = new ApplicationDbContext())
        {
            var requests = dbContext.Requests
                .AsNoTracking()
                .ToList();

            dataGridView.DataSource = requests;
        }
    }

    private void ButtonBack_Click(object sender, EventArgs e) => Close();


    private void ButtonEditRequest_Click(object sender, EventArgs e)
    {
        if (SelectedRequestInfo.Info is null)
        {
            MessageBox.Show("Вы не выбрали элемент для редактирования", "Уведомление");
            return;
        }

        var form = new EditRequestForm();

        Hide();
        form.ShowDialog();
        Show();

        InitializeRequests();
    }

    private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            var row = dataGridView.Rows[e.RowIndex];
            var rowContext = row.DataBoundItem as Request;

            if (rowContext is null)
            {
                MessageBox.Show("Ошибка, неверная конвертация выбранного элемента", "Ошибка");
                return;
            }

            SelectedRequestInfo.Info = rowContext;
        }
    }

    private void ButtonSearch_Click(object sender, EventArgs e)
    {
        string searchText = searchedTextBox.Text;
        
        if (string.IsNullOrWhiteSpace(searchText))
        {
            InitializeRequests();
            return;
        }

        if (!int.TryParse(searchText, out int result))
        {
            MessageBox.Show("Неверные данные для поиска, введите Id заявки", "Уведомление");
            return;
        }

        using (var dbContext = new ApplicationDbContext())
        {
            var request = dbContext.Requests
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == result);

            if (request is null)
            {
                MessageBox.Show("Заявка по такому Id не найдена", "Уведомление");
                return;
            }

            dataGridView.DataSource = new List<Request>() { request };
        }
    }
}
