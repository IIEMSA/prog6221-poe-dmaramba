# Introduction

This project saves as a template that can be used as a guideline for your POE project. If you have not created a new project , use Visual Studio 2022 to create a new project, give your project a name.

- Avoid ***numbers and spaces*** in the name
- Capitalise each first letter of every word on your project name e.g if your project is named chatboxsybersecurity , the name should be ChatBotCyberSecurity


## Image and Audio file

Create a folder to add image and audio file in you project, you can name this folder any name of your choice, avoid number in your folder anmes
- I have added a logo in the <b>files</b> folder and also an audio file, create an audio files as per the specifications in your POE Guideline
- Please see an example of my chatbox logo in the files folder, create your own log and dont reuse the same as this one

    ![](ChatBotCyberSecurity/files/chatbot.png)

## Project dependencies


The project will require the following libraries to load images in ASCII format and also to play your welcome voice note. These packages can be installed via [Nuget Package Manager](https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio), please refer to this link for more information

- Below are the required packages
   - System.Drawing.Common
   - System.Windows.Extensions
 
### How to add the logo to the code?

- Add your logo in the folder that you have created
- In the <b>ImageDisplay.cs</b> file
    ```
     string imagePath = "files/chatbot.png";
    ```
    - replace the <b>files/chatbot.png</b> with  your folder and the name of your logo

 
### How to add audio file to the code?

- Add your audio file in the folder that you have created
- The audio file should be a .wav file, you can use this [WAV Convertor](https://www.freeconvert.com/wav-converter) to convert an audio to .wav file
- In the <b>AudioPlayer.cs</b> file
    ```
    string filePath = "files/welcome_audio.wav"
    ```
    - replace the <b>files/welcome_audio.wav</b> with your folder and the name of your logo
 
 ![happy coding](ChatBotCyberSecurity/files/happy_coding.jpg)
