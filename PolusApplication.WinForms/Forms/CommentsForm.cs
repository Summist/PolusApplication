using MessagingToolkit.QRCode.Codec;

namespace PolusApplication.WinForms.Forms;

public partial class CommentsForm : Form
{
    public CommentsForm()
    {
        InitializeComponent();
        InitializeQRCOde();
    }

    private void InitializeQRCOde()
    {
        var encoder = new QRCodeEncoder();
        Bitmap qrcode = encoder.Encode("https://docs.google.com/forms/d/e/1FAIpQLSdhZcExx6LSIXxk0ub55mSu-WIh23WYdGG9HY5EZhLDo7P8eA/viewform?usp=sf_link");
        QRCode.Image = qrcode;
    }

    private void ButtonBack_Click(object sender, EventArgs e) => Close();
}
