using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace ConssoleApp228
{
    class Program
    {
        private static string ConnectionString
        {
            get
            {
                return "698838515:AAGfGg_74AGp4td9tNNIQw_GOuHjfUJCSm8";
            }
        }
        private static TelegramBotClient bot = null;

        private static void Main(string[] args)
        {
            try
            {
                Program.bot = new TelegramBotClient(Program.ConnectionString);
                Console.WriteLine($"{Program.bot.GetMeAsync().Result} 15 574r73d");

                Program.bot.OnMessage += GetMessage;
                Program.bot.StartReceiving();

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static async void GetMessage(object sender, MessageEventArgs e)
        {
            try
            {
                if (e.Message.Text != null)
                {
                    if (e.Message.Text[0] == '/')
                        await CommandHandler(e);
                    else
                        TextHandler(e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void TextHandler(MessageEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static async Task CommandHandler(MessageEventArgs e)
        {
            try
            {
                switch (e.Message.Text.ToLower())
                {
                    case "/start":
                        await bot.SendPhotoAsync(e.Message.Chat.Id,
                            @"http://cdn46.printdirect.ru/cache/product/c9/50/6221865/tov/all/480z480_front_1009_0_0_0_b7c584965630f736252ca84d2103.jpg", 
                            "PoPKa BoLIT?");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
