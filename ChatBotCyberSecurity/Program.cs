
using ChatBotCyberSecurity;

Utils utils = new Utils();
Console.WriteLine(utils.MakeTextBold("Welcome to my chatbot"));
AudioPlayer audioPlayer= new AudioPlayer();
audioPlayer.Play();


ImageDisplay display = new ImageDisplay();
display.Show();

Greeting greeting = new Greeting();
greeting.Greet();
Console.ReadKey();
