namespace PolusApplication.WinForms.Forms;

partial class NavigationForm
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
        buttonBack = new Button();
        buttonAddRequest = new Button();
        buttonRequests = new Button();
        buttonComments = new Button();
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
        title.Text = "Навигация по программе";
        title.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // buttonBack
        // 
        buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonBack.Location = new Point(557, 313);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(135, 56);
        buttonBack.TabIndex = 1;
        buttonBack.Text = "Назад";
        buttonBack.UseVisualStyleBackColor = true;
        buttonBack.Click += ButtonBack_Click;
        // 
        // buttonAddRequest
        // 
        buttonAddRequest.Anchor = AnchorStyles.Top;
        buttonAddRequest.Location = new Point(22, 126);
        buttonAddRequest.Name = "buttonAddRequest";
        buttonAddRequest.Size = new Size(117, 68);
        buttonAddRequest.TabIndex = 2;
        buttonAddRequest.Text = "Добавить заявку";
        buttonAddRequest.UseVisualStyleBackColor = true;
        buttonAddRequest.Click += ButtonAddRequest_Click;
        // 
        // buttonRequests
        // 
        buttonRequests.Anchor = AnchorStyles.Top;
        buttonRequests.Location = new Point(278, 126);
        buttonRequests.Name = "buttonRequests";
        buttonRequests.Size = new Size(117, 68);
        buttonRequests.TabIndex = 4;
        buttonRequests.Text = "Просмотр заявок";
        buttonRequests.UseVisualStyleBackColor = true;
        buttonRequests.Click += ButtonRequests_Click;
        // 
        // buttonComments
        // 
        buttonComments.Anchor = AnchorStyles.Top;
        buttonComments.Location = new Point(535, 126);
        buttonComments.Name = "buttonComments";
        buttonComments.Size = new Size(117, 68);
        buttonComments.TabIndex = 5;
        buttonComments.Text = "Отзывы";
        buttonComments.UseVisualStyleBackColor = true;
        buttonComments.Click += ButtonComments_Click;
        // 
        // NavigationForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(704, 381);
        Controls.Add(buttonComments);
        Controls.Add(buttonRequests);
        Controls.Add(buttonAddRequest);
        Controls.Add(buttonBack);
        Controls.Add(title);
        MinimumSize = new Size(720, 420);
        Name = "NavigationForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ООО \"Полюс\"";
        ResumeLayout(false);
    }

    #endregion

    private Label title;
    private Button buttonBack;
    private Button buttonAddRequest;
    private Button buttonRequests;
    private Button buttonComments;
}