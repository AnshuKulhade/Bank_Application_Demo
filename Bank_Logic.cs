using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Bank_logic
    {
        private int _id;
        private string _name;
        private int _credit_card;
        private bool _status;
        private double _balance;
        public Bank_logic(int id, string name, int credit_card, bool status, double balance)
        {
            this._id = id;
            this._name = name;
            this._credit_card = credit_card;
            this._status = status;
            this._balance = balance;
        }
        public int id
        {
            get { return _id; }
        }
        public string name
        {
            
                get { return _name; }
                set
                {

                    if (value != "" && value != null && _status == true)
                    {
                        _name = value;
                    }
                }            
        }
        public int credit_card
        {
            get { return _credit_card; }
        }
        public bool status
        {
            get { return _status; }
            set
            {
                if (_status == true)
                    _status = value;
            }
        }
        public double balance
        {
            get { return _balance; }
            set
            {
                if (_status == true)
                {
                    _balance = value;
                    Console.WriteLine("Account Balance Limit is : 100rs.");
                }
                //else
                //{
                //    Console.WriteLine("Withdrawal Is Restricted");
                //}
            }
        }
        public void Withdrawal()
        {
            try
            {
                Console.WriteLine($"Please Enter Your Withdrawal Ammount : ");
                double wd = double.Parse(Console.ReadLine());
                Console.WriteLine("You Withdrawal Ammount : " + wd);
                double bal_limit = 100;
                double result = balance - wd;
                if (result >= bal_limit)
                {
                    Console.WriteLine("Old Account Balance : " + balance);
                    Console.WriteLine("Success Withdrawal Of : " + result);
                    Console.WriteLine("Please Visit Again.");
                }
                else
                {
                    Console.WriteLine("Restricted Withdrawal Ammount Due To Insufficent Account Balance.");
                    Console.WriteLine("Please Maintain Minimum 100rs.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void Main()
        {
            Bank_logic GSD = new Bank_logic(101, "Neeraj Nath", 101201, true, 5000.00);
            try
            {
                if (GSD.status == true)
                {
                    if (GSD.balance < 100.00)
                        Console.WriteLine("Please Add Money To Maintain Acc Balance Should be 500rs. ");
                    Console.WriteLine("Account Is Active: Transection is Active");
                }
                else
                {

                    Console.WriteLine("Account Is Deactivate : Contact Your Branch Manager");
                };
            }
            catch(Exception ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            Console.WriteLine($"Welcome To Account Information : \n Customer ID : {GSD.id}\n Customer Name : {GSD.name}\n Customer Credit Card Number : {GSD.credit_card}\n Customer Account Status : {GSD.status} \n Customer Current Balanace : {GSD.balance}");
            //GSD.balance -= 20000;
            //GSD.Withdrawal(200);
            //Console.WriteLine("Total Money : " + GSD.balance);
            GSD.Withdrawal();

            Console.ReadLine();
        }

    }
}
