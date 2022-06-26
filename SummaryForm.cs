using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManager
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
            
        }
        public DateTime date;
        public void genSummary()
        {
            SummaryCreator summaryCreator = new SummaryCreator(date);
            label_totalIncome.Text += (Convert.ToDouble(summaryCreator.totalIncome()) / 100).ToString() + "zł";
            label_cash.Text += (Convert.ToDouble(summaryCreator.cashIncome()) / 100).ToString() + "zł";
            label_card.Text += (Convert.ToDouble(summaryCreator.cardIncome()) / 100).ToString() + "zł";
            label_totalVisits.Text += summaryCreator.totalVisits().ToString();
            label_date.Text = date.ToShortDateString();
        }
    }
    public class SummaryCreator 
    {
        Form1.TicketManager manager;
        public SummaryCreator(DateTime date)
        {
            this.manager = Form1.IOManager.readFromFile(date);
        }
        public int totalIncome()
        {
            return cashIncome() + cardIncome();
        }
        public int totalVisits()
        {
            int sum = 0;
            for (int i = 0; i < manager.Tours.Count(); i++)
                for(int j=0; j< manager.Tours[i].tickets.Count();j++)
                    if (manager.Tours[i].tickets[j].payment != Payment.BOOKING)
                        sum += manager.Tours[i].tickets[j].takenplaces;
            return sum;
        }
        public int cashIncome()
        {
            int sum = 0;
            for (int i = 0; i < manager.Tours.Count(); i++)
                for (int j = 0; j < manager.Tours[i].tickets.Count(); j++)
                    if(manager.Tours[i].tickets[j].payment==Payment.CASH)
                    sum += manager.Tours[i].tickets[j].price;
            return sum;
        }
        public int cardIncome()
        {
            int sum = 0;
            for (int i = 0; i < manager.Tours.Count(); i++)
                for (int j = 0; j < manager.Tours[i].tickets.Count(); j++)
                    if (manager.Tours[i].tickets[j].payment == Payment.CARD)
                        sum += manager.Tours[i].tickets[j].price;
            return sum;
        }
    }
}
