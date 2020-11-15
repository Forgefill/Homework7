using System;

//Який принцип S.O.L.I.D. порушено? Виправте!

//Порушино принцип (OCP)



/*Зверніть увагу на клас EmailSender. Крім того, що за допомогою методу Send, він відправляє повідомлення, 
він ще і вирішує як буде вестися лог. В даному прикладі лог ведеться через консоль.
Якщо трапиться так, що нам доведеться міняти спосіб логування, то ми будемо змушені внести правки в клас EmailSender.
Хоча, здавалося б, ці правки не стосуються відправки повідомлень. Очевидно, EmailSender виконує кілька обов'язків і, 
щоб клас ні прив'язаний тільки до одного способу вести лог, потрібно винести вибір балки з цього класу.*/
namespace Solid2
{
    class Email
    {
        public String Theme { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }

    interface ILogFormatter
    {
        void FormatReport(string From, string To);
    }

    class EmailConsoleLog : ILogFormatter          // записуємо логи в консоль
    {
        void ILogFormatter.FormatReport(string From, string To)
        {
            Console.WriteLine("Email from '" + From + "' to '" + To + "' was send");
        }
    }

    class EmailFileLog : ILogFormatter              // записуємо логи в файл (емуляція через консоль)
    {
        void ILogFormatter.FormatReport(string From, string To)
        {
            //File log emulation
            Console.WriteLine("write to file: Email from '" + From + "' to '" + To + "' was send");
        }
    }
    class EmailSender
    {
        public void Send(Email email, ILogFormatter Log)
        {
            // ... sending...
            Log.FormatReport(email.From, email.To);
        }
    }

    class Ex2
    {
        static void Main(string[] args)
        {
            Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
            Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
            Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
            Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
            Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
            Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };
            ILogFormatter log1 = new EmailConsoleLog();
            ILogFormatter log2 = new EmailFileLog();

            EmailSender es = new EmailSender();
            es.Send(e1, log1);
            es.Send(e2, log1);
            es.Send(e3, log1);
            es.Send(e4, log2);
            es.Send(e5, log2);
            es.Send(e6, log2);

            Console.ReadKey();
        }
    }
}