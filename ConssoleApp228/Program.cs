using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;
using System.Collections.Generic;

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
                Program.bot.OnCallbackQuery += GetQuery;
                Program.bot.StartReceiving();

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static async void GetQuery(object sender, CallbackQueryEventArgs e)
        {
            try
            {
                await bot.DeleteMessageAsync(e.CallbackQuery.Message.Chat, e.CallbackQuery.Message.MessageId);
                Console.WriteLine(e.CallbackQuery.Data.ToLower());
                switch (e.CallbackQuery.Data.ToLower())
                {
                    case "/start":
                        await bot.SendPhotoAsync(e.CallbackQuery.Message.Chat.Id,
                            @"http://cdn46.printdirect.ru/cache/product/c9/50/6221865/tov/all/480z480_front_1009_0_0_0_b7c584965630f736252ca84d2103.jpg",
                            "PoPKa BoLIT?");
                        break;
                    case "/menu":
                        List<InlineKeyboardButton> ikb = new List<InlineKeyboardButton>();

                        InlineKeyboardButton ikb0 = new InlineKeyboardButton();
                        ikb0.Text = "5t49t";
                        ikb0.CallbackData = "/start";
                        ikb.Add(ikb0);

                        InlineKeyboardButton ikb1 = new InlineKeyboardButton();
                        ikb1.Text = "pr3p4r3 fr06";
                        ikb1.CallbackData = "/prepare_frog";
                        ikb.Add(ikb1);

                        InlineKeyboardButton ikb2 = new InlineKeyboardButton();
                        ikb2.Text = "637 m3m35";
                        ikb2.CallbackData = "/get_memes";
                        ikb.Add(ikb2);

                        InlineKeyboardButton ikb3 = new InlineKeyboardButton();
                        ikb3.Text = "637 bu7hur7";
                        ikb3.CallbackData = "/get_buthurt";
                        ikb.Add(ikb3);

                        InlineKeyboardMarkup ikm = new InlineKeyboardMarkup(ikb);

                        await bot.SendTextMessageAsync(e.CallbackQuery.Message.Chat.Id,
                            "f0r u51n6 m3nu u53 /menu",
                            replyMarkup: ikm);

                        break;
                    case "/prepare_frog":
                        ReplyKeyboardMarkup rkm = new ReplyKeyboardMarkup(new KeyboardButton[]
                        { "pr3p4r3 fr06 15 600d", "pr3p4r3 fr06 15 b4d" });
                        rkm.OneTimeKeyboard = true;

                        await bot.SendPhotoAsync(e.CallbackQuery.Message.Chat.Id,
                            @"https://iknowyourmeme.files.wordpress.com/2016/04/happy-sad-frog-05.jpg",
                            "d0 y0u r34l3 w4n7 70 pr3p4r3 fr06?", replyMarkup: rkm);
                        break;
                }
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
                        await TextHandler(e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static async Task TextHandler(MessageEventArgs e)
        {
            try
            {
                switch (e.Message.Text.ToLower())
                {
                    case "pr3p4r3 fr06 15 600d":
                        await bot.SendPhotoAsync(e.Message.Chat.Id,
                            @"https://cs8.pikabu.ru/images/big_size_comm/2016-08_6/1472406927198059454.png",
                            "fr06 15 5ucc35ful7 pr3p4r3d!");
                        break;
                    case "pr3p4r3 fr06 15 b4d":
                        await bot.SendPhotoAsync(e.Message.Chat.Id,
                            @"https://vse-frazi.ru/wp-content/uploads/2017/03/%D0%BB%D1%8F%D0%B3%D1%83%D1%88%D0%BA%D0%B0-%D0%BC%D0%B5%D0%BC-15.gif",
                            "fr06 15 7h4nk5 f0r y0u!");
                        break;
                    case "<3":
                        await bot.SendPhotoAsync(e.Message.Chat.Id,
                            @"https://avatanplus.com/files/resources/mid/58f5134817a4715b7d5351a1.png");
                        break;

                }
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
                    case "/menu":
                        List<InlineKeyboardButton> ikb = new List<InlineKeyboardButton>();

                        InlineKeyboardButton ikb0 = new InlineKeyboardButton();
                        ikb0.Text = "5t49t";
                        ikb0.CallbackData = "/start";
                        ikb.Add(ikb0);

                        InlineKeyboardButton ikb1 = new InlineKeyboardButton();
                        ikb1.Text = "pr3p4r3 fr06";
                        ikb1.CallbackData = "/prepare_frog";
                        ikb.Add(ikb1);

                        InlineKeyboardButton ikb2 = new InlineKeyboardButton();
                        ikb2.Text = "637 m3m35";
                        ikb2.CallbackData = "/get_memes";
                        ikb.Add(ikb2);

                        InlineKeyboardButton ikb3 = new InlineKeyboardButton();
                        ikb3.Text = "637 bu7hur7";
                        ikb3.CallbackData = "/get_buthurt";
                        ikb.Add(ikb3);

                        InlineKeyboardMarkup ikm = new InlineKeyboardMarkup(ikb);

                        await bot.SendTextMessageAsync(e.Message.Chat.Id,
                            "f0r u51n6 m3nu u53 /menu",
                            replyMarkup: ikm);

                        break;
                    case "/prepare_frog":
                        ReplyKeyboardMarkup rkm = new ReplyKeyboardMarkup(new KeyboardButton[] 
                        { "pr3p4r3 fr06 15 600d", "pr3p4r3 fr06 15 b4d" });
                        rkm.OneTimeKeyboard = true;

                        await bot.SendPhotoAsync(e.Message.Chat.Id,
                            @"https://iknowyourmeme.files.wordpress.com/2016/04/happy-sad-frog-05.jpg",
                            "d0 y0u r34l3 w4n7 70 pr3p4r3 fr06?", replyMarkup: rkm);
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
