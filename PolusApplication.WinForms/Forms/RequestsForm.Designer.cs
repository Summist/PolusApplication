namespace PolusApplication.WinForms.Forms;

partial class RequestsForm
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
        dataGridView = new DataGridView();
        buttonBack = new Button();
        buttonEditRequest = new Button();
        searchedTextBox = new TextBox();
        buttonSearch = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        SuspendLayout();
        // 
        // title
        // 
        title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        title.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
        title.Location = new Point(12, 9);
        title.Name = "title";
        title.Size = new Size(680, 49);
        title.TabIndex = 0;
        title.Text = "Просмотр заявок";
        title.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // dataGridView
        // 
        dataGridView.AllowUserToAddRows = false;
        dataGridView.AllowUserToDeleteRows = false;
        dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView.Location = new Point(12, 96);
        dataGridView.Name = "dataGridView";
        dataGridView.ReadOnly = true;
        dataGridView.RowTemplate.Height = 25;
        dataGridView.Size = new Size(680, 232);
        dataGridView.TabIndex = 1;
        dataGridView.CellClick += DataGridView_CellClick;
        // 
        // buttonBack
        // 
        buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonBack.Location = new Point(569, 334);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(123, 35);
        buttonBack.TabIndex = 2;
        buttonBack.Text = "Назад";
        buttonBack.UseVisualStyleBackColor = true;
        buttonBack.Click += ButtonBack_Click;
        // 
        // buttonEditRequest
        // 
        buttonEditRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        buttonEditRequest.Location = new Point(12, 334);
        buttonEditRequest.Name = "buttonEditRequest";
        buttonEditRequest.Size = new Size(123, 35);
        buttonEditRequest.TabIndex = 3;
        buttonEditRequest.Text = "Редактировать";
        buttonEditRequest.UseVisualStyleBackColor = true;
        buttonEditRequest.Click += ButtonEditRequest_Click;
        // 
        // searchedTextBox
        // 
        searchedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        searchedTextBox.Location = new Point(444, 65);
        searchedTextBox.Name = "searchedTextBox";
        searchedTextBox.Size = new Size(155, 23);
        searchedTextBox.TabIndex = 4;
        // 
        // buttonSearch
        // 
        buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonSearch.Location = new Point(605, 61);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Size = new Size(87, 29);
        buttonSearch.TabIndex = 5;
        buttonSearch.Text = "Найти";
        buttonSearch.UseVisualStyleBackColor = true;
        buttonSearch.Click += ButtonSearch_Click;
        // 
        // RequestsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(704, 381);
        Controls.Add(buttonSearch);
        Controls.Add(searchedTextBox);
        Controls.Add(buttonEditRequest);
        Controls.Add(buttonBack);
        Controls.Add(dataGridView);
        Controls.Add(title);
        MinimumSize = new Size(720, 420);
        Name = "RequestsForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ООО \"Полюс\"";
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label title;
    private DataGridView dataGridView;
    private Button buttonBack;
    private Button buttonEditRequest;
    private TextBox searchedTextBox;
    private Button buttonSearch;
}