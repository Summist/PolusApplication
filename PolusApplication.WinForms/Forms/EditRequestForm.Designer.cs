namespace PolusApplication.WinForms.Forms;

partial class EditRequestForm
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
        descriptionLabel = new Label();
        descriptionTextBox = new TextBox();
        buttonBack = new Button();
        buttonSaveEdit = new Button();
        SuspendLayout();
        // 
        // title
        // 
        title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        title.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
        title.Location = new Point(12, 9);
        title.Name = "title";
        title.Size = new Size(680, 53);
        title.TabIndex = 0;
        title.Text = "Редактировать заявку";
        title.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // descriptionLabel
        // 
        descriptionLabel.AutoSize = true;
        descriptionLabel.Location = new Point(12, 84);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(124, 15);
        descriptionLabel.TabIndex = 1;
        descriptionLabel.Text = "Описание проблемы";
        // 
        // descriptionTextBox
        // 
        descriptionTextBox.Location = new Point(12, 102);
        descriptionTextBox.Multiline = true;
        descriptionTextBox.Name = "descriptionTextBox";
        descriptionTextBox.Size = new Size(322, 115);
        descriptionTextBox.TabIndex = 2;
        // 
        // buttonBack
        // 
        buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonBack.Location = new Point(569, 300);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(123, 69);
        buttonBack.TabIndex = 3;
        buttonBack.Text = "Назад";
        buttonBack.UseVisualStyleBackColor = true;
        buttonBack.Click += ButtonBack_Click;
        // 
        // buttonSaveEdit
        // 
        buttonSaveEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        buttonSaveEdit.Location = new Point(12, 300);
        buttonSaveEdit.Name = "buttonSaveEdit";
        buttonSaveEdit.Size = new Size(177, 69);
        buttonSaveEdit.TabIndex = 4;
        buttonSaveEdit.Text = "Сохранить изменения";
        buttonSaveEdit.UseVisualStyleBackColor = true;
        buttonSaveEdit.Click += ButtonSaveEdit_Click;
        // 
        // EditRequestForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(704, 381);
        Controls.Add(buttonSaveEdit);
        Controls.Add(buttonBack);
        Controls.Add(descriptionTextBox);
        Controls.Add(descriptionLabel);
        Controls.Add(title);
        MinimumSize = new Size(720, 420);
        Name = "EditRequestForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ООО \"Полюс\"";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label title;
    private Label descriptionLabel;
    private TextBox descriptionTextBox;
    private Button buttonBack;
    private Button buttonSaveEdit;
}