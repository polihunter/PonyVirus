using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("В Понивиле появился страшный вирус. \nВы стали замечать на улице раненых пони со странным поведением... \nО нет, кажется зараженных становится больше...");
        WaitForSpace();
        Console.WriteLine("Будьте бдительны! Зараженные пони имеют: рану с черным пятном, деформацию, неестественные глаза и размытую метку.");
        WaitForSpace();
        Console.WriteLine("Подсказки: \n1.Зараженные могут притворяться не зараженными пони \n2.Доверяй только Рарити(белый единорог)!!!!! \n3.Не ходите по темным местам \n4.Не бери еду,которая быстро портится");
        WaitForSpace();
        Console.WriteLine("Вы играете за Флаттершай");
        WaitForSpace();
        Console.WriteLine("Ты направлялась домой после прогулки, но идя вы заметили странность - \nна улице не было ни одной пони.\nКогда ты почти дошла, ты вспомнила что дома совсем нет еды...\nТы решила сбегать до магазина.");
        WaitForSpace();

        Console.WriteLine("Когда вы подошли к магазину, к вам подошла напуганная пони..\nОна просит у вас бинты\nДать ей бинты?");
        Console.WriteLine("1. Да");
        Console.WriteLine("2. Забежать в магазин");
        string choice1 = Console.ReadLine();
        if (choice1 == "1")
        {
            Console.WriteLine("Эта пони была зараженная...Она вас убила");
            Environment.Exit(0);
        }
        
        if (choice1 == "2")
        {
            Console.WriteLine("Вы зашли в магазин");
        }
        WaitForSpace();
        Console.WriteLine("Ты забежала в магазин, тебе было страшно от увиденного..\nЧто происходит..?");
        WaitForSpace();
        Console.WriteLine("Через минуту вроде существо исчезло из окна,\nты отказывалась верить своим глазам..\nМожно выдохнуть");
        WaitForSpace();
        List<string> options = new List<string>
        {
            "Бутылка воды",
            "Чипсы",
            "Консерва",
            "Мармелад",
            "Сырое яйцо",
            "Яблоко",
            "Жвачка",
            "Носки",
            "Хлеб"
        };

        List<string> selectedOptions = new List<string>();
        bool validInput = false;

        while (!validInput || selectedOptions.Count > 5 || selectedOptions.GroupBy(x => x).Any(g => g.Count() > 1))
        {
            selectedOptions.Clear();
            Console.WriteLine("Выбери еду (максимум 5), вводя номера через запятую:");
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            Console.Write("Введите номера вариантов через запятую: ");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(',');

            validInput = true;
            foreach (string str in splitInput)
            {
                if (int.TryParse(str.Trim(), out int choice) && choice > 0 && choice <= options.Count)
                {
                    string selectedOption = options[choice - 1];
                    selectedOptions.Add(selectedOption);
                }
                else
                {
                    validInput = false;
                    Console.WriteLine("Неверный ввод, попробуйте снова.");
                    break;
                }
            }

            if (!validInput || selectedOptions.Count > 5 || selectedOptions.GroupBy(x => x).Any(g => g.Count() > 1))
            {
                Console.WriteLine("Ошибка: Выберите не более 5 уникальных вариантов.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Ваш выбор:");
        foreach (var option in selectedOptions.Distinct())
        {
            Console.WriteLine(option);
        }
        WaitForSpace();
        Console.WriteLine("Ты возвращаешься домой, здесь две дороги: ");
        Console.WriteLine("1. Пойти по долгой, но освещенной дороге");
        Console.WriteLine("2. Сократить и пойти по темной дороге");
        string choice2 = Console.ReadLine();
        if (choice2 == "1")
        {
            Console.WriteLine("Вы прошли и оказались дома");
        }
        if (choice2 == "2")
        {
            Console.WriteLine("Вы потерялись и вас убили");
            Environment.Exit(0);
        }
        WaitForSpace();
        Console.WriteLine("Ты дома с тобой все хорошо, но ты слышишь\nстук в дверь.. ");
        WaitForSpace();
        Console.WriteLine("ты решаешь посмотреть в глазок и видишь там белого единорога..");
        Console.WriteLine("1. Открыть дверь");
        Console.WriteLine("2. Не открывать дверь");
        string choice3 = Console.ReadLine();
        if (choice3 == "1")
        {
            Console.WriteLine("Вы открыли дверь Рарити, молодец!");
        //обновление
            Console.WriteLine("Рарити зашла с подозрительной раной и с ребенком\nОн тоже был ранен, но похуже, чем сама Рарити");
            WaitForSpace();
            Console.WriteLine("ты решаешь спросить про рану и ребенка,\nно в ответ ты получаешь это:");
            WaitForSpace();
            Console.WriteLine("Рарити: я создала сомнительную вакцину и мне надо проверить ее\nлибо на здоровой пони либо на уже зараженной пони, намекая на ребенка");
            Console.WriteLine("тебе решать что делать..");
            Console.WriteLine("1. Проверить на себе");
            Console.WriteLine("2. Проверить на ребенке");
            string choice4 = Console.ReadLine();
            if (choice4 == "1")
            {
                Console.WriteLine("Ты мучаешься от боли, но спустя время вакцина срабатывает");
            }
            if (choice4 == "2")
            {
                Console.WriteLine("Ребенок заразился окончательно и всех убивает");
                Environment.Exit(0);
            }

        }
        if (choice3 == "2")
        {
            Console.WriteLine("Вы не открыли дверь Рарити, это повлияет на вашу жизнь");
            WaitForSpace();
            Console.WriteLine("Ты садишься за компьютер и вбиваешь новости\nв новостях говорят, что нельзя выходить из дома из-за пандемии и ведутся истребительские действия по городу");
            WaitForSpace();
            Console.WriteLine("Ты решила лечь спать и дождаться следующего дня");
            WaitForSpace();
            Console.WriteLine("Наступило утро и ты снова слышишь стук в дверь, но уже там не было Рарити../nты решаешь посмотреть, а там твоя подруга Радуга(она военная)");
            Console.WriteLine("1. Впустить ее");
            Console.WriteLine("2. Не впускать");
            string choice5 = Console.ReadLine();
            if (choice5 == "1")
            {
                Console.WriteLine("Радуга говорит, что мне нужно пойти с ней в безопасное место");
                WaitForSpace();
                Console.WriteLine("Правило забыли? Никому не открывать и никому не доверять кроме Рарити..");
                Console.WriteLine("Радуга была одержима и убила вас");
                Environment.Exit(0);
            }
            if (choice5 == "2")
            {
                Console.WriteLine("Ты не открываешь, ничего не изменилось");
                
            }

        }
        //конец обновления


        static void WaitForSpace()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(intercept: true);
            } while (keyInfo.Key != ConsoleKey.Enter);

        }



    }
   
}
