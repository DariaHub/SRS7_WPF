using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class AnswerGen
    {
        private static String[] answers = new String[]
       {
            "Даже не думай",
            "Определенно ДА",
            "Можешь быть уверен в этом",
            "Да!",
            "Нет!",
            "По моим данным — «нет»",
            "Весьма сомнительно",
            "Сейчас нельзя предсказать",
            "Спроси позже",
            "Пока не ясно, попробуй снова",
            "Знаки говорят — «да»",
            "Хорошие перспективы",
            "Сконцентрируйся и спроси опять"
       };
        public static String GetRandom()
        {
            return answers[new Random().Next(answers.Length)];
        }
    }
}
