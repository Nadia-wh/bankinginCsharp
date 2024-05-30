using System;


namespace Bank 
{
    class Bank 
    {
        
        public string myName ="";
    
        public double myBalance ;
        
        Savings sv = new Savings();
        //see in create account
        public bool val = true;
        public bool debval = true;

        //id storing
        
        public void showInfo()
        {
           
                Console.WriteLine("Your details: ");
                Console.WriteLine("Name: "+myName);
                Console.WriteLine("Balance: " +myBalance); 

        }
     

        public void deposit()
        {
            
        }
        public void withdraw()
        {
            
            }

    }    
}