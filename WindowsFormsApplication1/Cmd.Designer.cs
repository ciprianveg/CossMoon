namespace WindowsFormsApplication1
{
    partial class Cmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cmd));
            this.outputField = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputField = new System.Windows.Forms.TextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.balanceButton = new System.Windows.Forms.Button();
            this.pairDepthButton = new System.Windows.Forms.Button();
            this.orderHistoryButton = new System.Windows.Forms.Button();
            this.checkMarketParirsButton = new System.Windows.Forms.Button();
            this.marketTickerDataButton = new System.Windows.Forms.Button();
            this.allTickerDataButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputField
            // 
            resources.ApplyResources(this.outputField, "outputField");
            this.outputField.Name = "outputField";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputField
            // 
            resources.ApplyResources(this.inputField, "inputField");
            this.inputField.Name = "inputField";
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.YellowGreen;
            resources.ApplyResources(this.buyButton, "buyButton");
            this.buyButton.Name = "buyButton";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buy_Click);
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.sellButton, "sellButton");
            this.sellButton.Name = "sellButton";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // balanceButton
            // 
            resources.ApplyResources(this.balanceButton, "balanceButton");
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.UseVisualStyleBackColor = true;
            this.balanceButton.Click += new System.EventHandler(this.balance_Click);
            // 
            // pairDepthButton
            // 
            resources.ApplyResources(this.pairDepthButton, "pairDepthButton");
            this.pairDepthButton.Name = "pairDepthButton";
            this.pairDepthButton.UseVisualStyleBackColor = true;
            this.pairDepthButton.Click += new System.EventHandler(this.pairDepthButton_Click);
            // 
            // orderHistoryButton
            // 
            resources.ApplyResources(this.orderHistoryButton, "orderHistoryButton");
            this.orderHistoryButton.Name = "orderHistoryButton";
            this.orderHistoryButton.UseVisualStyleBackColor = true;
            this.orderHistoryButton.Click += new System.EventHandler(this.orderHistoryButton_Click);
            // 
            // checkMarketParirsButton
            // 
            resources.ApplyResources(this.checkMarketParirsButton, "checkMarketParirsButton");
            this.checkMarketParirsButton.Name = "checkMarketParirsButton";
            this.checkMarketParirsButton.UseVisualStyleBackColor = true;
            this.checkMarketParirsButton.Click += new System.EventHandler(this.checkMarketParirsButton_Click);
            // 
            // marketTickerDataButton
            // 
            resources.ApplyResources(this.marketTickerDataButton, "marketTickerDataButton");
            this.marketTickerDataButton.Name = "marketTickerDataButton";
            this.marketTickerDataButton.UseVisualStyleBackColor = true;
            this.marketTickerDataButton.Click += new System.EventHandler(this.marketTickerDataButton_Click);
            // 
            // allTickerDataButton
            // 
            resources.ApplyResources(this.allTickerDataButton, "allTickerDataButton");
            this.allTickerDataButton.Name = "allTickerDataButton";
            this.allTickerDataButton.UseVisualStyleBackColor = true;
            this.allTickerDataButton.Click += new System.EventHandler(this.allTickerDataButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // helpButton
            // 
            resources.ApplyResources(this.helpButton, "helpButton");
            this.helpButton.Name = "helpButton";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Cmd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.allTickerDataButton);
            this.Controls.Add(this.marketTickerDataButton);
            this.Controls.Add(this.checkMarketParirsButton);
            this.Controls.Add(this.orderHistoryButton);
            this.Controls.Add(this.pairDepthButton);
            this.Controls.Add(this.balanceButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputField);
            this.Name = "Cmd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button balanceButton;
        private System.Windows.Forms.Button pairDepthButton;
        private System.Windows.Forms.Button orderHistoryButton;
        private System.Windows.Forms.Button checkMarketParirsButton;
        private System.Windows.Forms.Button marketTickerDataButton;
        private System.Windows.Forms.Button allTickerDataButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label1;
    }
}

