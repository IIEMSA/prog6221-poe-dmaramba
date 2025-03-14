
using ChatBotCyberSecurity;

Utils utils = new Utils();
Console.WriteLine(utils.MakeTextBold("Welcome to my chatbot"));
AudioPlayer audioPlayer= new AudioPlayer();
audioPlayer.Play();


ImageDisplay display = new ImageDisplay();
display.Show();

//load 
Library library = new Library();
library.LoadData();
Greeting greeting = new Greeting();
greeting.Greet();
Console.ReadKey();
