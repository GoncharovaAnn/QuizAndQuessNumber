using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StartNewLanguage
{
    internal class Program
    {  
        static void StartQuiz()
        {
            string[] questions =
           {
                "Зимой и летом одним цветом?",
                "Самая высокая гора?",
                "Самая длинная река?",
                "Самый большой океан?",
                "Самая большая планета?"
            };
            string[] answers1stquestion =
            {
                "ЁЛКА",
                "ЕЛКА",
                "ЕЛЬ",
                "СОСНА",
                "КЕДР",
                "ПИХТА"
            };
            string[] answers2ndquestion =
            {
                "ЭВЕРЕСТ",
                "ДЖОМОЛУНГМА"
            };
            string[] answers3rdquestion =
            {
                "АМАЗОНКА"
            };
            string[] answers4thquestion =
            {
                "ТИХИЙ",
                "ВЕЛИКИЙ",
                "ТИХИЙ ОКЕАН",
                "ВЕЛИКИЙ ОКЕАН"
            };
            string[] answers5thquestion =
            {
                "ЮПИТЕР"
            };
            string userAnswer;
            int counterOfRightAnswers = 0;
            int j = 0;
            int i = 0;

            WriteLine("\tВИКТОРИНА\n");
            for (i = 0; i < questions.Length; i++)
            {
                WriteLine(questions[i]);
                userAnswer = ReadLine();
                userAnswer = userAnswer.ToUpper();

                switch (i)
                {
                    case 0:
                    {
                        for (j = 0; j <= answers1stquestion.Length + 1; j++)
                        {
                            if (j < answers1stquestion.Length)
                            {
                                if (userAnswer == answers1stquestion[j])
                                {
                                    counterOfRightAnswers++;
                                    WriteLine("Ответ верный!");
                                    break;
                                }
                                else if(userAnswer != answers1stquestion[j])
                                {
                                    continue;
                                }
                            }
                            else if (j == answers1stquestion.Length + 1)
                            {
                                WriteLine("Ответ неверный!");
                            }
                        }
                        break;
                    }
                    case 1:
                   {
                        for (j = 0; j <= answers2ndquestion.Length + 1; j++)
                        {
                            if (j < answers2ndquestion.Length)
                            {
                                if (userAnswer == answers2ndquestion[j])
                                {
                                    counterOfRightAnswers++;
                                    WriteLine("Ответ верный!");
                                    break;
                                }
                                else if(userAnswer != answers2ndquestion[j])
                                {
                                    continue;
                                }
                            }
                            else if (j == answers2ndquestion.Length + 1)
                            {
                                WriteLine("Ответ неверный!");
                            }
                        }
                        break;
                   }
                    case 2:
                    {
                        for (j = 0; j <= answers3rdquestion.Length + 1; j++)
                        {
                            if (j < answers3rdquestion.Length)
                            {
                                if (userAnswer == answers3rdquestion[j])
                                {
                                    counterOfRightAnswers++;
                                    WriteLine("Ответ верный!");
                                    break;
                                }
                                else if (userAnswer != answers3rdquestion[j])
                                {
                                    continue;
                                }
                            }
                            else if (j == answers3rdquestion.Length + 1)
                            {
                                WriteLine("Ответ неверный!");
                            }
                        }
                        break;
                    }
                    case 3:
                    {
                        for (j = 0; j <= answers4thquestion.Length + 1; j++)
                        {
                            if (j < answers4thquestion.Length)
                            {
                                if (userAnswer == answers4thquestion[j])
                                {
                                    counterOfRightAnswers++;
                                    WriteLine("Ответ верный!");
                                    break;
                                }
                                else if (userAnswer != answers4thquestion[j])
                                {
                                    continue;
                                }
                            }
                            else if (j == answers4thquestion.Length + 1)
                            {
                                WriteLine("Ответ неверный!");
                            }
                        }
                        break;
                    }
                    case 4:
                    {
                        for (j = 0; j <= answers5thquestion.Length + 1; j++)
                        {
                            if (j < answers5thquestion.Length)
                            {
                                if (userAnswer == answers5thquestion[j])
                                {
                                    counterOfRightAnswers++;
                                    WriteLine("Ответ верный!");
                                    break;
                                }
                                else if (userAnswer != answers5thquestion[j])
                                {
                                    continue;
                                }
                            }
                            else if (j == answers5thquestion.Length + 1)
                            {
                                WriteLine("Ответ неверный!");
                            }
                        }
                        break;
                    }
                }
            }
            WriteLine("Правильных ответов: " + counterOfRightAnswers);
            WriteLine("Ваш ранг: ");
            if (counterOfRightAnswers <= 2) { WriteLine("Вы - невежда :с. Вам следует расширить свой кругозор"); }
            else if((counterOfRightAnswers > 2)&&(counterOfRightAnswers <=4 )) { WriteLine("Вы - знаток. Отличная попытка, но постарайтесь, в следующий раз, добиться результатов лучше! "); }
            else if (counterOfRightAnswers == 5) { WriteLine("Вы - мудрец!!! Не забывайте подпитывать ваш могз новыми знаниями"); }
        }
        static void StartGuessNumber()
        {
            Random rand = new Random();
            int MagicNumber = rand.Next(100) + 1;
            string temp;
            WriteLine("\tУГАДАЙ ЧИСЛО\n");
            WriteLine("Компьютер загадал число от 1 до 100. Попробуй его отгадать за 10 попыток");
            for(int i = 10; i > 0; i--)
            {
                Write("Попыток осталось " + i + ".\nВведите число: ");
                temp = ReadLine();
                if(!int.TryParse(temp, out int userNumber))
                {
                    i++;
                    continue;
                }
                else if (userNumber == MagicNumber)
                {
                    WriteLine("Ты угадал число за " + (11 - i) + " хода! ");
                    if(i == 10)
                    {
                        WriteLine("Вы - экстрасенс!");
                    }
                    else if(i > 7)
                    {
                        WriteLine("Nice try, boy!");
                    }
                    else if (i > 4)
                    {
                        WriteLine("Вы хорошо постарались!");
                    }
                    else
                    {
                        WriteLine("Тренеруйтесь, чтобы улучшить результат");
                    }
                    return;
                }
                else if (userNumber < MagicNumber)
                {
                    WriteLine("Загаданное число больше! ");
                }
                else if (userNumber > MagicNumber)
                {
                    WriteLine("Загаданное число меньше! ");
                }
            }
            WriteLine("Попытки закончились. Было загадано число " + MagicNumber);
        }
        static void Main(string[] args)
        {
            WriteLine("Выберите игру в которую хотите поиграть:\nНажмите \"1\" для прохождения викторины\nНажмите \"2\" для \"Угадай число\" ");
            int key = Int32.Parse(ReadLine());
            switch (key)
            {
                case 1: { Program.StartQuiz(); break; }
                case 2: { Program.StartGuessNumber(); break; }
            }
        }
    }
}
