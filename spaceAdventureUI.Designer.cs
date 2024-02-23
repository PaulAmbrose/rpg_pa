
namespace rpg_pa
{
    partial class spaceAdventureUI
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
            this.forwards = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.backwards = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.Oxygen = new System.Windows.Forms.Label();
            this.oxygen_Level_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // forwards
            // 
            this.forwards.Location = new System.Drawing.Point(239, 104);
            this.forwards.Name = "forwards";
            this.forwards.Size = new System.Drawing.Size(244, 74);
            this.forwards.TabIndex = 0;
            this.forwards.Text = "forwards";
            this.forwards.UseVisualStyleBackColor = true;
            this.forwards.Click += new System.EventHandler(this.forwards_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(33, 184);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(244, 74);
            this.left.TabIndex = 1;
            this.left.Text = "left";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // backwards
            // 
            this.backwards.Location = new System.Drawing.Point(239, 264);
            this.backwards.Name = "backwards";
            this.backwards.Size = new System.Drawing.Size(244, 74);
            this.backwards.TabIndex = 2;
            this.backwards.Text = "backwards";
            this.backwards.UseVisualStyleBackColor = true;
            this.backwards.Click += new System.EventHandler(this.backwards_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(447, 184);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(244, 74);
            this.right.TabIndex = 3;
            this.right.Text = "right";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(34, 11);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(685, 79);
            this.output.TabIndex = 4;
            // 
            // Oxygen
            // 
            this.Oxygen.AutoSize = true;
            this.Oxygen.Location = new System.Drawing.Point(23, 286);
            this.Oxygen.Name = "Oxygen";
            this.Oxygen.Size = new System.Drawing.Size(75, 13);
            this.Oxygen.TabIndex = 5;
            this.Oxygen.Text = "Oxygen_Level";
            // 
            // oxygen_Level_Box
            // 
            this.oxygen_Level_Box.Location = new System.Drawing.Point(107, 283);
            this.oxygen_Level_Box.Name = "oxygen_Level_Box";
            this.oxygen_Level_Box.Size = new System.Drawing.Size(40, 20);
            this.oxygen_Level_Box.TabIndex = 7;
            this.oxygen_Level_Box.TextChanged += new System.EventHandler(this.oxygen_Level_Box_TextChanged);
            // 
            // spaceAdventureUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 370);
            this.Controls.Add(this.oxygen_Level_Box);
            this.Controls.Add(this.Oxygen);
            this.Controls.Add(this.output);
            this.Controls.Add(this.right);
            this.Controls.Add(this.backwards);
            this.Controls.Add(this.left);
            this.Controls.Add(this.forwards);
            this.Name = "spaceAdventureUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forwards;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button backwards;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label Oxygen;
        private System.Windows.Forms.TextBox oxygen_Level_Box;
    }
}

