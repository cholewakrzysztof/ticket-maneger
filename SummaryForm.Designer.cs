
namespace TicketManager
{
    partial class SummaryForm
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
            this.label_totalIncome = new System.Windows.Forms.Label();
            this.label_totalVisits = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_cash = new System.Windows.Forms.Label();
            this.label_card = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_totalIncome
            // 
            this.label_totalIncome.AutoSize = true;
            this.label_totalIncome.Location = new System.Drawing.Point(12, 37);
            this.label_totalIncome.Name = "label_totalIncome";
            this.label_totalIncome.Size = new System.Drawing.Size(140, 15);
            this.label_totalIncome.TabIndex = 0;
            this.label_totalIncome.Text = "Całkowity zysk z biletów: ";
            // 
            // label_totalVisits
            // 
            this.label_totalVisits.AutoSize = true;
            this.label_totalVisits.Location = new System.Drawing.Point(12, 109);
            this.label_totalVisits.Name = "label_totalVisits";
            this.label_totalVisits.Size = new System.Drawing.Size(123, 15);
            this.label_totalVisits.TabIndex = 1;
            this.label_totalVisits.Text = "Całkowita ilość gości: ";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(100, 9);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(35, 15);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "DATA";
            // 
            // label_cash
            // 
            this.label_cash.AutoSize = true;
            this.label_cash.Location = new System.Drawing.Point(13, 61);
            this.label_cash.Name = "label_cash";
            this.label_cash.Size = new System.Drawing.Size(69, 15);
            this.label_cash.TabIndex = 4;
            this.label_cash.Text = "GOTÓWKA: ";
            // 
            // label_card
            // 
            this.label_card.AutoSize = true;
            this.label_card.Location = new System.Drawing.Point(13, 85);
            this.label_card.Name = "label_card";
            this.label_card.Size = new System.Drawing.Size(47, 15);
            this.label_card.TabIndex = 5;
            this.label_card.Text = "KARTA: ";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 140);
            this.Controls.Add(this.label_card);
            this.Controls.Add(this.label_cash);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_totalVisits);
            this.Controls.Add(this.label_totalIncome);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_totalIncome;
        private System.Windows.Forms.Label label_totalVisits;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_cash;
        private System.Windows.Forms.Label label_card;
    }
}