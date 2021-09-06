
namespace Dinner
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_ingredients = new System.Windows.Forms.TabPage();
            this.groupBox_description = new System.Windows.Forms.GroupBox();
            this.pictureBox_description = new System.Windows.Forms.PictureBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.groupBox_dishList = new System.Windows.Forms.GroupBox();
            this.listBox_dish = new System.Windows.Forms.ListBox();
            this.label_dish = new System.Windows.Forms.Label();
            this.groupBox_ingredientList = new System.Windows.Forms.GroupBox();
            this.button_showDish = new System.Windows.Forms.Button();
            this.checkedListBox_ingredients = new System.Windows.Forms.CheckedListBox();
            this.label_ingredients = new System.Windows.Forms.Label();
            this.tabPage_dish = new System.Windows.Forms.TabPage();
            this.groupBoxD_description = new System.Windows.Forms.GroupBox();
            this.pictureBoxD_description = new System.Windows.Forms.PictureBox();
            this.textBoxD_description = new System.Windows.Forms.TextBox();
            this.labelD_description = new System.Windows.Forms.Label();
            this.groupBoxD_ingredientList = new System.Windows.Forms.GroupBox();
            this.listBoxD_ingredients = new System.Windows.Forms.ListBox();
            this.labelD_ingredients = new System.Windows.Forms.Label();
            this.groupBoxD_dishList = new System.Windows.Forms.GroupBox();
            this.listBoxD_dish = new System.Windows.Forms.ListBox();
            this.labelD_dish = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_ingredients.SuspendLayout();
            this.groupBox_description.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_description)).BeginInit();
            this.groupBox_dishList.SuspendLayout();
            this.groupBox_ingredientList.SuspendLayout();
            this.tabPage_dish.SuspendLayout();
            this.groupBoxD_description.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD_description)).BeginInit();
            this.groupBoxD_ingredientList.SuspendLayout();
            this.groupBoxD_dishList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_ingredients);
            this.tabControl1.Controls.Add(this.tabPage_dish);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_ingredients
            // 
            this.tabPage_ingredients.Controls.Add(this.groupBox_description);
            this.tabPage_ingredients.Controls.Add(this.groupBox_dishList);
            this.tabPage_ingredients.Controls.Add(this.groupBox_ingredientList);
            this.tabPage_ingredients.Location = new System.Drawing.Point(4, 24);
            this.tabPage_ingredients.Name = "tabPage_ingredients";
            this.tabPage_ingredients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ingredients.Size = new System.Drawing.Size(792, 422);
            this.tabPage_ingredients.TabIndex = 0;
            this.tabPage_ingredients.Text = "Ингредиенты";
            this.tabPage_ingredients.UseVisualStyleBackColor = true;
            // 
            // groupBox_description
            // 
            this.groupBox_description.Controls.Add(this.pictureBox_description);
            this.groupBox_description.Controls.Add(this.textBox_description);
            this.groupBox_description.Controls.Add(this.label_description);
            this.groupBox_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_description.Location = new System.Drawing.Point(403, 3);
            this.groupBox_description.Name = "groupBox_description";
            this.groupBox_description.Size = new System.Drawing.Size(386, 416);
            this.groupBox_description.TabIndex = 2;
            this.groupBox_description.TabStop = false;
            // 
            // pictureBox_description
            // 
            this.pictureBox_description.Location = new System.Drawing.Point(57, 42);
            this.pictureBox_description.Name = "pictureBox_description";
            this.pictureBox_description.Size = new System.Drawing.Size(280, 140);
            this.pictureBox_description.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_description.TabIndex = 2;
            this.pictureBox_description.TabStop = false;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(0, 188);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ReadOnly = true;
            this.textBox_description.Size = new System.Drawing.Size(386, 218);
            this.textBox_description.TabIndex = 1;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(150, 19);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(101, 15);
            this.label_description.TabIndex = 0;
            this.label_description.Text = "Описание блюда";
            // 
            // groupBox_dishList
            // 
            this.groupBox_dishList.Controls.Add(this.listBox_dish);
            this.groupBox_dishList.Controls.Add(this.label_dish);
            this.groupBox_dishList.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_dishList.Location = new System.Drawing.Point(203, 3);
            this.groupBox_dishList.Name = "groupBox_dishList";
            this.groupBox_dishList.Size = new System.Drawing.Size(200, 416);
            this.groupBox_dishList.TabIndex = 1;
            this.groupBox_dishList.TabStop = false;
            // 
            // listBox_dish
            // 
            this.listBox_dish.FormattingEnabled = true;
            this.listBox_dish.ItemHeight = 15;
            this.listBox_dish.Location = new System.Drawing.Point(0, 42);
            this.listBox_dish.Name = "listBox_dish";
            this.listBox_dish.Size = new System.Drawing.Size(200, 364);
            this.listBox_dish.TabIndex = 1;
            this.listBox_dish.SelectedIndexChanged += new System.EventHandler(this.listBox_dish_SelectedIndexChanged_1);
            // 
            // label_dish
            // 
            this.label_dish.AutoSize = true;
            this.label_dish.Location = new System.Drawing.Point(79, 19);
            this.label_dish.Name = "label_dish";
            this.label_dish.Size = new System.Drawing.Size(43, 15);
            this.label_dish.TabIndex = 0;
            this.label_dish.Text = "Блюда";
            // 
            // groupBox_ingredientList
            // 
            this.groupBox_ingredientList.Controls.Add(this.button_showDish);
            this.groupBox_ingredientList.Controls.Add(this.checkedListBox_ingredients);
            this.groupBox_ingredientList.Controls.Add(this.label_ingredients);
            this.groupBox_ingredientList.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_ingredientList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_ingredientList.Location = new System.Drawing.Point(3, 3);
            this.groupBox_ingredientList.Name = "groupBox_ingredientList";
            this.groupBox_ingredientList.Size = new System.Drawing.Size(200, 416);
            this.groupBox_ingredientList.TabIndex = 0;
            this.groupBox_ingredientList.TabStop = false;
            // 
            // button_showDish
            // 
            this.button_showDish.Location = new System.Drawing.Point(4, 383);
            this.button_showDish.Name = "button_showDish";
            this.button_showDish.Size = new System.Drawing.Size(190, 23);
            this.button_showDish.TabIndex = 2;
            this.button_showDish.Text = "Показать блюда";
            this.button_showDish.UseVisualStyleBackColor = true;
            this.button_showDish.Click += new System.EventHandler(this.button_showDish_Click);
            // 
            // checkedListBox_ingredients
            // 
            this.checkedListBox_ingredients.FormattingEnabled = true;
            this.checkedListBox_ingredients.Location = new System.Drawing.Point(-3, 42);
            this.checkedListBox_ingredients.Name = "checkedListBox_ingredients";
            this.checkedListBox_ingredients.Size = new System.Drawing.Size(203, 328);
            this.checkedListBox_ingredients.TabIndex = 1;
            // 
            // label_ingredients
            // 
            this.label_ingredients.AutoSize = true;
            this.label_ingredients.Location = new System.Drawing.Point(59, 19);
            this.label_ingredients.Name = "label_ingredients";
            this.label_ingredients.Size = new System.Drawing.Size(81, 15);
            this.label_ingredients.TabIndex = 0;
            this.label_ingredients.Text = "Ингредиенты";
            this.label_ingredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_dish
            // 
            this.tabPage_dish.Controls.Add(this.groupBoxD_description);
            this.tabPage_dish.Controls.Add(this.groupBoxD_ingredientList);
            this.tabPage_dish.Controls.Add(this.groupBoxD_dishList);
            this.tabPage_dish.Location = new System.Drawing.Point(4, 24);
            this.tabPage_dish.Name = "tabPage_dish";
            this.tabPage_dish.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_dish.Size = new System.Drawing.Size(792, 422);
            this.tabPage_dish.TabIndex = 1;
            this.tabPage_dish.Text = "Блюда";
            this.tabPage_dish.UseVisualStyleBackColor = true;
            // 
            // groupBoxD_description
            // 
            this.groupBoxD_description.Controls.Add(this.pictureBoxD_description);
            this.groupBoxD_description.Controls.Add(this.textBoxD_description);
            this.groupBoxD_description.Controls.Add(this.labelD_description);
            this.groupBoxD_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxD_description.Location = new System.Drawing.Point(403, 3);
            this.groupBoxD_description.Name = "groupBoxD_description";
            this.groupBoxD_description.Size = new System.Drawing.Size(386, 416);
            this.groupBoxD_description.TabIndex = 2;
            this.groupBoxD_description.TabStop = false;
            // 
            // pictureBoxD_description
            // 
            this.pictureBoxD_description.Location = new System.Drawing.Point(57, 42);
            this.pictureBoxD_description.Name = "pictureBoxD_description";
            this.pictureBoxD_description.Size = new System.Drawing.Size(280, 140);
            this.pictureBoxD_description.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxD_description.TabIndex = 2;
            this.pictureBoxD_description.TabStop = false;
            // 
            // textBoxD_description
            // 
            this.textBoxD_description.Location = new System.Drawing.Point(0, 188);
            this.textBoxD_description.Multiline = true;
            this.textBoxD_description.Name = "textBoxD_description";
            this.textBoxD_description.Size = new System.Drawing.Size(386, 218);
            this.textBoxD_description.TabIndex = 1;
            // 
            // labelD_description
            // 
            this.labelD_description.AutoSize = true;
            this.labelD_description.Location = new System.Drawing.Point(150, 19);
            this.labelD_description.Name = "labelD_description";
            this.labelD_description.Size = new System.Drawing.Size(101, 15);
            this.labelD_description.TabIndex = 0;
            this.labelD_description.Text = "Описание блюда";
            this.labelD_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxD_ingredientList
            // 
            this.groupBoxD_ingredientList.Controls.Add(this.listBoxD_ingredients);
            this.groupBoxD_ingredientList.Controls.Add(this.labelD_ingredients);
            this.groupBoxD_ingredientList.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxD_ingredientList.Location = new System.Drawing.Point(203, 3);
            this.groupBoxD_ingredientList.Name = "groupBoxD_ingredientList";
            this.groupBoxD_ingredientList.Size = new System.Drawing.Size(200, 416);
            this.groupBoxD_ingredientList.TabIndex = 1;
            this.groupBoxD_ingredientList.TabStop = false;
            // 
            // listBoxD_ingredients
            // 
            this.listBoxD_ingredients.FormattingEnabled = true;
            this.listBoxD_ingredients.ItemHeight = 15;
            this.listBoxD_ingredients.Location = new System.Drawing.Point(0, 42);
            this.listBoxD_ingredients.Name = "listBoxD_ingredients";
            this.listBoxD_ingredients.Size = new System.Drawing.Size(200, 364);
            this.listBoxD_ingredients.TabIndex = 1;
            // 
            // labelD_ingredients
            // 
            this.labelD_ingredients.AutoSize = true;
            this.labelD_ingredients.Location = new System.Drawing.Point(63, 19);
            this.labelD_ingredients.Name = "labelD_ingredients";
            this.labelD_ingredients.Size = new System.Drawing.Size(81, 15);
            this.labelD_ingredients.TabIndex = 0;
            this.labelD_ingredients.Text = "Ингредиенты";
            this.labelD_ingredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelD_ingredients.Click += new System.EventHandler(this.labelD_ingredients_Click);
            // 
            // groupBoxD_dishList
            // 
            this.groupBoxD_dishList.Controls.Add(this.listBoxD_dish);
            this.groupBoxD_dishList.Controls.Add(this.labelD_dish);
            this.groupBoxD_dishList.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxD_dishList.Location = new System.Drawing.Point(3, 3);
            this.groupBoxD_dishList.Name = "groupBoxD_dishList";
            this.groupBoxD_dishList.Size = new System.Drawing.Size(200, 416);
            this.groupBoxD_dishList.TabIndex = 0;
            this.groupBoxD_dishList.TabStop = false;
            // 
            // listBoxD_dish
            // 
            this.listBoxD_dish.FormattingEnabled = true;
            this.listBoxD_dish.ItemHeight = 15;
            this.listBoxD_dish.Location = new System.Drawing.Point(0, 42);
            this.listBoxD_dish.Name = "listBoxD_dish";
            this.listBoxD_dish.Size = new System.Drawing.Size(200, 364);
            this.listBoxD_dish.TabIndex = 1;
            this.listBoxD_dish.SelectedIndexChanged += new System.EventHandler(this.listBoxD_dish_SelectedIndexChanged);
            // 
            // labelD_dish
            // 
            this.labelD_dish.AutoSize = true;
            this.labelD_dish.Location = new System.Drawing.Point(75, 19);
            this.labelD_dish.Name = "labelD_dish";
            this.labelD_dish.Size = new System.Drawing.Size(43, 15);
            this.labelD_dish.TabIndex = 0;
            this.labelD_dish.Text = "Блюда";
            this.labelD_dish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_ingredients.ResumeLayout(false);
            this.groupBox_description.ResumeLayout(false);
            this.groupBox_description.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_description)).EndInit();
            this.groupBox_dishList.ResumeLayout(false);
            this.groupBox_dishList.PerformLayout();
            this.groupBox_ingredientList.ResumeLayout(false);
            this.groupBox_ingredientList.PerformLayout();
            this.tabPage_dish.ResumeLayout(false);
            this.groupBoxD_description.ResumeLayout(false);
            this.groupBoxD_description.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD_description)).EndInit();
            this.groupBoxD_ingredientList.ResumeLayout(false);
            this.groupBoxD_ingredientList.PerformLayout();
            this.groupBoxD_dishList.ResumeLayout(false);
            this.groupBoxD_dishList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_ingredients;
        private System.Windows.Forms.GroupBox groupBox_description;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.GroupBox groupBox_dishList;
        private System.Windows.Forms.ListBox listBox_dish;
        private System.Windows.Forms.Label label_dish;
        private System.Windows.Forms.GroupBox groupBox_ingredientList;
        private System.Windows.Forms.Button button_showDish;
        private System.Windows.Forms.CheckedListBox checkedListBox_ingredients;
        private System.Windows.Forms.Label label_ingredients;
        private System.Windows.Forms.TabPage tabPage_dish;
        private System.Windows.Forms.GroupBox groupBoxD_description;
        private System.Windows.Forms.Label labelD_description;
        private System.Windows.Forms.GroupBox groupBoxD_ingredientList;
        private System.Windows.Forms.Label labelD_ingredients;
        private System.Windows.Forms.GroupBox groupBoxD_dishList;
        private System.Windows.Forms.ListBox listBoxD_dish;
        private System.Windows.Forms.Label labelD_dish;
        public System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBoxD_description;
        private System.Windows.Forms.ListBox listBoxD_ingredients;
        private System.Windows.Forms.PictureBox pictureBoxD_description;
        private System.Windows.Forms.PictureBox pictureBox_description;
    }
}

