using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Social_Network_Rental.Negocio;
using Social_Network_Rental.Entidad;
using System.Collections;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
namespace Social_Network_Rental.Presentacion
{
    public partial class FrmDetalleInmueble : Form
    {
        public string numero_cel;
        static TelegramBotClient Bot;
        public int Id_usuar;
        public FrmDetalleInmueble()
        {
            InitializeComponent();
            Bot = new TelegramBotClient("1483585119:AAHksA4v6OYtZqQAf4All7isyXGnwfDXAsk");
            var me = Bot.GetMeAsync().Result;

            Bot.OnMessage += Bot_OnMessage; 
            //Método que se ejecuta cuando se recibe un callbackQuery
            Bot.OnCallbackQuery += BotOnCallbackQueryReceived;

            //Método que se ejecuta cuando se recibe un error
            Bot.OnReceiveError += BotOnReceiveError;
            Bot.StartReceiving();
        }
        private async void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {

            var message = e.Message;

            if (message == null || message.Type != MessageType.Text) return;

            switch (message.Text.Split(' ').First())
            {
                //Enviar un inline keyboard con callback
                case "/Opcion1":

                    //Simula que el bot está escribiendo
                    await Bot.SendChatActionAsync(message.Chat.Id, ChatAction.Typing);

                    await Task.Delay(20);

                    var keyboardEjemplo1 = new InlineKeyboardMarkup(new[]
                    {
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(
                            text:"Logo",
                            callbackData: "imagen"),
                        InlineKeyboardButton.WithCallbackData(
                            text:"Ubicación ",
                            callbackData: "venu"),
                    },
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(
                            text:"Informacion",
                            callbackData: "formato"),
                        InlineKeyboardButton.WithCallbackData(
                            text:"Contacto",
                            callbackData: "contacto"),
                    },
 
                });

                    await Bot.SendTextMessageAsync(
                        message.Chat.Id,
                        "Elija una opción",
                        replyMarkup: keyboardEjemplo1);
                    break;
                case "/Opcion2":

                    var keyboardEjemplo2 = new InlineKeyboardMarkup(new[]
                    {
                    new []
                    {
                        InlineKeyboardButton.WithCallbackData(
                            text:"Registrate",

                            callbackData: "keyboard"),
                        InlineKeyboardButton.WithCallbackData(
                            text:"ver inmueble",

                            callbackData: "reply"),

                    },

                });

                    await Bot.SendTextMessageAsync(
                        message.Chat.Id,
                        "Elija una opción",
                        replyMarkup: keyboardEjemplo2);
                    break;

                //Mensaje por default
                default:
                    const string usage = @"
                Seleccione una opcion:
                /Opcion1 - Social Network Rental Property
                /Opcion2 - Interaccion ";

                    await Bot.SendTextMessageAsync(
                        message.Chat.Id,
                        text: usage,
                        replyMarkup: new ReplyKeyboardRemove());
                    
