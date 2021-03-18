using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MessageListClass
{
    public class Name
    {
        public string company { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class Address
    {
        public string name { get; set; }
        public string extra { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }

    public class Partner
    {
        public int idUser { get; set; }
        public string username { get; set; }
        public int isCommercial { get; set; }
        public int reputation { get; set; }
        public int sellCount { get; set; }
        public bool onVacation { get; set; }
        public Name name { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string vat { get; set; }
        public DateTime registrationDate { get; set; }
        public bool isSeller { get; set; }
        public string legalInformation { get; set; }
        public int unsentShipments { get; set; }
        public int shipsFast { get; set; }
        public int soldItems { get; set; }
        public int avgShippingTime { get; set; }
        public int riskGroup { get; set; }
        public string lossPercentage { get; set; }
    }

    public class Message
    {
        public string idMessage { get; set; }
        public bool isSending { get; set; }
        public DateTime date { get; set; }
        public string text { get; set; }
        public bool unread { get; set; }
    }

    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
        public string method { get; set; }
    }

    public class Thread
    {
        public Partner partner { get; set; }
        public Message message { get; set; }
        public int unreadMessages { get; set; }
        public List<Link> links { get; set; }
    }

    public class Root
    {
        public List<Thread> thread { get; set; }
        public List<Link> links { get; set; }
    }
}
