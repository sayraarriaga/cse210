using System;

class Program
{
    static void Main(string[] args)
    {
        //comments for first video
        Comment c1 = new Comment();
        c1._commentName= "Angelica Lara";
        c1._comment= "Love this song!";
        Comment c2 = new Comment();
        c2._commentName= "Cecilia Canabal";
        c2._comment= "I dont even have a broken heart, but this song makes me feel like it was";
        Comment c3 = new Comment();
        c3._commentName= "Luka Arriaga";
        c3._comment= "This is a Master Piece!";
        Comment c4 = new Comment();
        c4._commentName= "Zeynep Dencer";
        c4._comment= "How can a 10 minute song can't be still enough!";


        // comments for second video
        Comment c5 = new Comment();
        c5._commentName= "Chantara27";
        c5._comment= "This will always be one my favorite songs by 3 doors down";
         Comment c6 = new Comment();
        c6._commentName= "Lorri Tadey";
        c6._comment= "and makes me cry  every time I play";
        Comment c7 = new Comment();
        c7._commentName= "Leo Mata";
        c7._comment= "These guys need an Emmy or a Golden Globe Equivalent for music.";

        // comments for third video
        Comment c8 = new Comment();
        c8._commentName= "Richard Bailey";
        c8._comment= "Thank your for your video";
         Comment c9 = new Comment();
        c9._commentName= "Hobbs23";
        c9._comment= "I am learning C# and i have been hard, thank your for your video it helped me a lot";
        Comment c10 = new Comment();
        c10._commentName= "Developer308";
        c10._comment= "Geat video, but can you make a video explaining the diference between arrays and lists?";

         // comments for fourth video
        Comment c11 = new Comment();
        c11._commentName= "Linda Rodriguez";
        c11._comment= "This look delicius, i have to try it!";
         Comment c12 = new Comment();
        c12._commentName= "Lady Torales";
        c12._comment= "What can i replace the eggs with?";
        Comment c13 = new Comment();
        c13._commentName= "Neyde Mata";
        c13._comment= "i already made this recipe, it taste delicius!!";

        // comments for fiveth video
        Comment c14 = new Comment();
        c14._commentName= "Sayra34";
        c14._comment= "Where is your dress for?";
         Comment c15 = new Comment();
        c15._commentName= "Panda56";
        c15._comment= "i Love your make up, i will attend to a weeding this weekend, i will try it";
        Comment c16 = new Comment();
        c16._commentName= "Karla Leon";
        c16._comment= "You look so beautiful, best wishes for your brither and his wife!";






        Video v1 = new Video();
        v1._title= "All too Well";
        v1._author = "Taylor swift";
        v1._lenght = 607.2; 
        v1._coments.Add(c1);
        v1._coments.Add(c2);
        v1._coments.Add(c3);
        v1._coments.Add(c4);
        v1.Display();

         Video v2 = new Video();
        v2._title= "Here by me";
        v2._author = "3 doors down";
        v2._lenght = 209.4; 
        v2._coments.Add(c5);
        v2._coments.Add(c6);
        v2._coments.Add(c7);
        v2.Display();

        Video v3 = new Video();
        v3._title= "How to work with Lists in C#";
        v3._author = "Code for begginers";
        v3._lenght = 500.3; 
        v3._coments.Add(c8);
        v3._coments.Add(c9);
        v3._coments.Add(c10);
        v3.Display();

        Video v4 = new Video();
        v4._title= "Bownies Recipe";
        v4._author = "Bake with me";
        v4._lenght = 1105.8; 
        v4._coments.Add(c11);
        v4._coments.Add(c12);
        v4._coments.Add(c13);
        v4.Display();

        Video v5 = new Video();
        v5._title= "Get ready with me for my brother wedding";
        v5._author = "Rossy Mcmichaels";
        v5._lenght = 1208.7; 
        v5._coments.Add(c14);
        v5._coments.Add(c15);
        v5._coments.Add(c16);
        v5.Display();

        





    }
}