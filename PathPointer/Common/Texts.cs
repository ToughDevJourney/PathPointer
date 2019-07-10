using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathPointer
{
    static class Texts
    {
        public const string empBusiness = "Business";
        public const string empGoals = "Goals";
        public const string empRest = "Rest";
        public const string empFun = "Fun";
        public const string emptyEmpFile = "Ого! Похоже, что вы новенький!\nДобавьте новую деятельность!";

        public const string empSkip = "ПРОПУСК";
        public const string empTypeSkip = "Skip";
        public const string empSkipDescrip = "Похоже, что в это время вы занимались чем-то ДЕЙСТВИТЕЛЬНО полезным" +
                                       "\nВам должно быть стыдно";

        public const string empAnother = "ДРУГОЕ";
        public const string empAnotherType = "Постарайтесь продумывать вашу деятельность заранее" +
                                "\nВо всяком случае, почему бы вам не дополнить ее прямо сейчас?";

        public const string empSleep = "СОН";
        public const string empSleepType = "Доброго вам утра" +
                                "\nУтро - пик вашей продуктивности, даже если вы сова, попробуйте поработать над собой утром";

        public const string empNow = "СЕЙЧАС";
        public const string empTypeNow = "Now";
        public const string empNowDescrip = "Ваша судьба в ваших руках" +
                                "\nПочему бы не заняться чем-нибудь полезным прямо сейчас?";

        public const string empFuture = "БУДУЩЕЕ";
        public const string empTypeFuture = "Future";
        public const string empFutureDescrip = "Этот отрезок времени покрыт великой тайной..." +
                                "\nНикто не знает, будете ли вы через пару часов смотреть телевизор или есть хлопья" +
                                "\nP.S. Пожалуйста, встаньте на путь к своей цели, не расстраивайте разработчика этой программы";

        public const string dataLost = "УПС, КАЖЕТСЯ, МЫ ПОТЕРЯЛИ ВАШИ ДАННЫЕ";
        public const string dataLostType = "Обратитесь к вашему системному администратору" +
                                        "\nНе факт, что он найдет, но разработчик этой программы очень любит людей";
        public const string dataLostHours = "Ваша продуктивность появится сразу, как только найдутся ваши данные";

        public const string empBusinessType = "Похоже, в это время вы работали и вам было холодно и очень грустно" +
                                                "\nЗнайте, что разработчику этой программы очень вас жалко :)";
        public const string empGoalType = "Ого, вы на верном пути к вашей цели!" +
                                                "\nВы ведь не потратили это время на чепуху, в плане, \"Смотреть весь день телевизор\", верно?";
        public const string empRestType = "Надеюсь, вы хорошо отдохнули!" +
                                                "\nНо помните, что если вы провели 4 часа за компьютером, \"Посидеть в вашем модном телефончике\" - не будет для вас отдыхом" +
                                                "\nОтдых - это смена деятельности, лучше сходите на прогулку или поиграйте с кошкой";
        public const string empFunType = "Развлечения могут повысить продуктивность, но чрезмерное злоупотребление ими, может вас погубить" +
                                                "\nБудьте осторожны";



        public const string funMoreThenGoals = "На этой неделе вы потратили больше времени на развлечения," +
                                                  "\nчем на самосовершенствование, поднажмите!";
        public const string sameFunAsGoals = "Вы тратите на развлечения почти столько же времени, сколько на самосовершенствование, вы можете лучше!";
        public const string goalsMoreThenFun = "Вы едите трудности на завтрак, так держать!";
        public static string[,] MotivationalHints = new string[,]{
            { "Пауло Коэльо", "Дойдя до конца, люди смеются над страхами, мучившими их вначале."},
            { "Чак Паланик", "Если ты не знаешь, чего хочешь, ты в итоге останешься с тем, чего точно не хочешь. "},
            { "Азим Премжи", "Если люди не смеются над вашими целями, значит ваши цели слишком мелкие."},
            { "Стивен Каггва", "Пробуйте и терпите неудачу, но не прерывайте ваших стараний."}
        };
    }
}
