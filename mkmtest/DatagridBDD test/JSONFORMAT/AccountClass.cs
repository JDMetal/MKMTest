// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using System;
using System.Collections.Generic;

public class AccountClass
{
    public class Name
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class HomeAddress
    {
        public string name { get; set; }
        public string extra { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }

    public class BankAccount
    {
        public string accountOwner { get; set; }
        public string iban { get; set; }
        public string bic { get; set; }
        public string bankName { get; set; }
    }

    public class MoneyDetails
    {
        public int totalBalance { get; set; }
        public int moneyBalance { get; set; }
        public int bonusBalance { get; set; }
        public int unpaidAmount { get; set; }
        public int providerRechargeAmount { get; set; }
        public int idCurrency { get; set; }
        public string currencyCode { get; set; }
    }

    public class Account
    {
        public int idUser { get; set; }
        public string username { get; set; }
        public int isCommercial { get; set; }
        public int reputation { get; set; }
        public int sellCount { get; set; }
        public bool onVacation { get; set; }
        public string country { get; set; }
        public bool maySell { get; set; }
        public int sellerActivation { get; set; }
        public int shipsFast { get; set; }
        public int soldItems { get; set; }
        public int avgShippingTime { get; set; }
        public int idDisplayLanguage { get; set; }
        public Name name { get; set; }
        public HomeAddress homeAddress { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string vat { get; set; }
        public string legalInformation { get; set; }
        public DateTime registerDate { get; set; }
        public bool isActivated { get; set; }
        public BankAccount bankAccount { get; set; }
        public int articlesInShoppingCart { get; set; }
        public int unreadMessages { get; set; }
        public MoneyDetails moneyDetails { get; set; }
        public int riskGroup { get; set; }
        public string lossPercentage { get; set; }
    }

    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
        public string method { get; set; }
    }

    public class Root
    {
        public Account account { get; set; }
        public List<Link> links { get; set; }
    }
}


