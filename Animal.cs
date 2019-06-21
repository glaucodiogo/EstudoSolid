using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoSOLID
{
    #region Ex1 - Animal

    //OCP - Open-Closed Principle - Princípio que determina que uma class ,modules,functions obrigatóriamente
    //serão abertas para serem extendidas, e não modificadas
    public abstract class Animal
    {
        public abstract string makeSound();
    }


    public class Lion : Animal
    {
        public override string makeSound()
        {
            return "roar";
        }
    }


    public class Squirrel : Animal
    {
        public override string makeSound()
        {
            return "squeak";
        }
    }
    #endregion

    #region Problem1 - Discount for customers, with implementation without OCP

    public class Discount
    {
        private string customer { get; set; }
        private double price { get; set; }

        //The OCP forbids it, because not extension class
        public double giveDiscount()
        {
            if(this.customer == 'fav')
            {
                return this.price * 0.2;
            }

            if (this.customer == 'vip')
            {
                return this.price * 0.4;
            }

            return 0;
        }
    }

    #endregion

    #region The solution to follow the OCP 

    public abstract class Discount2
    {
        public abstract double GetDiscount();
    }
    public class VIPDiscount:Discount2
    {
        public override double GetDiscount()
        {
            return GetDiscount() * 2;
        }
    }

    #endregion


    //Liskov Substitution Principle - Steve Fenton
}