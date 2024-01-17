namespace NOteTakingApp
{
    partial class NoteTaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.noteBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Label();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.loadBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(376, 93);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(369, 321);
            this.noteBox.TabIndex = 0;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(376, 35);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(369, 27);
            this.titleBox.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(376, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(369, 25);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title:";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Note
            // 
            this.Note.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Note.Location = new System.Drawing.Point(376, 65);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(369, 25);
            this.Note.TabIndex = 3;
            this.Note.Text = "Note:";
            this.Note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previousNotes
            // 
            this.previousNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previousNotes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.Location = new System.Drawing.Point(12, 12);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.RowHeadersWidth = 51;
            this.previousNotes.RowTemplate.Height = 29;
            this.previousNotes.Size = new System.Drawing.Size(300, 343);
            this.previousNotes.TabIndex = 4;
            this.previousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellDoubleClick);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.Plum;
            this.loadBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadBtn.Location = new System.Drawing.Point(12, 407);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(140, 40);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Plum;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(12, 361);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(140, 40);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Plum;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(172, 361);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(140, 40);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newNote
            // 
            this.newNote.BackColor = System.Drawing.Color.Plum;
            this.newNote.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newNote.Location = new System.Drawing.Point(172, 407);
            this.newNote.Name = "newNote";
            this.newNote.Size = new System.Drawing.Size(140, 40);
            this.newNote.TabIndex = 8;
            this.newNote.Text = "New";
            this.newNote.UseVisualStyleBackColor = false;
            this.newNote.Click += new System.EventHandler(this.newNote_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newNote);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.noteBox);
            this.Name = "NoteTaker";
            this.Text = "Note Taker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox noteBox;
        private TextBox titleBox;
        private Label Title;
        private Label Note;
        private DataGridView previousNotes;
        private Button loadBtn;
        private Button deleteBtn;
        private Button saveBtn;
        private Button newNote;
    }
}