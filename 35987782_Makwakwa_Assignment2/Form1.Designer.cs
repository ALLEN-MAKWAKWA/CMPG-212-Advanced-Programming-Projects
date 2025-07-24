
namespace _35987782_Makwakwa_Assignment2
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bMeal = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bSortByPrice = new System.Windows.Forms.Button();
            this.bAbove150 = new System.Windows.Forms.Button();
            this.bMealWiltPrice = new System.Windows.Forms.Button();
            this.bShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(399, 327);
            this.dataGridView.TabIndex = 0;
            // 
            // bMeal
            // 
            this.bMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMeal.Location = new System.Drawing.Point(148, 356);
            this.bMeal.Name = "bMeal";
            this.bMeal.Size = new System.Drawing.Size(129, 23);
            this.bMeal.TabIndex = 5;
            this.bMeal.Text = "Meal and Price";
            this.bMeal.UseVisualStyleBackColor = true;
            this.bMeal.Click += new System.EventHandler(this.bMeal_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Red;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(283, 391);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(129, 23);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bSortByPrice
            // 
            this.bSortByPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSortByPrice.Location = new System.Drawing.Point(148, 391);
            this.bSortByPrice.Name = "bSortByPrice";
            this.bSortByPrice.Size = new System.Drawing.Size(129, 23);
            this.bSortByPrice.TabIndex = 7;
            this.bSortByPrice.Text = "Sort By Price";
            this.bSortByPrice.UseVisualStyleBackColor = true;
            this.bSortByPrice.Click += new System.EventHandler(this.bSortByPrice_Click);
            // 
            // bAbove150
            // 
            this.bAbove150.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAbove150.Location = new System.Drawing.Point(13, 391);
            this.bAbove150.Name = "bAbove150";
            this.bAbove150.Size = new System.Drawing.Size(129, 23);
            this.bAbove150.TabIndex = 8;
            this.bAbove150.Text = "Above 150";
            this.bAbove150.UseVisualStyleBackColor = true;
            this.bAbove150.Click += new System.EventHandler(this.bAbove150_Click);
            // 
            // bMealWiltPrice
            // 
            this.bMealWiltPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMealWiltPrice.Location = new System.Drawing.Point(283, 356);
            this.bMealWiltPrice.Name = "bMealWiltPrice";
            this.bMealWiltPrice.Size = new System.Drawing.Size(129, 23);
            this.bMealWiltPrice.TabIndex = 9;
            this.bMealWiltPrice.Text = "Meal With Chips";
            this.bMealWiltPrice.UseVisualStyleBackColor = true;
            this.bMealWiltPrice.Click += new System.EventHandler(this.bMealWiltPrice_Click);
            // 
            // bShowAll
            // 
            this.bShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowAll.Location = new System.Drawing.Point(13, 356);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(129, 23);
            this.bShowAll.TabIndex = 10;
            this.bShowAll.Text = "Show All";
            this.bShowAll.UseVisualStyleBackColor = true;
            this.bShowAll.Click += new System.EventHandler(this.bShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 426);
            this.Controls.Add(this.bShowAll);
            this.Controls.Add(this.bMealWiltPrice);
            this.Controls.Add(this.bAbove150);
            this.Controls.Add(this.bSortByPrice);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bMeal);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bMeal;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bSortByPrice;
        private System.Windows.Forms.Button bAbove150;
        private System.Windows.Forms.Button bMealWiltPrice;
        private System.Windows.Forms.Button bShowAll;
    }
}

