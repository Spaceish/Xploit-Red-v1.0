namespace Exploit_Template_with_WRDAPI
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.inputScript = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnInject = new System.Windows.Forms.Button();
            this.btnBtools = new System.Windows.Forms.Button();
            this.inputTPTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTPTo = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.txtIsInjected = new System.Windows.Forms.Label();
            this.InjectedChecker = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lua Executor";
            // 
            // inputScript
            // 
            this.inputScript.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputScript.Location = new System.Drawing.Point(31, 155);
            this.inputScript.Margin = new System.Windows.Forms.Padding(7);
            this.inputScript.Name = "inputScript";
            this.inputScript.Size = new System.Drawing.Size(842, 654);
            this.inputScript.TabIndex = 1;
            this.inputScript.Text = "--paste your script here\nprint(\"Hello from WRD API!\")";
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.Black;
            this.btnExecute.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(252, 828);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(7);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(378, 90);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // btnInject
            // 
            this.btnInject.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInject.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInject.Location = new System.Drawing.Point(917, 28);
            this.btnInject.Margin = new System.Windows.Forms.Padding(7);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(781, 116);
            this.btnInject.TabIndex = 3;
            this.btnInject.Text = "Attach";
            this.btnInject.UseVisualStyleBackColor = false;
            this.btnInject.Click += new System.EventHandler(this.BtnInject_Click);
            // 
            // btnBtools
            // 
            this.btnBtools.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBtools.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBtools.ForeColor = System.Drawing.Color.White;
            this.btnBtools.Location = new System.Drawing.Point(1325, 349);
            this.btnBtools.Margin = new System.Windows.Forms.Padding(7);
            this.btnBtools.Name = "btnBtools";
            this.btnBtools.Size = new System.Drawing.Size(373, 97);
            this.btnBtools.TabIndex = 4;
            this.btnBtools.Text = "BTools";
            this.btnBtools.UseVisualStyleBackColor = false;
            this.btnBtools.Click += new System.EventHandler(this.BtnBtools_Click);
            // 
            // inputTPTo
            // 
            this.inputTPTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputTPTo.Font = new System.Drawing.Font("Arial", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTPTo.ForeColor = System.Drawing.Color.Red;
            this.inputTPTo.Location = new System.Drawing.Point(1070, 709);
            this.inputTPTo.Margin = new System.Windows.Forms.Padding(7);
            this.inputTPTo.Name = "inputTPTo";
            this.inputTPTo.Size = new System.Drawing.Size(365, 57);
            this.inputTPTo.TabIndex = 5;
            this.inputTPTo.Text = "PlrUsername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(887, 709);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "TP To:";
            // 
            // btnTPTo
            // 
            this.btnTPTo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTPTo.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTPTo.Location = new System.Drawing.Point(1477, 687);
            this.btnTPTo.Margin = new System.Windows.Forms.Padding(7);
            this.btnTPTo.Name = "btnTPTo";
            this.btnTPTo.Size = new System.Drawing.Size(209, 97);
            this.btnTPTo.TabIndex = 7;
            this.btnTPTo.Text = "Go";
            this.btnTPTo.UseVisualStyleBackColor = false;
            this.btnTPTo.Click += new System.EventHandler(this.BtnTPTo_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpeed.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeed.ForeColor = System.Drawing.Color.White;
            this.btnSpeed.Location = new System.Drawing.Point(917, 349);
            this.btnSpeed.Margin = new System.Windows.Forms.Padding(7);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(394, 97);
            this.btnSpeed.TabIndex = 8;
            this.btnSpeed.Text = "Fast Walk";
            this.btnSpeed.UseVisualStyleBackColor = false;
            this.btnSpeed.Click += new System.EventHandler(this.BtnSpeed_Click);
            // 
            // txtIsInjected
            // 
            this.txtIsInjected.AutoSize = true;
            this.txtIsInjected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsInjected.Location = new System.Drawing.Point(1114, 155);
            this.txtIsInjected.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtIsInjected.Name = "txtIsInjected";
            this.txtIsInjected.Size = new System.Drawing.Size(369, 55);
            this.txtIsInjected.TabIndex = 9;
            this.txtIsInjected.Text = "Is Injected: false";
            // 
            // InjectedChecker
            // 
            this.InjectedChecker.Enabled = true;
            this.InjectedChecker.Interval = 3000;
            this.InjectedChecker.Tick += new System.EventHandler(this.InjectedChecker_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(917, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 97);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fly";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(1325, 478);
            this.button2.Margin = new System.Windows.Forms.Padding(7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 97);
            this.button2.TabIndex = 11;
            this.button2.Text = "UnFly";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(917, 598);
            this.button3.Margin = new System.Windows.Forms.Padding(7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 97);
            this.button3.TabIndex = 12;
            this.button3.Text = "Jump Power";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1727, 939);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtIsInjected);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.btnTPTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTPTo);
            this.Controls.Add(this.btnBtools);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.inputScript);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Xploit Red 1.0v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox inputScript;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.Button btnBtools;
        private System.Windows.Forms.TextBox inputTPTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTPTo;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Label txtIsInjected;
        private System.Windows.Forms.Timer InjectedChecker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

