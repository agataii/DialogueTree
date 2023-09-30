namespace DerevoDialogov
{
    public class Game
    {
        private Message[] AlexMessages = new Message[]
       {
            new Message(
                new string[]
                {
                    "Я хочу купить продукты",
                    "Я ищу особый предмет"
                },
                "Добрый день, чем могу вам помочь?",
                0,
                new int[]
                {
                    1,2
                }),
            new Message(
                new string[]
                {
                    "Я хочу рыбу",
                    "Я хочу овощи"
                },
                "Есть рыбы и овощи",
                1,
                new int[]
                {
                    3,4
                }),
            new Message(
                new string[]
                {
                    "Я ищу редкий мед",
                },
                "У нас есть разные предметы. Какой вам нужен?",
                2,
                new int[]
                {
                    5
                }),
            new Message(
                new string[]
                {
                    "Я возьму Караса",
                    "Я возьму Семгу",
                    "Я возьму Судак",
                    "Я передумал",
                },
                "Конечно у меня есть рыба",
                3,
                new int[]
                {
                    6,6,6,6
                }),
            new Message(
                new string[]
                {
                    "Я возьму Помидоры",
                    "Я возьму Огурцы",
                    "Я возьму Капусту",
                    "Я передумал",
                },
                "У меня самые свежие овощи",
                4,
                new int[]
                {
                    6,6,6,6
                }),
            new Message(
                new string[]
                {
                    "Я возьму",
                    "Не надо",
                },
                "Мы можем дать тебе этот мед. Только очень дорого",
                5,
                new int[]
                {
                    6,7
                }),
            new Message(
                new string[]
                {
                    "Да, покажи",
                    "Нет ничего",
                },
                "Что нибудь еще?",
                6,
                new int[]
                {
                    1,7
                }),
            new Message(
                new string[]
                {
                    "Пока",
                },
                "Пока",
                7,
                new int[]
                {

                }),
       };
        public void LaunchGame()
        {
            PrintMainMenu();
        }
        public void PrintMainMenu()
        {
            Console.Clear();

            Console.WriteLine("GoGame");
            Console.WriteLine("1)Начать");
            Console.WriteLine("2)Инвентарь");
            Console.WriteLine("3)Выход");

            int a = InputComment();

            switch (a)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                default:
                    break;
            }

        }

        public static int InputComment()
        {
            Console.Write("Введите команду:");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

        public void StartGame()
        {
            NPC Alex = new NPC("Alex", AlexMessages);
            Alex.StartDialog();
            PrintMainMenu();
        }
    }
}
