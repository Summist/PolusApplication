using Microsoft.EntityFrameworkCore;
using PolusApplication.WinForms.Database;
using PolusApplication.WinForms.Informations;

namespace PolusApplication.WinForms.Forms;

public partial class EditRequestForm : Form
{
    public EditRequestForm()
    {
        InitializeComponent();

        descriptionTextBox.Text = SelectedRequestInfo.Info.ProblemDescription;
    }

    private void ButtonBack_Click(object sender, EventArgs e) => Close();

    private void ButtonSaveEdit_Click(object sender, EventArgs e)
    {
        string description = descriptionTextBox.Text;

        if (string.IsNullOrWhiteSpace(description))
        {
            MessageBox.Show("Описание проблемы обязательно для заполнения", "Уведомление");
            return;
        }

        SelectedRequestInfo.Info.ProblemDescription = descriptionTextBox.Text;

        using (var dbContext = new ApplicationDbContext())
        {
            try
            {
                dbContext.Entry(SelectedRequestInfo.Info).State = EntityState.Modified;
                dbContext.SaveChanges();

                MessageBox.Show("Редактирование прошло успешно", "Уведомление");
                Close();
            }
            catch
            {
                MessageBox.Show("Редактирование не удалось", "Ошибка");
            }
        }
    }
}
