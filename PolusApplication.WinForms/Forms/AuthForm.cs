using Microsoft.EntityFrameworkCore;
using PolusApplication.WinForms.Database;
using PolusApplication.WinForms.Informations;
using System.Net;

namespace PolusApplication.WinForms.Forms;

public partial class AuthForm : Form
{
    public AuthForm()
    {
        InitializeComponent();
    }

    private void ButtonEntry_Click(object sender, EventArgs e)
    {
        string login = loginTextBox.Text;
        string password = passwordTextBox.Text; 

        if (string.IsNullOrWhiteSpace(login))
        {
            MessageBox.Show("Поле для логина обязательно для заполнения", "Уведомление");
            return;
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Поле для пароля обязательно для заполнения", "Уведомление");
            return;
        }

        Authorization(login, password);

        var navigationForm = new NavigationForm();

        Hide();
        navigationForm.ShowDialog();
        Show();

        loginTextBox.Text = string.Empty;
        passwordTextBox.Text = string.Empty;
    }

    public void Authorization(string login, string password)
    {
        using (var dbContext = new ApplicationDbContext())
        {
            var user = dbContext.Users
                .AsNoTracking()
                .FirstOrDefault(user => user.Login == login && user.Password == password);

            if (user is null)
            {
                MessageBox.Show("Неверный логин или пароль", "Уведомление");
                return;
            }

            SessionInfo.UserId = user.Id;
            MessageBox.Show($"Вы вошли в систему как: {user.FullName}", "Уведомление");
        }
    }
}
