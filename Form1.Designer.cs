
namespace Project_07
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
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxCherry = new System.Windows.Forms.CheckBox();
            this.checkBoxNuts = new System.Windows.Forms.CheckBox();
            this.checkBoxSprinkles = new System.Windows.Forms.CheckBox();
            this.groupBoxFlavor = new System.Windows.Forms.GroupBox();
            this.radioButtonStraw = new System.Windows.Forms.RadioButton();
            this.radioButtonVan = new System.Windows.Forms.RadioButton();
            this.radioButtonChoc = new System.Windows.Forms.RadioButton();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxTotTrans = new System.Windows.Forms.ListBox();
            this.buttonTotalTrans = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxTransSummary = new System.Windows.Forms.TextBox();
            this.groupBoxSelect.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.groupBoxFlavor.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.textBox2);
            this.groupBoxSelect.Controls.Add(this.buttonClear);
            this.groupBoxSelect.Controls.Add(this.listBoxOrders);
            this.groupBoxSelect.Controls.Add(this.buttonAdd);
            this.groupBoxSelect.Controls.Add(this.groupBoxToppings);
            this.groupBoxSelect.Controls.Add(this.groupBoxFlavor);
            this.groupBoxSelect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(674, 242);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Select Ice Cream Cone";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(483, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 13);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Ice Cream Cone Orders";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(483, 170);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(162, 52);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear Ice Cream Cone Orders";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.Location = new System.Drawing.Point(483, 43);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(162, 108);
            this.listBoxOrders.TabIndex = 3;
            this.listBoxOrders.Tag = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 170);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(417, 52);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add Ice Cream Cone Order";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxCherry);
            this.groupBoxToppings.Controls.Add(this.checkBoxNuts);
            this.groupBoxToppings.Controls.Add(this.checkBoxSprinkles);
            this.groupBoxToppings.Location = new System.Drawing.Point(251, 43);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(200, 100);
            this.groupBoxToppings.TabIndex = 1;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // checkBoxCherry
            // 
            this.checkBoxCherry.AutoSize = true;
            this.checkBoxCherry.Location = new System.Drawing.Point(7, 68);
            this.checkBoxCherry.Name = "checkBoxCherry";
            this.checkBoxCherry.Size = new System.Drawing.Size(56, 17);
            this.checkBoxCherry.TabIndex = 2;
            this.checkBoxCherry.Text = "Cherry";
            this.checkBoxCherry.UseVisualStyleBackColor = true;
            // 
            // checkBoxNuts
            // 
            this.checkBoxNuts.AutoSize = true;
            this.checkBoxNuts.Location = new System.Drawing.Point(7, 44);
            this.checkBoxNuts.Name = "checkBoxNuts";
            this.checkBoxNuts.Size = new System.Drawing.Size(94, 17);
            this.checkBoxNuts.TabIndex = 1;
            this.checkBoxNuts.Text = "Chopped Nuts";
            this.checkBoxNuts.UseVisualStyleBackColor = true;
            // 
            // checkBoxSprinkles
            // 
            this.checkBoxSprinkles.AutoSize = true;
            this.checkBoxSprinkles.Location = new System.Drawing.Point(7, 20);
            this.checkBoxSprinkles.Name = "checkBoxSprinkles";
            this.checkBoxSprinkles.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSprinkles.TabIndex = 0;
            this.checkBoxSprinkles.Text = "Sprinkles";
            this.checkBoxSprinkles.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlavor
            // 
            this.groupBoxFlavor.Controls.Add(this.radioButtonStraw);
            this.groupBoxFlavor.Controls.Add(this.radioButtonVan);
            this.groupBoxFlavor.Controls.Add(this.radioButtonChoc);
            this.groupBoxFlavor.Location = new System.Drawing.Point(34, 43);
            this.groupBoxFlavor.Name = "groupBoxFlavor";
            this.groupBoxFlavor.Size = new System.Drawing.Size(200, 100);
            this.groupBoxFlavor.TabIndex = 0;
            this.groupBoxFlavor.TabStop = false;
            this.groupBoxFlavor.Text = "Flavor";
            // 
            // radioButtonStraw
            // 
            this.radioButtonStraw.AutoSize = true;
            this.radioButtonStraw.Location = new System.Drawing.Point(7, 68);
            this.radioButtonStraw.Name = "radioButtonStraw";
            this.radioButtonStraw.Size = new System.Drawing.Size(75, 17);
            this.radioButtonStraw.TabIndex = 2;
            this.radioButtonStraw.TabStop = true;
            this.radioButtonStraw.Text = "Strawberry";
            this.radioButtonStraw.UseVisualStyleBackColor = true;
            // 
            // radioButtonVan
            // 
            this.radioButtonVan.AutoSize = true;
            this.radioButtonVan.Location = new System.Drawing.Point(7, 44);
            this.radioButtonVan.Name = "radioButtonVan";
            this.radioButtonVan.Size = new System.Drawing.Size(56, 17);
            this.radioButtonVan.TabIndex = 1;
            this.radioButtonVan.TabStop = true;
            this.radioButtonVan.Text = "Vanilla";
            this.radioButtonVan.UseVisualStyleBackColor = true;
            // 
            // radioButtonChoc
            // 
            this.radioButtonChoc.AutoSize = true;
            this.radioButtonChoc.Location = new System.Drawing.Point(7, 20);
            this.radioButtonChoc.Name = "radioButtonChoc";
            this.radioButtonChoc.Size = new System.Drawing.Size(73, 17);
            this.radioButtonChoc.TabIndex = 0;
            this.radioButtonChoc.TabStop = true;
            this.radioButtonChoc.Text = "Chocolate";
            this.radioButtonChoc.UseVisualStyleBackColor = true;
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.textBox1);
            this.groupBoxSummary.Controls.Add(this.textBoxTotal);
            this.groupBoxSummary.Controls.Add(this.buttonTotal);
            this.groupBoxSummary.Location = new System.Drawing.Point(13, 276);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(672, 70);
            this.groupBoxSummary.TabIndex = 1;
            this.groupBoxSummary.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(393, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Total Price";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(456, 25);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(162, 20);
            this.textBoxTotal.TabIndex = 1;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(14, 16);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(273, 36);
            this.buttonTotal.TabIndex = 0;
            this.buttonTotal.Text = "Total Price";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTransSummary);
            this.groupBox1.Controls.Add(this.buttonTotalTrans);
            this.groupBox1.Controls.Add(this.listBoxTotTrans);
            this.groupBox1.Location = new System.Drawing.Point(710, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 331);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Customer Orders";
            // 
            // listBoxTotTrans
            // 
            this.listBoxTotTrans.FormattingEnabled = true;
            this.listBoxTotTrans.Location = new System.Drawing.Point(17, 19);
            this.listBoxTotTrans.Name = "listBoxTotTrans";
            this.listBoxTotTrans.Size = new System.Drawing.Size(161, 173);
            this.listBoxTotTrans.TabIndex = 0;
            // 
            // buttonTotalTrans
            // 
            this.buttonTotalTrans.Location = new System.Drawing.Point(17, 215);
            this.buttonTotalTrans.Name = "buttonTotalTrans";
            this.buttonTotalTrans.Size = new System.Drawing.Size(161, 41);
            this.buttonTotalTrans.TabIndex = 1;
            this.buttonTotalTrans.Text = "Total Up All Transaction";
            this.buttonTotalTrans.UseVisualStyleBackColor = true;
            this.buttonTotalTrans.Click += new System.EventHandler(this.buttonTotalTrans_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxTransSummary
            // 
            this.textBoxTransSummary.Location = new System.Drawing.Point(17, 286);
            this.textBoxTransSummary.Name = "textBoxTransSummary";
            this.textBoxTransSummary.Size = new System.Drawing.Size(161, 20);
            this.textBoxTransSummary.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.groupBoxSelect);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ice Cream Shop";
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.groupBoxFlavor.ResumeLayout(false);
            this.groupBoxFlavor.PerformLayout();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox checkBoxCherry;
        private System.Windows.Forms.CheckBox checkBoxNuts;
        private System.Windows.Forms.CheckBox checkBoxSprinkles;
        private System.Windows.Forms.GroupBox groupBoxFlavor;
        private System.Windows.Forms.RadioButton radioButtonStraw;
        private System.Windows.Forms.RadioButton radioButtonVan;
        private System.Windows.Forms.RadioButton radioButtonChoc;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTransSummary;
        private System.Windows.Forms.Button buttonTotalTrans;
        private System.Windows.Forms.ListBox listBoxTotTrans;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

