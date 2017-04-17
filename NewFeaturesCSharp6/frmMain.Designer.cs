namespace NewFeaturesCSharp6
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetterOnly = new System.Windows.Forms.Button();
            this.btnUsingStaticMembers = new System.Windows.Forms.Button();
            this.btnStringInterpolation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# 6.0 adds a lot of useful small features that can clean up your code. ";
            // 
            // btnGetterOnly
            // 
            this.btnGetterOnly.Location = new System.Drawing.Point(15, 40);
            this.btnGetterOnly.Name = "btnGetterOnly";
            this.btnGetterOnly.Size = new System.Drawing.Size(209, 35);
            this.btnGetterOnly.TabIndex = 1;
            this.btnGetterOnly.Text = "Getter-only Property";
            this.btnGetterOnly.UseVisualStyleBackColor = true;
            this.btnGetterOnly.Click += new System.EventHandler(this.btnGetterOnly_Click);
            // 
            // btnUsingStaticMembers
            // 
            this.btnUsingStaticMembers.Location = new System.Drawing.Point(15, 81);
            this.btnUsingStaticMembers.Name = "btnUsingStaticMembers";
            this.btnUsingStaticMembers.Size = new System.Drawing.Size(209, 35);
            this.btnUsingStaticMembers.TabIndex = 2;
            this.btnUsingStaticMembers.Text = "Using Static Members";
            this.btnUsingStaticMembers.UseVisualStyleBackColor = true;
            this.btnUsingStaticMembers.Click += new System.EventHandler(this.btnUsingStaticMembers_Click);
            // 
            // btnStringInterpolation
            // 
            this.btnStringInterpolation.Location = new System.Drawing.Point(15, 122);
            this.btnStringInterpolation.Name = "btnStringInterpolation";
            this.btnStringInterpolation.Size = new System.Drawing.Size(209, 35);
            this.btnStringInterpolation.TabIndex = 3;
            this.btnStringInterpolation.Text = "String Interpolation";
            this.btnStringInterpolation.UseVisualStyleBackColor = true;
            this.btnStringInterpolation.Click += new System.EventHandler(this.btnStringInterpolation_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 406);
            this.Controls.Add(this.btnStringInterpolation);
            this.Controls.Add(this.btnUsingStaticMembers);
            this.Controls.Add(this.btnGetterOnly);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Tag = "New Features in C# 6.0 by Naji El Kotob";
            this.Text = "New Features in C# 6.0 by Naji El Kotob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetterOnly;
        private System.Windows.Forms.Button btnUsingStaticMembers;
        private System.Windows.Forms.Button btnStringInterpolation;
    }
}

