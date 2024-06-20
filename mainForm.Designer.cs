namespace Lab06
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.playerNum = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerCnt = new System.Windows.Forms.Label();
            this.range = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ansNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.answer = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnReady = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.conversation = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.message = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAutoPlaySingleTurn = new System.Windows.Forms.Button();
            this.btnAutoplayWholeGame = new System.Windows.Forms.Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Answer:";
            // 
            // playerNum
            // 
            this.playerNum.BackColor = System.Drawing.SystemColors.Control;
            this.playerNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.playerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNum.Location = new System.Drawing.Point(0, 0);
            this.playerNum.Name = "playerNum";
            this.playerNum.Size = new System.Drawing.Size(628, 26);
            this.playerNum.TabIndex = 7;
            this.playerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.timerCnt);
            this.panel1.Controls.Add(this.range);
            this.panel1.Controls.Add(this.btnAutoPlaySingleTurn);
            this.panel1.Controls.Add(this.btnAutoplayWholeGame);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.answer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 109);
            this.panel1.TabIndex = 17;
            // 
            // timerCnt
            // 
            this.timerCnt.Location = new System.Drawing.Point(148, 37);
            this.timerCnt.Name = "timerCnt";
            this.timerCnt.Size = new System.Drawing.Size(30, 30);
            this.timerCnt.TabIndex = 19;
            this.timerCnt.Text = "X";
            this.timerCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // range
            // 
            this.range.BackColor = System.Drawing.Color.Transparent;
            this.range.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range.Location = new System.Drawing.Point(248, 3);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(44, 22);
            this.range.TabIndex = 23;
            this.range.Text = "range";
            // 
            // ansNumber
            // 
            this.ansNumber.BackColor = System.Drawing.Color.Transparent;
            this.ansNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansNumber.Location = new System.Drawing.Point(12, 11);
            this.ansNumber.Name = "ansNumber";
            this.ansNumber.Size = new System.Drawing.Size(3, 2);
            this.ansNumber.TabIndex = 22;
            this.ansNumber.Click += new System.EventHandler(this.ansNumber_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số cần đoán nằm trong khoảng:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(348, 70);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 30);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // answer
            // 
            this.answer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer.DefaultText = "";
            this.answer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.answer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.answer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.answer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.answer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.answer.Location = new System.Drawing.Point(127, 70);
            this.answer.Name = "answer";
            this.answer.PasswordChar = '\0';
            this.answer.PlaceholderText = "";
            this.answer.SelectedText = "";
            this.answer.Size = new System.Drawing.Size(200, 30);
            this.answer.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnReady);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.conversation);
            this.panel2.Controls.Add(this.ansNumber);
            this.panel2.Controls.Add(this.message);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 298);
            this.panel2.TabIndex = 18;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(490, 193);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 45);
            this.btnClear.TabIndex = 10;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(490, 120);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(98, 45);
            this.btnReady.TabIndex = 9;
            this.btnReady.Values.Text = "Ready";
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnSend
            // 
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.White;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = global::Lab06.Properties.Resources.Email_Send;
            this.btnSend.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSend.Location = new System.Drawing.Point(507, 256);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 28);
            this.btnSend.TabIndex = 8;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // conversation
            // 
            this.conversation.AcceptsTab = true;
            this.conversation.Location = new System.Drawing.Point(12, 39);
            this.conversation.Name = "conversation";
            this.conversation.Size = new System.Drawing.Size(462, 211);
            this.conversation.TabIndex = 7;
            this.conversation.Text = "";
            // 
            // message
            // 
            this.message.BorderRadius = 10;
            this.message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.message.DefaultText = "";
            this.message.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.message.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.message.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.message.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.message.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.message.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.message.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.message.Location = new System.Drawing.Point(12, 256);
            this.message.Name = "message";
            this.message.PasswordChar = '\0';
            this.message.PlaceholderText = "";
            this.message.SelectedText = "";
            this.message.Size = new System.Drawing.Size(462, 28);
            this.message.TabIndex = 6;
            // 
            // btnAutoPlaySingleTurn
            // 
            this.btnAutoPlaySingleTurn.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutoPlaySingleTurn.Enabled = false;
            this.btnAutoPlaySingleTurn.FlatAppearance.BorderSize = 0;
            this.btnAutoPlaySingleTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoPlaySingleTurn.ForeColor = System.Drawing.Color.Black;
            this.btnAutoPlaySingleTurn.Location = new System.Drawing.Point(490, 56);
            this.btnAutoPlaySingleTurn.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutoPlaySingleTurn.Name = "btnAutoPlaySingleTurn";
            this.btnAutoPlaySingleTurn.Size = new System.Drawing.Size(117, 46);
            this.btnAutoPlaySingleTurn.TabIndex = 9;
            this.btnAutoPlaySingleTurn.TabStop = false;
            this.btnAutoPlaySingleTurn.Text = "Don\'t have answer\r\nAuto select answer";
            this.btnAutoPlaySingleTurn.UseVisualStyleBackColor = false;
            this.btnAutoPlaySingleTurn.Click += new System.EventHandler(this.autoTurn_Click);
            // 
            // btnAutoplayWholeGame
            // 
            this.btnAutoplayWholeGame.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutoplayWholeGame.Enabled = false;
            this.btnAutoplayWholeGame.FlatAppearance.BorderSize = 0;
            this.btnAutoplayWholeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoplayWholeGame.ForeColor = System.Drawing.Color.Black;
            this.btnAutoplayWholeGame.Location = new System.Drawing.Point(490, 8);
            this.btnAutoplayWholeGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutoplayWholeGame.Name = "btnAutoplayWholeGame";
            this.btnAutoplayWholeGame.Size = new System.Drawing.Size(117, 46);
            this.btnAutoplayWholeGame.TabIndex = 10;
            this.btnAutoplayWholeGame.TabStop = false;
            this.btnAutoplayWholeGame.Text = "Autoplay";
            this.btnAutoplayWholeGame.UseVisualStyleBackColor = false;
            this.btnAutoplayWholeGame.Click += new System.EventHandler(this.autoAllGame_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(15, 42);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(116, 22);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Thời gian còn lại";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(628, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerNum);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerNum;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox answer;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox conversation;
        private Guna.UI2.WinForms.Guna2TextBox message;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReady;
        private System.Windows.Forms.Label timerCnt;
        private Guna.UI2.WinForms.Guna2HtmlLabel ansNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private Guna.UI2.WinForms.Guna2HtmlLabel range;
        private System.Windows.Forms.Button btnAutoPlaySingleTurn;
        private System.Windows.Forms.Button btnAutoplayWholeGame;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}