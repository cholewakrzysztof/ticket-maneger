using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace TicketManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Ticket Manager v1.2";
            manager = IOManager.readFromFile(monthCalendar1.SelectionStart);
            label_freeSpace.Text = FrontDataManager.setFreePlacesLabel(manager);
            textBox_takePlaces.Text = "1";
        }
        TicketManager manager;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendar calendar = (MonthCalendar)sender;
            manager = IOManager.readFromFile(calendar.SelectionStart);
            listBox_tours = FrontDataManager.setToursListBox(manager, listBox_tours);
            listBox_tickets.Items.Clear();
            label_freeSpace.Text = FrontDataManager.setFreePlacesLabel(manager);
            textBox_description.Text = "";
        }
        private void button_addTickets_Click(object sender, EventArgs e)
        {
            try
            {
                Validator.validObjects(new object[] { listBox_possibleHours, listBox_price,textBox_ticketCount, textBox_takePlaces });

                int h = Convert.ToInt32(listBox_possibleHours.SelectedItem.ToString().Replace(":00",""));
                int price = Convert.ToInt32(Convert.ToDouble(listBox_price.SelectedItem.ToString().Replace(" zł", "")) * 100);
                int count = Convert.ToInt32(textBox_ticketCount.Text);
                int places = Convert.ToInt32(textBox_takePlaces.Text);
                
                if (places == 0)
                {
                    MessageBox.Show("Podano złą ilość zajętych miejsc");
                    return;
                }

                if (radioButton_cash.Checked == true)
                    manager.setPayment(Payment.CASH);
                if (radioButton_card.Checked == true)
                    manager.setPayment(Payment.CARD);
                manager.buyTicket(count, h, price,places);
                manager.sortTours();
                IOManager.saveToFile(manager);
                manager.selectTour(manager.getIdxOfTour(h));
                listBox_tours = FrontDataManager.setToursListBox(manager, listBox_tours);
                label_freeSpace.Text = FrontDataManager.setFreePlacesLabel(manager);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void listBox_tours_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_description.Text = "";
            manager.selectTour(listBox_tours.SelectedIndex);
            manager.selectTicket(-1);
            listBox_tickets = FrontDataManager.setTicketListBox(manager, listBox_tickets);
            label_freeSpace.Text = FrontDataManager.setFreePlacesLabel(manager);
        }
        private void button_deleteTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Validator.validObjects(new object[] {listBox_tours,listBox_tickets});
                
                manager.selectTour(listBox_tours.SelectedIndex);
                manager.selectTicket(listBox_tickets.SelectedIndex);
                manager.deleteTicket();
                IOManager.saveToFile(manager);
                
                if (manager.tourIsEmpty())
                {
                    manager.deleteTour();
                    IOManager.saveToFile(manager);
                    if (manager.thereAreNoTours())
                        IOManager.deleteFile(manager);
                }
                else
                {
                    manager.sortTours();
                    IOManager.saveToFile(manager);
                }
                textBox_description.Text = "";
                listBox_tickets = FrontDataManager.setTicketListBox(manager, listBox_tickets);
                listBox_tours = FrontDataManager.setToursListBox(manager, listBox_tours);
                label_freeSpace.Text = FrontDataManager.setFreePlacesLabel(manager);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void button_addTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Validator.validObjects(new object[] {listBox_possibleHours,listBox_price,textBox_takePlaces});
                    
                int h = Convert.ToInt32(listBox_possibleHours.SelectedItem.ToString().Replace(":00", ""));
                int price = Convert.ToInt32(Convert.ToDouble(listBox_price.SelectedItem.ToString().Replace(" zł", "")) * 100);
                int places = Convert.ToInt32(textBox_takePlaces.Text);
                
                if (places == 0)
                    MessageBox.Show("Podano złą ilość zajetych miejsc");
                
                if (radioButton_cash.Checked == true)
                    manager.setPayment(Payment.CASH);
                if(radioButton_card.Checked==true)
                    manager.setPayment(Payment.CARD);

                manager.buyTicket(1, h, price,places);
                manager.sortTours();
                IOManager.saveToFile(manager);
                manager.selectTour(manager.getIdxOfTour(h));
                listBox_tours = FrontDataManager.setToursListBox(manager, listBox_tours);
                label_freeSpace.Text = FrontDataManager.setFreePlacesLabel(manager);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);   
            }
        }
        private void listBox_tickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            manager.selectTicket(listBox_tickets.SelectedIndex);
            textBox_description.Text = FrontDataManager.setDescriptionTextBox(manager);
        }
        private void button_editDescription_Click(object sender, EventArgs e)
        {
            try
            {
                Validator.validObjects(new object[] { listBox_tickets,textBox_description });
                manager.selectTicket(listBox_tickets.SelectedIndex);
                manager.setTicketDescription(textBox_description.Text);
                listBox_tickets = FrontDataManager.setTicketListBox(manager, listBox_tickets);
                IOManager.saveToFile(manager);
            }
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }
        private void button_genDaySummary_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.date = monthCalendar1.SelectionRange.Start;
            summaryForm.genSummary();
            summaryForm.ShowDialog();
        }
        private void button_addBooking_Click(object sender, EventArgs e)
        {
            try
            {
                Validator.validObjects(new object[] { textBox_takePlaces, textBox_ticketCount, listBox_possibleHours });

                int h = Convert.ToInt32(listBox_possibleHours.SelectedItem.ToString().Replace(":00", ""));
                int places = Convert.ToInt32(textBox_takePlaces.Text);
                int count = Convert.ToInt32(textBox_ticketCount.Text);

                if (places == 0)
                    MessageBox.Show("Podano złą ilość zajetych miejsc");

                manager.setPayment(Payment.BOOKING);
                manager.buyTicket(count, h, 0, places);
                manager.sortTours();
                IOManager.saveToFile(manager);
                manager.selectTour(manager.getIdxOfTour(h));
                listBox_tours = FrontDataManager.setToursListBox(manager, listBox_tours);
                label_freeSpace.Text = FrontDataManager.setFreePlacesLabel(manager);
            }
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }
        public class TicketManager 
        {
            private DateTime date;
            public List<Tour> Tours = new List<Tour>();
            public int selectedTourIdx = -1;
            public int selectedTicketIdx = -1;
            private Payment payment = Payment.CASH;
            public TicketManager(DateTime date)
            {
                this.date = date;
            }
            public void buyTicket(int count, int hour,int price,int places)
            {
                selectTour(getIdxOfTour(hour));
                if (selectedTourIdx > -1)
                {
                    if (Tours[selectedTourIdx].canBuyTickets(count,places))
                    {
                        Tours[selectedTourIdx].buyTickets(count,price,places,payment);
                    }
                }
                else
                {
                    Tour Tour = new Tour(hour);
                    if (Tour.canBuyTickets(count,places))
                    {
                        Tour.buyTickets(count,price,places,payment);
                        Tours.Add(Tour);
                    }
                }
            }
            public int getIdxOfTour(int hour)
            {
                for (int i = 0; i < Tours.Count(); i++)
                    if (Tours[i].hour == hour)
                        return i;
                return -1;
            }
            public void deleteTicket()
            {
                Tours[selectedTourIdx].tickets.Remove(Tours[selectedTourIdx].tickets[selectedTicketIdx]);
                selectedTicketIdx = -1;
            }
            public void setTicketDescription(string desc) 
            {
                Tours[selectedTourIdx].tickets[selectedTicketIdx].description = desc;
            }
            public void deleteTour()
            {
                Tours.RemoveAt(selectedTourIdx);
                selectedTourIdx = -1;
            }
            public void selectTour(int idx)
            {
                selectedTourIdx = idx;
            }
            public void selectTicket(int idx)
            {
                selectedTicketIdx = idx;
            }
            public void sortTours()
            {
                Tours = Tours.OrderBy(t => t.hour).ToList();
            }
            public bool tourIsEmpty()
            {
                if (Tours[selectedTourIdx].tickets.Count() == 0)
                    return true;
                return false;
            }
            public bool thereAreNoTours()
            {
                if (Tours.Count() == 0)
                    return true;
                return false;
            }
            public void setPayment(Payment paymentType)
            {
                this.payment = paymentType;
            }
            public string getDateString() 
            {
                return date.ToShortDateString().Replace('.', '_');
            }
        }
        public class Tour
        {
            public int hour;
            public List<Ticket> tickets = new List<Ticket>();
            public Tour(int hour) 
            {
                this.hour = hour;
            }
            public void buyTickets(int count,int price,int places,Payment payment)
            {
                for (int i = 0; i < count; i++)
                {
                    Ticket t = new Ticket(price, places,payment);
                    tickets.Add(t);
                }
            }
            public bool canBuyTickets(int count,int places)
            {
                if (getNumberOfTakenPlaces() + count*places > 30)
                {
                    MessageBox.Show("Nie można kupić "+count.ToString()+" biletów");
                    return false;
                }
                return true;
            }
            public int getNumberOfTakenPlaces()
            {
                int takenPLaces = 0;
                for (int i = 0; i < tickets.Count(); i++)
                    takenPLaces += tickets[i].takenplaces;
                return takenPLaces;
            }
        }
        public class Ticket
        {
            public int price;
            public int takenplaces;
            public string description = "";
            public Payment payment;
            public Ticket(int price,int takenplaces,Payment payment)
            {
                this.price = price;
                this.takenplaces = takenplaces;
                this.payment = payment;
            }
        }
        public static class Validator
        {
            public static bool validObjects(Object[] list)
            {
                for (int i = 0; i < list.Length; i++) 
                {
                    if (list[i].GetType() == new ListBox().GetType()) 
                        isAnythingSelected((ListBox)list[i]);
                    if (list[i].GetType() == new TextBox().GetType())
                        isAnythingTyped((TextBox)list[i]);
                }
                return true;
            }
            private static bool isAnythingSelected(ListBox listBox)
            {
                if (listBox.SelectedItem != null)
                    return true;
                throw new Exception("Wartość w "+ switchName(listBox.Name) + " nie została wybrana, a jest wymagana");
            }
            private static bool isAnythingTyped(TextBox textBox)
            {
                if (textBox.Text.Length != 0)
                    return true;
                throw new Exception("W polu " + switchName(textBox.Name) + " nie podano wartości, a jest wymagana");
            }
            private static string switchName(string name)
            {
                if (name == "textBox_description")
                    return "'opis biletu'";
                if (name == "textBox_ticketCount")
                    return "'ilość biletów'";
                if (name == "textBox_takePlaces")
                    return "'ilość miejsc'";
                if (name == "listBox_tickets")
                    return "'kupione bilety'";
                if (name == "listBox_tours")
                    return "'godziny zwiedzania'";
                if (name == "listBox_price")
                    return "'cena'";
                if (name == "listBox_possibleHours")
                    return "'godzina'";
                return name;
            }
        }
        public static class FrontDataManager
        {
            public static ListBox setTicketListBox(TicketManager ticketManager, ListBox listBox)
            {
                listBox.Items.Clear();
                if (ticketManager.selectedTourIdx == -1)
                    return listBox;
                List<Ticket> tickets = ticketManager.Tours[ticketManager.selectedTourIdx].tickets;
                for (int i = 0; i < tickets.Count(); i++)
                {
                    string toAdd = (Convert.ToDouble(tickets[i].price)/100).ToString()+" zł";
                    toAdd += ", miejsca: "+tickets[i].takenplaces.ToString();
                    if(tickets[i].payment==Payment.CASH)
                        toAdd += ", gotówka";
                    if (tickets[i].payment == Payment.CARD)
                        toAdd += ", karta";
                    if (tickets[i].payment == Payment.BOOKING)
                        toAdd += ", rezerwacja";
                    if (tickets[i].description != "")
                        toAdd += ", opis";
                    listBox.Items.Add(toAdd);
                }
                if(ticketManager.selectedTicketIdx>-1)
                    listBox.SelectedIndex = ticketManager.selectedTicketIdx;
                return listBox;
            }
            public static ListBox setToursListBox(TicketManager ticketManager, ListBox listBox)
            {
                listBox.Items.Clear();
                List<Tour> tours = ticketManager.Tours;
                for (int i = 0; i < tours.Count(); i++)
                    listBox.Items.Add("Godzina: "+tours[i].hour.ToString()+":00");
                if(ticketManager.selectedTourIdx>-1)
                    listBox.SelectedIndex = ticketManager.selectedTourIdx;
                return listBox;
            }
            public static string setDescriptionTextBox(TicketManager ticketManager)
            {
                if(ticketManager.selectedTicketIdx>-1)
                    if(ticketManager.selectedTourIdx>-1)
                        return ticketManager.Tours[ticketManager.selectedTourIdx].tickets[ticketManager.selectedTicketIdx].description;
                return "";
            }
            public static string setFreePlacesLabel(TicketManager ticketManager)
            {
                if(ticketManager.selectedTourIdx>-1)
                    return "WOLNE MIEJSCA: "+(30 - ticketManager.Tours[ticketManager.selectedTourIdx].getNumberOfTakenPlaces()).ToString();
                return "";
            }
        }
        public static class IOManager
        {
            private static string path = "data/";
            public static TicketManager readFromFile(DateTime dateTime)
            {
                
                TicketManager ticketManager = new TicketManager(dateTime);
                string name = ticketManager.getDateString();
                string data;
                if (File.Exists(path+name + ".txt"))
                    data = File.ReadAllText(path+name + ".txt");
                else
                    return ticketManager;
                List<Tour> Tours = JsonSerializer.Deserialize<List<Tour>>(data, new JsonSerializerOptions { IncludeFields = true });
                ticketManager.Tours = Tours;
                return ticketManager;
            }
            public static void saveToFile(TicketManager ticketManager)
            {
                string name = ticketManager.getDateString();
                string jsonString = JsonSerializer.Serialize(ticketManager.Tours, new JsonSerializerOptions{IncludeFields = true});
                File.WriteAllText(path+name + ".txt", jsonString);
            }
            public static void deleteFile(TicketManager ticketManager)
            {
                File.Delete(path+ticketManager.getDateString());
            }
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox_buy.Visible = false;
            groupBox_calendar.Visible = true;
            groupBox_day.Visible = false;
        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox_buy.Visible = false;
            groupBox_calendar.Visible = false;
            groupBox_day.Visible = true;
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox_buy.Visible = true;
            groupBox_calendar.Visible = false;
            groupBox_day.Visible = false;
        }
    }
}
public enum Payment 
{
    CASH,
    CARD,
    BOOKING
}
