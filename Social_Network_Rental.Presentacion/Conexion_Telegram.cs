using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
namespace Social_Network_Rental.Presentacion
{
    public class Conexion_Telegram
    {
        static TelegramBotClient bot;
        public void ConexionTelegram()
        {
            bot = new TelegramBotClient("1483585119:AAHksA4v6OYtZqQAf4All7isyXGnwfDXAsk");
            var me = bot.GetMeAsync().Result;
            bot.OnMessage += Bot_OnMessage;
            bot.StartReceiving();

            bot.StopReceiving();
        }
        private async static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {

            string a = "Alfred es el mas gil de todos ";
            if (e.Message.Text != null)
            {


                await bot.SendTextMessageAsync(
                  chatId: e.Message.Chat.Id,
                  text: $"1. Visualizar " + "\n" +
                        $"2. Registrase" + "\n" +
                        $"3. Acerca de nosotros"

                  );
                if (e.Message.Text == "1")
                {
                    await bot.SendTextMessageAsync(
                  chatId: e.Message.Chat.Id,
                  text: "Alfred es gil");
                }
                else if (e.Message.Text == "2")
                {
                    await bot.SendTextMessageAsync(
              chatId: e.Message.Chat.Id,
              text: "Alfred es gil2");
                }
                else if (e.Message.Text == "3")
                {
                    await bot.SendTextMessageAsync(
              chatId: e.Message.Chat.Id,
              text: a);
                }
            }

        }


    }
    
}
