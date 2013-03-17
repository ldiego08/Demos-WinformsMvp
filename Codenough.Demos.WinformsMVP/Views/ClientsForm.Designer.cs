namespace Codenough.Demos.WinFormsMVP.Views {
    partial class ClientsForm {
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
	    if (disposing && (components != null)) {
		components.Dispose();
	    }
	    base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.clientDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.clientAgeTextBox = new System.Windows.Forms.TextBox();
            this.clientAgeLabel = new System.Windows.Forms.Label();
            this.clientGenderLabel = new System.Windows.Forms.Label();
            this.clientGenderTextBox = new System.Windows.Forms.TextBox();
            this.clientEmailTextBox = new System.Windows.Forms.TextBox();
            this.clientEmailLabel = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.clientDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsListBox
            // 
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.Location = new System.Drawing.Point(12, 12);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(352, 173);
            this.clientsListBox.TabIndex = 0;
            // 
            // clientDetailsGroupBox
            // 
            this.clientDetailsGroupBox.Controls.Add(this.clientAgeTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.clientAgeLabel);
            this.clientDetailsGroupBox.Controls.Add(this.clientGenderLabel);
            this.clientDetailsGroupBox.Controls.Add(this.clientGenderTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.clientEmailTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.clientEmailLabel);
            this.clientDetailsGroupBox.Controls.Add(this.clientNameTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.clientNameLabel);
            this.clientDetailsGroupBox.Location = new System.Drawing.Point(12, 191);
            this.clientDetailsGroupBox.Name = "clientDetailsGroupBox";
            this.clientDetailsGroupBox.Size = new System.Drawing.Size(352, 131);
            this.clientDetailsGroupBox.TabIndex = 1;
            this.clientDetailsGroupBox.TabStop = false;
            this.clientDetailsGroupBox.Text = "Details";
            // 
            // clientAgeTextBox
            // 
            this.clientAgeTextBox.Location = new System.Drawing.Point(80, 97);
            this.clientAgeTextBox.Name = "clientAgeTextBox";
            this.clientAgeTextBox.Size = new System.Drawing.Size(89, 20);
            this.clientAgeTextBox.TabIndex = 7;
            // 
            // clientAgeLabel
            // 
            this.clientAgeLabel.AutoSize = true;
            this.clientAgeLabel.Location = new System.Drawing.Point(6, 100);
            this.clientAgeLabel.Name = "clientAgeLabel";
            this.clientAgeLabel.Size = new System.Drawing.Size(26, 13);
            this.clientAgeLabel.TabIndex = 6;
            this.clientAgeLabel.Text = "Age";
            // 
            // clientGenderLabel
            // 
            this.clientGenderLabel.AutoSize = true;
            this.clientGenderLabel.Location = new System.Drawing.Point(6, 74);
            this.clientGenderLabel.Name = "clientGenderLabel";
            this.clientGenderLabel.Size = new System.Drawing.Size(42, 13);
            this.clientGenderLabel.TabIndex = 5;
            this.clientGenderLabel.Text = "Gender";
            // 
            // clientGenderTextBox
            // 
            this.clientGenderTextBox.Location = new System.Drawing.Point(80, 71);
            this.clientGenderTextBox.Name = "clientGenderTextBox";
            this.clientGenderTextBox.Size = new System.Drawing.Size(89, 20);
            this.clientGenderTextBox.TabIndex = 4;
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.Location = new System.Drawing.Point(80, 45);
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(162, 20);
            this.clientEmailTextBox.TabIndex = 3;
            // 
            // clientEmailLabel
            // 
            this.clientEmailLabel.AutoSize = true;
            this.clientEmailLabel.Location = new System.Drawing.Point(6, 48);
            this.clientEmailLabel.Name = "clientEmailLabel";
            this.clientEmailLabel.Size = new System.Drawing.Size(35, 13);
            this.clientEmailLabel.TabIndex = 2;
            this.clientEmailLabel.Text = "E-mail";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(80, 19);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(266, 20);
            this.clientNameTextBox.TabIndex = 1;
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(6, 22);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(35, 13);
            this.clientNameLabel.TabIndex = 0;
            this.clientNameLabel.Text = "Name";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(289, 328);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 362);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clientDetailsGroupBox);
            this.Controls.Add(this.clientsListBox);
            this.Name = "ClientsForm";
            this.Text = "Clients";
            this.clientDetailsGroupBox.ResumeLayout(false);
            this.clientDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

	}

	#endregion

    private System.Windows.Forms.ListBox clientsListBox;
    private System.Windows.Forms.GroupBox clientDetailsGroupBox;
    private System.Windows.Forms.Label clientGenderLabel;
    private System.Windows.Forms.TextBox clientGenderTextBox;
    private System.Windows.Forms.TextBox clientEmailTextBox;
    private System.Windows.Forms.Label clientEmailLabel;
    private System.Windows.Forms.TextBox clientNameTextBox;
    private System.Windows.Forms.Label clientNameLabel;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.TextBox clientAgeTextBox;
    private System.Windows.Forms.Label clientAgeLabel;
    }
}

