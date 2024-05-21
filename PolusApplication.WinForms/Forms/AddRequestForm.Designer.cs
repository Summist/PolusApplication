namespace PolusApplication.WinForms.Forms;

partial class AddRequestForm
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
        orgTechTypeComboBox = new ComboBox();
        orgTechTypeLabel = new Label();
        modelLabel = new Label();
        modelTextBox = new TextBox();
        descriptionTextBox = new TextBox();
        descriptionLabel = new Label();
        buttonAddRequest = new Button();
        buttonBack = new Button();
        SuspendLayout();
        // 
        // title
        // 
        title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        title.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
        title.Location = new Point(12, 9);
        title.Name = "title";
        title.Size = new Size(680, 52);
        title.TabIndex = 0;
        title.Text = "Добавление заявки";
        title.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // orgTechTypeComboBox
        // 
        orgTechTypeComboBox.FormattingEnabled = true;
        orgTechTypeComboBox.Location = new Point(12, 99);
        orgTechTypeComboBox.Name = "orgTechTypeComboBox";
        orgTechTypeComboBox.Size = new Size(205, 23);
        orgTechTypeComboBox.TabIndex = 1;
        // 
        // orgTechTypeLabel
        // 
        orgTechTypeLabel.AutoSize = true;
        orgTechTypeLabel.Location = new Point(12, 81);
        orgTechTypeLabel.Name = "orgTechTypeLabel";
        orgTechTypeLabel.Size = new Size(83, 15);
        orgTechTypeLabel.TabIndex = 2;
        orgTechTypeLabel.Text = "Типы техники";
        // 
        // modelLabel
        // 
        modelLabel.AutoSize = true;
        modelLabel.Location = new Point(27, 143);
        modelLabel.Name = "modelLabel";
        modelLabel.Size = new Size(96, 15);
        modelLabel.TabIndex = 3;
        modelLabel.Text = "Модель техники";
        // 
        // modelTextBox
        // 
        modelTextBox.Location = new Point(17, 182);
        modelTextBox.Name = "modelTextBox";
        modelTextBox.Size = new Size(100, 23);
        modelTextBox.TabIndex = 4;
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Location = new Point(17, 280);
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(100, 23);
        descriptionTextBox.TabIndex = 6;
        // 
        // descriptionLabel
        // 
        descriptionLabel.AutoSize = true;
        descriptionLabel.Location = new Point(27, 241);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(124, 15);
        descriptionLabel.TabIndex = 5;
        descriptionLabel.Text = "Описание проблемы";
        // 
        // buttonAddRequest
        // 
        buttonAddRequest.Anchor = AnchorStyles.Right;
        buttonAddRequest.Location = new Point(585, 191);
        buttonAddRequest.Name = "buttonAddRequest";
        buttonAddRequest.Size = new Size(107, 47);
        buttonAddRequest.TabIndex = 7;
        buttonAddRequest.Text = "Добавить заявку";
        buttonAddRequest.UseVisualStyleBackColor = true;
        buttonAddRequest.Click += ButtonAddRequest_Click;
        // 
        // buttonBack
        // 
        buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonBack.Location = new Point(576, 316);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(116, 53);
        buttonBack.TabIndex = 8;
        buttonBack.Text = "Назад";
        buttonBack.UseVisualStyleBackColor = true;
        buttonBack.Click += ButtonBack_Click;
        // 
        // AddRequestForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(704, 381);
        Controls.Add(buttonBack);
        Controls.Add(buttonAddRequest);
        Controls.Add(descriptionTextBox);
        Controls.Add(descriptionLabel);
        Controls.Add(modelTextBox);
        Controls.Add(modelLabel);
        Controls.Add(orgTechTypeLabel);
        Controls.Add(orgTechTypeComboBox);
        Controls.Add(title);
        MinimumSize = new Size(720, 420);
        Name = "AddRequestForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ООО \"Полюс\"";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label title;
    private ComboBox orgTechTypeComboBox;
    private Label orgTechTypeLabel;
    private Label modelLabel;
    private TextBox modelTextBox;
    private TextBox descriptionTextBox;
    private Label descriptionLabel;
    private Button buttonAddRequest;
    private Button buttonBack;
}