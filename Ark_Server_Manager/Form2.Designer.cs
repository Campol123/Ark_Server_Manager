
namespace Ark_Server_Manager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_server_location = new System.Windows.Forms.TextBox();
            this.button_set_server_location = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox_app_location = new System.Windows.Forms.TextBox();
            this.button_set_app_location = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(218, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Location of Ark Server:";
            // 
            // textBox_server_location
            // 
            this.textBox_server_location.BackColor = System.Drawing.Color.White;
            this.textBox_server_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_server_location.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_server_location.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_server_location.Location = new System.Drawing.Point(236, 39);
            this.textBox_server_location.Name = "textBox_server_location";
            this.textBox_server_location.Size = new System.Drawing.Size(374, 21);
            this.textBox_server_location.TabIndex = 1;
            // 
            // button_set_server_location
            // 
            this.button_set_server_location.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_set_server_location.Location = new System.Drawing.Point(616, 37);
            this.button_set_server_location.Name = "button_set_server_location";
            this.button_set_server_location.Size = new System.Drawing.Size(75, 26);
            this.button_set_server_location.TabIndex = 3;
            this.button_set_server_location.Text = "SET";
            this.button_set_server_location.UseVisualStyleBackColor = true;
            this.button_set_server_location.Click += new System.EventHandler(this.button_set_server_location_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(12, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(303, 25);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Location of other app (Optional):";
            // 
            // textBox_app_location
            // 
            this.textBox_app_location.BackColor = System.Drawing.Color.White;
            this.textBox_app_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_app_location.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_app_location.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_app_location.Location = new System.Drawing.Point(321, 74);
            this.textBox_app_location.Name = "textBox_app_location";
            this.textBox_app_location.Size = new System.Drawing.Size(289, 21);
            this.textBox_app_location.TabIndex = 5;
            // 
            // button_set_app_location
            // 
            this.button_set_app_location.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_set_app_location.Location = new System.Drawing.Point(617, 74);
            this.button_set_app_location.Name = "button_set_app_location";
            this.button_set_app_location.Size = new System.Drawing.Size(75, 26);
            this.button_set_app_location.TabIndex = 6;
            this.button_set_app_location.Text = "SET";
            this.button_set_app_location.UseVisualStyleBackColor = true;
            this.button_set_app_location.Click += new System.EventHandler(this.button_set_app_location_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.button_set_app_location);
            this.Controls.Add(this.textBox_app_location);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_set_server_location);
            this.Controls.Add(this.textBox_server_location);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Ark Server GUI Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_server_location;
        private System.Windows.Forms.Button button_set_server_location;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox_app_location;
        private System.Windows.Forms.Button button_set_app_location;
    }
}