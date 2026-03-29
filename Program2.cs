using System;
namespace Pizza.S

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("   PIZZA.S МЕНЮ  ");
                Console.WriteLine("1. Переглянути меню та ціни");
                Console.WriteLine("2. Доставка");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");

                string mainChoice = Console.ReadLine();

                if (mainChoice == "1")
                {
                    ShowMenu();
                }
                else if (mainChoice == "2")
                {
                    MakeOrder();
                }
                else if (mainChoice == "0")
                {
                    running = false;
                }
            }
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Меню");
            Console.WriteLine("1. Маргарита - 150 грн");
            Console.WriteLine("2. Пепероні  - 210 грн");
            Console.WriteLine("3. Чотири сири - 250 грн");
            Console.WriteLine("4. Діабло - 200 грн");
            Console.WriteLine("5. Веганська -160 грн");
            Console.WriteLine("6. Конструктор піци(зробити самому)");
            Console.Write("Вибір замовлення:");
            
            string Choice = Console.ReadLine();
            
            if (Choice == "1") Console.WriteLine("\nЦіна: 150 грн. Склад: томати, моцарела, базилік, томатний соус.");
            else if (Choice == "2") Console.WriteLine("\nСклад: салямі пепероні, сир, томатний соус.");
            else if (Choice == "3") Console.WriteLine("\nСклад: чотири види сирів.");
            else if (Choice == "4") Console.WriteLine("\nСклад: пепероні, сир, перець чілі, томатний соус.");
            else if (Choice == "5") Console.WriteLine("\nСклад: веганський сир, томатний соус, веганське тісто, базилік.");
            else if (Choice == "6") Console.WriteLine("\nСклад: чотири види сирів.");
            
            if (Choice != "0")
            {
                Console.WriteLine("\nБажаєте замовити цю піцу? (натисніть 1 - Так / 0 - Ні)");
                if (Console.ReadLine() == "1") MakeOrder();
            }
        }

        static void MakeOrder()
        {
            Console.Clear();
            Console.WriteLine("оформлення замовлення");
            Console.Write("Введіть вашу адресу доставки: ");
            string address = Console.ReadLine();

            Console.WriteLine($"\nВаша адреса: {address}");
            Console.WriteLine("Натисніть 'Enter', щоб підтвердити"); 
            Console.ReadLine(); 

            Console.WriteLine("ДЯКУЄМО ЗА ЗАМОВЛЕННЯ! Очікуйте кур'єра.");
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("\nНатисніть будь-яку клавішу для повернення в меню.");
            Console.ReadKey();
        }
    }
}