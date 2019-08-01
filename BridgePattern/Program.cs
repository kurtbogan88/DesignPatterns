using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager
            {
                MessageSender = new EmailSender()
            };

            customerManager.Update();

            ProductManager productManager = new ProductManager()
            {
                MessageSender = new SmsSender()
            };

            productManager.Update();

            Console.ReadLine();
        }
        abstract class MessageSender
        {
            public abstract void Send();
        }

        class EmailSender : MessageSender
        {
            public override void Send()
            {
                Console.WriteLine("Email ile gönderildi");
            }
        }

        class SmsSender : MessageSender
        {
            public override void Send()
            {
                Console.WriteLine("Sms ile gönderildi");
            }
        }

        class CustomerManager
        {
            public MessageSender MessageSender { get; set; }
            public void Update()
            {
                Console.WriteLine("Müşteri Update edildi");
                MessageSender.Send();
            }
        }

        class ProductManager
        {
            public MessageSender MessageSender { get; set; }
            public void Update()
            {
                Console.WriteLine("Ürün Update edildi");
                MessageSender.Send();
            }
        }
    }
}
