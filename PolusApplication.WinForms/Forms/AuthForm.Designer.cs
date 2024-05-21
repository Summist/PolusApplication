namespace PolusApplication.WinForms.Forms;

partial class AuthForm
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
        loginLabel = new Label();
        passwordLabel = new Label();
        loginTextBox = new TextBox();
        passwordTextBox = new TextBox();
        buttonEntry = new Button();
        SuspendLayout();
        // 
        // title
        // 
        title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        title.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
        title.Location = new Point(12, 9);
        title.Name = "title";
        title.Size = new Size(680, 45);
        title.TabIndex = 0;
        title.Text = "Авторизация";
        title.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // loginLabel
        // 
        loginLabel.AutoSize = true;
        loginLabel.Location = new Point(187, 98);
        loginLabel.Name = "loginLabel";
        loginLabel.Size = new Size(44, 15);
        loginLabel.TabIndex = 1;
        loginLabel.Text = "Логин:";
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new Point(187, 169);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(52, 15);
        passwordLabel.TabIndex = 2;
        passwordLabel.Text = "Пароль:";
        // 
        // loginTextBox
        // 
        loginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        loginTextBox.Location = new Point(187, 116);
        loginTextBox.Name = "loginTextBox";
        loginTextBox.Size = new Size(253, 23);
        loginTextBox.TabIndex = 3;
        // 
        // passwordTextBox
        // 
        passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        passwordTextBox.Location = new Point(187, 187);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.Size = new Size(253, 23);
        passwordTextBox.TabIndex = 4;
        // 
        // buttonEntry
        // 
        buttonEntry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        buttonEntry.Location = new Point(250, 239);
        buttonEntry.Name = "buttonEntry";
        buttonEntry.Size = new Size(126, 56);
        buttonEntry.TabIndex = 5;
        buttonEntry.Text = "Войти";
        buttonEntry.UseVisualStyleBackColor = true;
        buttonEntry.Click += ButtonEntry_Click;
        // 
        // AuthForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(704, 381);
        Controls.Add(buttonEntry);
        Controls.Add(passwordTextBox);
        Controls.Add(loginTextBox);
        Controls.Add(passwordLabel);
        Controls.Add(loginLabel);
        Controls.Add(title);
        MinimumSize = new Size(720, 420);
        Name = "AuthForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ООО \"Полюс\"";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label title;
    private Label loginLabel;
    private Label passwordLabel;
    private TextBox loginTextBox;
    private TextBox passwordTextBox;
    private Button buttonEntry;
}