                    break;

            }
            
        }

        private  async void BotOnCallbackQueryReceived(object sender, CallbackQueryEventArgs callbackQueryEventArgs)
        {
            string Celular = "921118911";

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pibimagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            string Descripcion, direccion, numhabitaciones, ciudad,id;
            direccion = Convert.ToString(txtdireccion.Text);
            numhabitaciones = Convert.ToString(txtnumero.Text);
            ciudad = Convert.ToString(txtciudad.Text);
            Descripcion = Convert.ToString(txtdescripcion.Text);
            var callbackQuery = callbackQueryEventArgs.CallbackQuery;   
            
            switch (callbackQuery.Data)
            {
                case "keyboard":

                    var celular = Bot.GetMeAsync().Result;

                    await Bot.SendTextMessageAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        text: $"Ingrese numero :");
                        var numero = Bot.GetMeAsync().Result;
                    numero_cel = Convert.ToString(numero);

                    break;


                case "formato":
                    await Bot.SendTextMessageAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        text: "<b>Social</b>, <strong> Network Rental</strong>",
                        parseMode: ParseMode.Html
                        );
                    await Bot.SendTextMessageAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        text: "<i>Visita Nuestra Web</i>, <em></em>",
                        parseMode: ParseMode.Html
                        );
                    await Bot.SendTextMessageAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        text: "<a href='https://www.blogger.com/blog/post/edit/preview/6196096168699935390/7736692972949584608'>inline URL</a>",
                        parseMode: ParseMode.Html
                        );
                    break;

                case "venu":
                    await Bot.SendVenueAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        latitude: 9.932551f,
                        longitude: -84.031086f,
                        title: "Social Netwoork Rental",
                        address: "Av. la cultura Nº 19, Tacna"
                        );
                    break;

                case "imagen":
                    await Bot.SendPhotoAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        photo: "https://1.bp.blogspot.com/-Q1cc9_CGV0c/X_ADTaTjrkI/AAAAAAAAM9I/HpGsevaK0O0AnoW-iM172UUUB8zse9y3gCLcBGAsYHQ/s664/Logo.png"
                        );
                    break;

                case "animation":
                    await Bot.SendAnimationAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        animation: "https://techcrunch.com/wp-content/uploads/2015/08/safe_image.gif?w=730&crop=1"
                        );
                    break;
                    

                case "video":
                    await Bot.SendVideoAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        video: "https://res.cloudinary.com/dherrerap/video/upload/v1560039252/WhatsApp_Video_2019-06-08_at_6.10.54_PM.mp4"
                        );
                    break;

                case "reply":
                    await Bot.SendTextMessageAsync(
                  chatId: callbackQuery.Message.Chat.Id,
                  text: "Informacion del Arrendador: "+Celular+" \n"+
                  direccion + "\n" +
                        ciudad + "\n" +
                        numhabitaciones + "\n" +
                        Descripcion);
                    await Bot.SendPhotoAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        photo: "https://1.bp.blogspot.com/-WrryhAjjz3Y/X_AGk0Ig2RI/AAAAAAAAM9U/m2aH3leN6EEmE4LLcJmuzIPxeDFQXqc4ACLcBGAsYHQ/s320/casa2.jpg"
                        );
                    break;

                case "contacto":
                    await Bot.SendContactAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        phoneNumber: "51921118910",
                        firstName: "Carlos ",
                        lastName: "Maldonado "
                        );
                    break;

                case "forceReply":
                    await Bot.SendTextMessageAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        text: "Forzar respuesta a este mensaje",
                        replyMarkup: new ForceReplyMarkup());
                    break;

                case "reenviar":
                    await Bot.ForwardMessageAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        fromChatId: callbackQuery.Message.Chat.Id,
                        messageId: callbackQuery.Message.MessageId
                        );
                    break;
            }
        }

        private static void BotOnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine("Received error: {0} — {1}",
                receiveErrorEventArgs.ApiRequestException.ErrorCode,
                receiveErrorEventArgs.ApiRequestException.Message);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void pcbcerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //netodo mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema SNR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //netodo mensaje correcto 
        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema SNR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if(rs==DialogResult.OK)
            {
                pibimagen.Image = Image.FromFile(fo.FileName);
            }
        }
        public string celular;
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtciudad.Clear();
            txtcodigo.Clear();
            txtdescripcion.Clear();
            txtdireccion.Clear();
            txtnumero.Clear();
            txtprecio.Clear();
        }

        
        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pibimagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            try
            {
                string Rpta = "";
                if (txtdireccion.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en alguno campos....");
                    erroralerta.SetError(txtdireccion, "Ingrese Direccion");
                }
                else
                {
                    Rpta = InmuebleNegocio.Insertar(Id_usuar, txtdireccion.Text.Trim(), txtnumero.Text.Trim(), txtciudad.Text.Trim(), txtdescripcion.Text.Trim(),CboEstado.Text.Trim(), txtprecio.Text.Trim(), ms.GetBuffer());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Se agrego el registro correctamente.....");
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmDetalleInmueble_Load(object sender, EventArgs e)
        {
            txtcodigo.Text=Convert.ToString(Id_usuar);
        }

        private void pcbminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
