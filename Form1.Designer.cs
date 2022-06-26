
namespace TicketManager
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox_tours = new System.Windows.Forms.ListBox();
            this.listBox_tickets = new System.Windows.Forms.ListBox();
            this.button_addTickets = new System.Windows.Forms.Button();
            this.button_deleteTicket = new System.Windows.Forms.Button();
            this.textBox_ticketCount = new System.Windows.Forms.TextBox();
            this.listBox_possibleHours = new System.Windows.Forms.ListBox();
            this.listBox_price = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_freeSpace = new System.Windows.Forms.Label();
            this.button_addTicket = new System.Windows.Forms.Button();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.button_editDescription = new System.Windows.Forms.Button();
            this.label_places = new System.Windows.Forms.Label();
            this.textBox_takePlaces = new System.Windows.Forms.TextBox();
            this.button_genDaySummary = new System.Windows.Forms.Button();
            this.groupBox_buy = new System.Windows.Forms.GroupBox();
            this.button_addBooking = new System.Windows.Forms.Button();
            this.radioButton_card = new System.Windows.Forms.RadioButton();
            this.radioButton_cash = new System.Windows.Forms.RadioButton();
            this.groupBox_day = new System.Windows.Forms.GroupBox();
            this.groupBox_calendar = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_buy.SuspendLayout();
            this.groupBox_day.SuspendLayout();
            this.groupBox_calendar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 16);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox_tours
            // 
            this.listBox_tours.FormattingEnabled = true;
            this.listBox_tours.ItemHeight = 15;
            this.listBox_tours.Location = new System.Drawing.Point(7, 36);
            this.listBox_tours.Name = "listBox_tours";
            this.listBox_tours.Size = new System.Drawing.Size(131, 124);
            this.listBox_tours.TabIndex = 3;
            this.listBox_tours.SelectedIndexChanged += new System.EventHandler(this.listBox_tours_SelectedIndexChanged);
            // 
            // listBox_tickets
            // 
            this.listBox_tickets.FormattingEnabled = true;
            this.listBox_tickets.ItemHeight = 15;
            this.listBox_tickets.Location = new System.Drawing.Point(143, 36);
            this.listBox_tickets.Name = "listBox_tickets";
            this.listBox_tickets.Size = new System.Drawing.Size(181, 124);
            this.listBox_tickets.TabIndex = 7;
            this.listBox_tickets.SelectedIndexChanged += new System.EventHandler(this.listBox_tickets_SelectedIndexChanged);
            // 
            // button_addTickets
            // 
            this.button_addTickets.Location = new System.Drawing.Point(6, 291);
            this.button_addTickets.Name = "button_addTickets";
            this.button_addTickets.Size = new System.Drawing.Size(145, 23);
            this.button_addTickets.TabIndex = 8;
            this.button_addTickets.Text = "DODAJ BILETY";
            this.button_addTickets.UseVisualStyleBackColor = true;
            this.button_addTickets.Click += new System.EventHandler(this.button_addTickets_Click);
            // 
            // button_deleteTicket
            // 
            this.button_deleteTicket.Location = new System.Drawing.Point(225, 163);
            this.button_deleteTicket.Name = "button_deleteTicket";
            this.button_deleteTicket.Size = new System.Drawing.Size(99, 23);
            this.button_deleteTicket.TabIndex = 9;
            this.button_deleteTicket.Text = "USUŃ BILET";
            this.button_deleteTicket.UseVisualStyleBackColor = true;
            this.button_deleteTicket.Click += new System.EventHandler(this.button_deleteTicket_Click);
            // 
            // textBox_ticketCount
            // 
            this.textBox_ticketCount.Location = new System.Drawing.Point(6, 37);
            this.textBox_ticketCount.Name = "textBox_ticketCount";
            this.textBox_ticketCount.Size = new System.Drawing.Size(145, 23);
            this.textBox_ticketCount.TabIndex = 10;
            // 
            // listBox_possibleHours
            // 
            this.listBox_possibleHours.FormattingEnabled = true;
            this.listBox_possibleHours.ItemHeight = 15;
            this.listBox_possibleHours.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.listBox_possibleHours.Location = new System.Drawing.Point(7, 150);
            this.listBox_possibleHours.Name = "listBox_possibleHours";
            this.listBox_possibleHours.Size = new System.Drawing.Size(51, 109);
            this.listBox_possibleHours.TabIndex = 12;
            // 
            // listBox_price
            // 
            this.listBox_price.FormattingEnabled = true;
            this.listBox_price.ItemHeight = 15;
            this.listBox_price.Items.AddRange(new object[] {
            "5 zł",
            "10 zł",
            "12,5 zł",
            "15 zł",
            "20 zł",
            "25 zł",
            "35 zł",
            "50 zł"});
            this.listBox_price.Location = new System.Drawing.Point(94, 150);
            this.listBox_price.Name = "listBox_price";
            this.listBox_price.Size = new System.Drawing.Size(57, 109);
            this.listBox_price.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ILOŚĆ BILETÓW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "CENA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "GODZINA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "GODZINY ZWIEDZANIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "KUPIONE BILETY";
            // 
            // label_freeSpace
            // 
            this.label_freeSpace.AutoSize = true;
            this.label_freeSpace.Location = new System.Drawing.Point(7, 163);
            this.label_freeSpace.Name = "label_freeSpace";
            this.label_freeSpace.Size = new System.Drawing.Size(97, 15);
            this.label_freeSpace.TabIndex = 20;
            this.label_freeSpace.Text = "WOLNE MIEJSCA";
            // 
            // button_addTicket
            // 
            this.button_addTicket.Location = new System.Drawing.Point(6, 320);
            this.button_addTicket.Name = "button_addTicket";
            this.button_addTicket.Size = new System.Drawing.Size(145, 23);
            this.button_addTicket.TabIndex = 21;
            this.button_addTicket.Text = "DODAJ BILET";
            this.button_addTicket.UseVisualStyleBackColor = true;
            this.button_addTicket.Click += new System.EventHandler(this.button_addTicket_Click);
            // 
            // textBox_description
            // 
            this.textBox_description.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_description.Location = new System.Drawing.Point(330, 36);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(98, 124);
            this.textBox_description.TabIndex = 22;
            // 
            // button_editDescription
            // 
            this.button_editDescription.Location = new System.Drawing.Point(330, 164);
            this.button_editDescription.Name = "button_editDescription";
            this.button_editDescription.Size = new System.Drawing.Size(98, 23);
            this.button_editDescription.TabIndex = 23;
            this.button_editDescription.Text = "EDYTUJ OPIS";
            this.button_editDescription.UseVisualStyleBackColor = true;
            this.button_editDescription.Click += new System.EventHandler(this.button_editDescription_Click);
            // 
            // label_places
            // 
            this.label_places.AutoSize = true;
            this.label_places.Location = new System.Drawing.Point(7, 63);
            this.label_places.Name = "label_places";
            this.label_places.Size = new System.Drawing.Size(80, 15);
            this.label_places.TabIndex = 24;
            this.label_places.Text = "ILOŚĆ MIEJSC";
            // 
            // textBox_takePlaces
            // 
            this.textBox_takePlaces.Location = new System.Drawing.Point(7, 81);
            this.textBox_takePlaces.Name = "textBox_takePlaces";
            this.textBox_takePlaces.Size = new System.Drawing.Size(144, 23);
            this.textBox_takePlaces.TabIndex = 25;
            // 
            // button_genDaySummary
            // 
            this.button_genDaySummary.Location = new System.Drawing.Point(293, 16);
            this.button_genDaySummary.Name = "button_genDaySummary";
            this.button_genDaySummary.Size = new System.Drawing.Size(118, 56);
            this.button_genDaySummary.TabIndex = 26;
            this.button_genDaySummary.Text = "GENERUJ PODSUMOWANIE DNIA";
            this.button_genDaySummary.UseVisualStyleBackColor = true;
            this.button_genDaySummary.Click += new System.EventHandler(this.button_genDaySummary_Click);
            // 
            // groupBox_buy
            // 
            this.groupBox_buy.Controls.Add(this.button_addBooking);
            this.groupBox_buy.Controls.Add(this.radioButton_card);
            this.groupBox_buy.Controls.Add(this.radioButton_cash);
            this.groupBox_buy.Controls.Add(this.label_places);
            this.groupBox_buy.Controls.Add(this.textBox_takePlaces);
            this.groupBox_buy.Controls.Add(this.button_addTicket);
            this.groupBox_buy.Controls.Add(this.button_addTickets);
            this.groupBox_buy.Controls.Add(this.textBox_ticketCount);
            this.groupBox_buy.Controls.Add(this.label2);
            this.groupBox_buy.Controls.Add(this.label3);
            this.groupBox_buy.Controls.Add(this.label1);
            this.groupBox_buy.Controls.Add(this.listBox_possibleHours);
            this.groupBox_buy.Controls.Add(this.listBox_price);
            this.groupBox_buy.Location = new System.Drawing.Point(12, 53);
            this.groupBox_buy.Name = "groupBox_buy";
            this.groupBox_buy.Size = new System.Drawing.Size(164, 372);
            this.groupBox_buy.TabIndex = 27;
            this.groupBox_buy.TabStop = false;
            // 
            // button_addBooking
            // 
            this.button_addBooking.Location = new System.Drawing.Point(6, 262);
            this.button_addBooking.Name = "button_addBooking";
            this.button_addBooking.Size = new System.Drawing.Size(145, 23);
            this.button_addBooking.TabIndex = 26;
            this.button_addBooking.Text = "REZERWACJA";
            this.button_addBooking.UseVisualStyleBackColor = true;
            this.button_addBooking.Click += new System.EventHandler(this.button_addBooking_Click);
            // 
            // radioButton_card
            // 
            this.radioButton_card.AutoSize = true;
            this.radioButton_card.Location = new System.Drawing.Point(94, 110);
            this.radioButton_card.Name = "radioButton_card";
            this.radioButton_card.Size = new System.Drawing.Size(59, 19);
            this.radioButton_card.TabIndex = 1;
            this.radioButton_card.TabStop = true;
            this.radioButton_card.Text = "KARTA";
            this.radioButton_card.UseVisualStyleBackColor = true;
            // 
            // radioButton_cash
            // 
            this.radioButton_cash.AutoSize = true;
            this.radioButton_cash.Location = new System.Drawing.Point(7, 110);
            this.radioButton_cash.Name = "radioButton_cash";
            this.radioButton_cash.Size = new System.Drawing.Size(81, 19);
            this.radioButton_cash.TabIndex = 0;
            this.radioButton_cash.TabStop = true;
            this.radioButton_cash.Text = "GOTÓWKA";
            this.radioButton_cash.UseVisualStyleBackColor = true;
            // 
            // groupBox_day
            // 
            this.groupBox_day.Controls.Add(this.textBox_description);
            this.groupBox_day.Controls.Add(this.button_editDescription);
            this.groupBox_day.Controls.Add(this.button_deleteTicket);
            this.groupBox_day.Controls.Add(this.label_freeSpace);
            this.groupBox_day.Controls.Add(this.listBox_tickets);
            this.groupBox_day.Controls.Add(this.label4);
            this.groupBox_day.Controls.Add(this.label5);
            this.groupBox_day.Controls.Add(this.listBox_tours);
            this.groupBox_day.Location = new System.Drawing.Point(182, 232);
            this.groupBox_day.Name = "groupBox_day";
            this.groupBox_day.Size = new System.Drawing.Size(436, 193);
            this.groupBox_day.TabIndex = 28;
            this.groupBox_day.TabStop = false;
            // 
            // groupBox_calendar
            // 
            this.groupBox_calendar.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_calendar.Controls.Add(this.monthCalendar1);
            this.groupBox_calendar.Controls.Add(this.button_genDaySummary);
            this.groupBox_calendar.Location = new System.Drawing.Point(182, 53);
            this.groupBox_calendar.Name = "groupBox_calendar";
            this.groupBox_calendar.Size = new System.Drawing.Size(436, 184);
            this.groupBox_calendar.TabIndex = 29;
            this.groupBox_calendar.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarToolStripMenuItem,
            this.dayToolStripMenuItem,
            this.buyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.CheckOnClick = true;
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.calendarToolStripMenuItem.Text = "calendar";
            this.calendarToolStripMenuItem.Click += new System.EventHandler(this.calendarToolStripMenuItem_Click);
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.CheckOnClick = true;
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.dayToolStripMenuItem.Text = "day";
            this.dayToolStripMenuItem.Click += new System.EventHandler(this.dayToolStripMenuItem_Click);
            // 
            // buyToolStripMenuItem
            // 
            this.buyToolStripMenuItem.CheckOnClick = true;
            this.buyToolStripMenuItem.Name = "buyToolStripMenuItem";
            this.buyToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.buyToolStripMenuItem.Text = "buy";
            this.buyToolStripMenuItem.Click += new System.EventHandler(this.buyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 437);
            this.Controls.Add(this.groupBox_calendar);
            this.Controls.Add(this.groupBox_day);
            this.Controls.Add(this.groupBox_buy);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_buy.ResumeLayout(false);
            this.groupBox_buy.PerformLayout();
            this.groupBox_day.ResumeLayout(false);
            this.groupBox_day.PerformLayout();
            this.groupBox_calendar.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_tours;
        private System.Windows.Forms.ListBox listBox_tickets;
        private System.Windows.Forms.Button button_addTickets;
        private System.Windows.Forms.Button button_deleteTicket;
        private System.Windows.Forms.TextBox textBox_ticketCount;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBox_possibleHours;
        private System.Windows.Forms.ListBox listBox_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_freeSpace;
        private System.Windows.Forms.Button button_addTicket;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Button button_editDescription;
        private System.Windows.Forms.Label label_places;
        private System.Windows.Forms.TextBox textBox_takePlaces;
        private System.Windows.Forms.Button button_genDaySummary;
        private System.Windows.Forms.GroupBox groupBox_buy;
        private System.Windows.Forms.RadioButton radioButton_card;
        private System.Windows.Forms.RadioButton radioButton_cash;
        private System.Windows.Forms.Button button_addBooking;
        private System.Windows.Forms.GroupBox groupBox_day;
        private System.Windows.Forms.GroupBox groupBox_calendar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyToolStripMenuItem;
    }
}

