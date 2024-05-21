namespace PolusApplication.WinForms.Forms;

partial class CommentsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        title = new Label();
        QRCode = new PictureBox();
        buttonBack = new Button();
        ((System.ComponentModel.ISupportInitialize)QRCode).BeginInit();
        SuspendLayout();
        // 
        // title
        // 
        title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        title.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
        title.Location = new Point(12, 9);
        title.Name = "title";
        title.Size = new Size(680, 62);
        title.TabIndex = 0;
        title.Text = "Отзывы";
        title.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // QRCode
        // 
        QRCode.Location = new Point(239, 74);
        QRCode.Name = "QRCode";
        QRCode.Size = new Size(250, 250);
        QRCode.TabIndex = 1;
        QRCode.TabStop = false;
        // 
        // buttonBack
        // 
        buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonBack.Location = new Point(587, 315);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(105, 54);
        buttonBack.TabIndex = 2;
        buttonBack.Text = "Назад";
        buttonBack.UseVisualStyleBackColor = true;
        buttonBack.Click += ButtonBack_Click;
        // 
        // CommentsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(704, 381);
        Controls.Add(buttonBack);
        Controls.Add(QRCode);
        Controls.Add(title);
        MinimumSize = new Size(720, 420);
        Name = "CommentsForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ООО \"Полюс\"";
        ((System.ComponentModel.ISupportInitialize)QRCode).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label title;
    private PictureBox QRCode;
    private Button buttonBack;
}