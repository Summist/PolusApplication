using Microsoft.EntityFrameworkCore;
using PolusApplication.WinForms.Database;
using PolusApplication.WinForms.Database.Entities;
using PolusApplication.WinForms.Informations;

namespace PolusApplication.WinForms.Forms;

public partial class AddRequestForm : Form
{
    public AddRequestForm()
    {
        InitializeComponent();
        InitializeOrgTechTypes();
    }

    private void InitializeOrgTechTypes()
    {
        using (var dbContext = new ApplicationDbContext())
        {
            var types = dbContext.OrgTechTypes
                .AsNoTracking()
                .Select(x => x.Name)
                .ToArray();

            orgTechTypeComboBox.Items.AddRange(types);
        }
    }

    private void ButtonBack_Click(object sender, EventArgs e) => Close();

    private void ButtonAddRequest_Click(object sender, EventArgs e)
    {
        string model = modelTextBox.Text;
        string description = descriptionTextBox.Text;

        if (string.IsNullOrWhiteSpace(orgTechTypeComboBox.Text))
        {
            MessageBox.Show("Вы не выбрали тип техники", "Уведомление");
            return;
        }

        if (string.IsNullOrWhiteSpace(model))
        {
            MessageBox.Show("Вы не заполнили модель техники", "Уведомление");
            return;
        }

        if (string.IsNullOrWhiteSpace(description))
        {
            MessageBox.Show("Вы не заполнили описание проблемы", "Уведомление");
            return;
        }

        using (var dbContext = new ApplicationDbContext())
        {
            var orgTechType = dbContext.OrgTechTypes.FirstOrDefault(x => x.Name == orgTechTypeComboBox.Text);

            if (orgTechType is null)
            {
                MessageBox.Show("Ошибка:(", "Уведомление");
                return;
            }

            var request = new Request
            {
                StartDate = DateTime.Now,
                ClientId = SessionInfo.UserId,
                OrgTechModel = model,
                ProblemDescription = description,
                StatusId = 3,
                OrgTechTypeId = orgTechType.Id
            };

            try
            {
                dbContext.Add(request);
                dbContext.SaveChanges();

                MessageBox.Show("Заявка успешно добавлена", "Уведомление");

                orgTechTypeComboBox.Text = string.Empty;
                modelTextBox.Text = string.Empty;
                descriptionTextBox.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Не удалось добавить заявку:(", "Уведомление");
            }
        }
    }
}
