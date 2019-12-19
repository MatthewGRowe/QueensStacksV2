namespace Queens
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.lstCode = new System.Windows.Forms.ListBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.pnlAddMult = new System.Windows.Forms.Panel();
            this.lblAddMult = new System.Windows.Forms.Label();
            this.pnlPushPop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPush = new System.Windows.Forms.Label();
            this.pnlDUP_BRZ = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBRNZ = new System.Windows.Forms.Button();
            this.btnDup = new System.Windows.Forms.Button();
            this.pnlBeep = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.brnBeep = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.lstStack = new System.Windows.Forms.ListBox();
            this.pnlAddMult.SuspendLayout();
            this.pnlPushPop.SuspendLayout();
            this.pnlDUP_BRZ.SuspendLayout();
            this.pnlBeep.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(504, 252);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(111, 84);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteSelected.BackgroundImage")));
            this.btnDeleteSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelected.Location = new System.Drawing.Point(647, 44);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(111, 92);
            this.btnDeleteSelected.TabIndex = 1;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.BtnDeleteSelected_Click);
            // 
            // lstCode
            // 
            this.lstCode.FormattingEnabled = true;
            this.lstCode.Location = new System.Drawing.Point(479, 44);
            this.lstCode.Name = "lstCode";
            this.lstCode.Size = new System.Drawing.Size(162, 199);
            this.lstCode.TabIndex = 2;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(475, 21);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(153, 20);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Your Code So Far";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(783, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Stack Contents";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(244, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.Red;
            this.btnMult.Location = new System.Drawing.Point(244, 56);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(84, 31);
            this.btnMult.TabIndex = 6;
            this.btnMult.Text = "MULT";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // btnPush
            // 
            this.btnPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.Location = new System.Drawing.Point(244, 21);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(84, 31);
            this.btnPush.TabIndex = 7;
            this.btnPush.Text = "PUSH";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.BtnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.Location = new System.Drawing.Point(244, 65);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(84, 31);
            this.btnPop.TabIndex = 8;
            this.btnPop.Text = "POP";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.BtnPop_Click);
            // 
            // pnlAddMult
            // 
            this.pnlAddMult.Controls.Add(this.lblAddMult);
            this.pnlAddMult.Controls.Add(this.btnMult);
            this.pnlAddMult.Controls.Add(this.btnAdd);
            this.pnlAddMult.Location = new System.Drawing.Point(28, 140);
            this.pnlAddMult.Name = "pnlAddMult";
            this.pnlAddMult.Size = new System.Drawing.Size(353, 98);
            this.pnlAddMult.TabIndex = 9;
            // 
            // lblAddMult
            // 
            this.lblAddMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMult.Location = new System.Drawing.Point(16, 12);
            this.lblAddMult.Name = "lblAddMult";
            this.lblAddMult.Size = new System.Drawing.Size(222, 75);
            this.lblAddMult.TabIndex = 10;
            this.lblAddMult.Text = "These will pop the top 2 values off the stack, perform the operation and push the" +
    " result back on.";
            // 
            // pnlPushPop
            // 
            this.pnlPushPop.Controls.Add(this.label2);
            this.pnlPushPop.Controls.Add(this.lblPush);
            this.pnlPushPop.Controls.Add(this.btnPop);
            this.pnlPushPop.Controls.Add(this.btnPush);
            this.pnlPushPop.Location = new System.Drawing.Point(28, 11);
            this.pnlPushPop.Name = "pnlPushPop";
            this.pnlPushPop.Size = new System.Drawing.Size(352, 108);
            this.pnlPushPop.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "POP value off the stack.";
            // 
            // lblPush
            // 
            this.lblPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPush.Location = new System.Drawing.Point(16, 21);
            this.lblPush.Name = "lblPush";
            this.lblPush.Size = new System.Drawing.Size(222, 31);
            this.lblPush.TabIndex = 9;
            this.lblPush.Text = "Push INT value onto the stack.";
            // 
            // pnlDUP_BRZ
            // 
            this.pnlDUP_BRZ.Controls.Add(this.label4);
            this.pnlDUP_BRZ.Controls.Add(this.label3);
            this.pnlDUP_BRZ.Controls.Add(this.btnBRNZ);
            this.pnlDUP_BRZ.Controls.Add(this.btnDup);
            this.pnlDUP_BRZ.Location = new System.Drawing.Point(28, 249);
            this.pnlDUP_BRZ.Name = "pnlDUP_BRZ";
            this.pnlDUP_BRZ.Size = new System.Drawing.Size(353, 125);
            this.pnlDUP_BRZ.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 54);
            this.label4.TabIndex = 12;
            this.label4.Text = "Branch to instruction (shown in CODE not stack) if the top of the stack is NOT ze" +
    "ro, line number required!";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 50);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duplicate value at the top of the stack";
            // 
            // btnBRNZ
            // 
            this.btnBRNZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBRNZ.ForeColor = System.Drawing.Color.Red;
            this.btnBRNZ.Location = new System.Drawing.Point(244, 56);
            this.btnBRNZ.Name = "btnBRNZ";
            this.btnBRNZ.Size = new System.Drawing.Size(84, 31);
            this.btnBRNZ.TabIndex = 6;
            this.btnBRNZ.Text = "BRNZ";
            this.btnBRNZ.UseVisualStyleBackColor = true;
            this.btnBRNZ.Click += new System.EventHandler(this.BtnBRNZ_Click);
            // 
            // btnDup
            // 
            this.btnDup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDup.ForeColor = System.Drawing.Color.Red;
            this.btnDup.Location = new System.Drawing.Point(244, 19);
            this.btnDup.Name = "btnDup";
            this.btnDup.Size = new System.Drawing.Size(84, 31);
            this.btnDup.TabIndex = 5;
            this.btnDup.Text = "DUP";
            this.btnDup.UseVisualStyleBackColor = true;
            this.btnDup.Click += new System.EventHandler(this.BtnDup_Click);
            // 
            // pnlBeep
            // 
            this.pnlBeep.Controls.Add(this.label5);
            this.pnlBeep.Controls.Add(this.brnBeep);
            this.pnlBeep.Location = new System.Drawing.Point(27, 380);
            this.pnlBeep.Name = "pnlBeep";
            this.pnlBeep.Size = new System.Drawing.Size(353, 58);
            this.pnlBeep.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Make the computer beep";
            // 
            // brnBeep
            // 
            this.brnBeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnBeep.ForeColor = System.Drawing.Color.Red;
            this.brnBeep.Location = new System.Drawing.Point(244, 19);
            this.brnBeep.Name = "brnBeep";
            this.brnBeep.Size = new System.Drawing.Size(84, 31);
            this.brnBeep.TabIndex = 5;
            this.brnBeep.Text = "BEEP";
            this.brnBeep.UseVisualStyleBackColor = true;
            this.brnBeep.Click += new System.EventHandler(this.BrnBeep_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.BackgroundImage")));
            this.btnDeleteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAll.Location = new System.Drawing.Point(647, 152);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(111, 84);
            this.btnDeleteAll.TabIndex = 12;
            this.btnDeleteAll.Text = "Delete ALL";
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.BtnDeleteAll_Click);
            // 
            // lstStack
            // 
            this.lstStack.FormattingEnabled = true;
            this.lstStack.Location = new System.Drawing.Point(787, 44);
            this.lstStack.Name = "lstStack";
            this.lstStack.Size = new System.Drawing.Size(162, 199);
            this.lstStack.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 547);
            this.Controls.Add(this.lstStack);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.pnlBeep);
            this.Controls.Add(this.pnlDUP_BRZ);
            this.Controls.Add(this.pnlPushPop);
            this.Controls.Add(this.pnlAddMult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lstCode);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAddMult.ResumeLayout(false);
            this.pnlPushPop.ResumeLayout(false);
            this.pnlDUP_BRZ.ResumeLayout(false);
            this.pnlBeep.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.ListBox lstCode;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Panel pnlAddMult;
        private System.Windows.Forms.Panel pnlPushPop;
        private System.Windows.Forms.Label lblPush;
        private System.Windows.Forms.Label lblAddMult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDUP_BRZ;
        private System.Windows.Forms.Button btnBRNZ;
        private System.Windows.Forms.Button btnDup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBeep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brnBeep;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.ListBox lstStack;
    }
}

