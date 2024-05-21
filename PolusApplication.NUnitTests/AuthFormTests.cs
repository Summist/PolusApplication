using PolusApplication.WinForms.Forms;
using PolusApplication.WinForms.Informations;

namespace PolusApplication.NUnitTests;

internal class AuthFormTests
{
    [Test]
    public void Authorization_ShouldSetSessionInfo_UserId()
    {
        var authForm = new AuthForm();

        authForm.Authorization("login3", "pass3");

        int expected = 3;

        Assert.AreEqual(expected, SessionInfo.UserId);
    }
}
