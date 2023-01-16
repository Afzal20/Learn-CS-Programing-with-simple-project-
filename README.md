# Learn-CS-Programing-with-simple-project-
It a Vary simple project to learn C sharp programing. I thing it's the best way to learn any programing language

#### In this project my gole is learn C sharp programing by a simple project. So, I make a simple project with it because I know how apply it other language

###### At first I can plan for this project how i can make this project
in this project user can add, remuve, see movie details and also See movie list. Now we have 4 basic function 

$${\color{Red}C-Sharp }$$

```csharp 
    public void addMovie(string movieName) { }
    public void removeMovie(string name) { } 
    public void showMovieList() { }
    public void showMovie() { } 
```

## At first I Want to impliment Main 
$${\color{Red}C-Sharp }$$
```csharp
using ConsoleApp1;

namespace Program
{
    class Program
    {   
        static void Main(string[] args)
        {
            {
                Console.Title = "MOVIE LIST";
                MovieFunctions movie = new MovieFunctions();
                while (true)
                {
                    Console.WriteLine("1. Add A nwe movie\n2. Find your movie");
                    Console.WriteLine("3. Remove movie\n4. Show movie list ");
                    Console.WriteLine("0. Exit\n");

                    Console.WriteLine("Enter Your Choice ... ");
                    String Cho = Console.ReadLine();
                    try
                    {
                        int Ch = Convert.ToInt32(Cho);
                        if (Ch == 0) break;
                        if (Ch == 1)
                        {
                            Console.WriteLine("Enter movie Name .... ");
                            String Name = Console.ReadLine();
                            movie.addMovie(Name);
                            Console.WriteLine("Movie is added ");
                        }
                        if (Ch == 2)
                        {
                            movie.showMovie();
                        }
                        if (Ch == 3)
                        {
                            Console.WriteLine("Enter move name .... ");
                            string name = Console.ReadLine();
                            movie.removeMovie(name);
                        }
                        if (Ch == 4)
                        {
                            movie.showMovieList();
                        }
                    }

                    catch
                    {
                        if (Cho.ToLower() == "Clear".ToLower()) Console.Clear();
                        else if (Cho.ToLower() == "Exit".ToLower()) break;
                    }
                }
            }
        }
    }
}
```

###### Now i need to impliment all function 

## addMovie( )  funcrion :
$${\color{Red}C-Sharp }$$

```csharp
    public void addMovie(string movieName)
        {
            this.name = movieName;
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter Ratings ... ");
            this.ratings = Console.ReadLine();

            Console.WriteLine("ReleseYear ... ");
            this.releseYear = Console.ReadLine();

            Console.WriteLine("Which Language ... ");
            this.Language = Console.ReadLine();

            Console.WriteLine("Herro Name ?... ");
            this.Herro = Console.ReadLine();

            Console.WriteLine("Herroin Name... ");
            this.Herroin = Console.ReadLine();

            Console.WriteLine("who was villan ... ");
            this.villan = Console.ReadLine();

            Console.WriteLine("Do you have any links To Dowenload or see this movie... ");
            this.linksToDowenload = Console.ReadLine();

            Console.WriteLine("Is it Aavailable On Youtub ? ... ");
            this.AavailableOnYoutub = Console.ReadLine();

            Console.WriteLine("Enter movietype ... ");
            this.movietype = Console.ReadLine();

            Console.WriteLine("Country ... ");
            this.country = Console.ReadLine();

            wrightIntoFile();
            if (File.Exists(FilePath + "/" +movieName + ".txt"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(FilePath + "/" + movieName + ".txt");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
```

in this function we have wrightIntoFile() function which is private function to write into file, in this function i can write movie details into file.

##### So, I need to impliment this private function
#
$${\color{Red}C-Sharp }$$
```csharp
    private void wrightIntoFile()
        {
            string fileName = FilePath + "/" + this.name + ".txt";

            try
            {
                if (File.Exists(fileName))
                {
                    Console.WriteLine(fileName+ " is allrady exisist\nDo you want to update it?");
                    Console.WriteLine("1. Yes\n2. No");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    if(ch == 1)
                    {
                        File.Delete(fileName);
                    }
                    else
                    {
                        return;
                    }
                }

                using (FileStream fs = File.Create(fileName))
                {   
                    byte[] name = new UTF8Encoding(true).GetBytes(this.name);
                    byte[] ratings = new UTF8Encoding(true).GetBytes(this.ratings);
                    byte[] releseYear = new UTF8Encoding(true).GetBytes(this.releseYear);
                    byte[] Language = new UTF8Encoding(true).GetBytes(this.Language);
                    byte[] Herro = new UTF8Encoding(true).GetBytes(this.Herro);
                    byte[] villan = new UTF8Encoding(true).GetBytes(this.villan);
                    byte[] Herroin = new UTF8Encoding(true).GetBytes(this.Herroin);
                    byte[] linksToDowenload = new UTF8Encoding(true).GetBytes(this.linksToDowenload);
                    byte[] AavailableOnYoutub = new UTF8Encoding(true).GetBytes(this.AavailableOnYoutub);
                    byte[] movietype = new UTF8Encoding(true).GetBytes(this.movietype);
                    byte[] country = new UTF8Encoding(true).GetBytes(this.country);
                    byte[] lineBreak = new UTF8Encoding(true).GetBytes("\n");
                    
                    fs.Write(name, 0, name.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);

                    fs.Write(ratings, 0, ratings.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);

                    fs.Write(releseYear,0, releseYear.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);

                    fs.Write(Language, 0, Language.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);

                    fs.Write(Herro, 0, Herro.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);

                    fs.Write(Herroin, 0, Herroin.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);

                    fs.Write(villan, 0, villan.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);

                    fs.Write(linksToDowenload, 0, linksToDowenload.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);

                    fs.Write(AavailableOnYoutub, 0, AavailableOnYoutub.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);

                    fs.Write(movietype, 0, movietype.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);

                    fs.Write(country, 0, country.Length);
                    fs.Write(lineBreak, 0, lineBreak.Length);
                }

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            catch (Exception Ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Ex.ToString());
            }
        }
```

## In Next step i need to impliment showMovie( )  funcrion :
$${\color{Red}C-Sharp }$$
```csharp
public void showMovie()
{
    Console.WriteLine("Enter Move name ");
    string name = Console.ReadLine();
    readFile(FilePath + "/" + name + ".txt");
}
```

### In this function there are a function called readFile( ) which is prinvate function a private function naw we need to impliment this
$${\color{Red}C-Sharp }$$
```csharp
private void readFile(string file)
        {
            int lineNumber = 0;

            string[] ExtentionOFVariable = 
            {
                "Movie Name is : ",
                "Ratings : ",
                "releseYear : ",
                "Language : ",
                "Herro : ",
                "Herroin : ",
                "villan : ",
                "linksToDowenload : ",
                "AavailableOnYoutub : ",
                "movietype : ",
                "country : ",
            };

            try
            {
                StreamReader sr = new StreamReader(file);
                string line;
                while (true)
                {
                    line = sr.ReadLine();

                    Console.Write(ExtentionOFVariable[lineNumber] + " " + line + "\n");

                    if (line == null) break;
                    lineNumber += 1;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine();
            }
        }
```

hear is some complicate things that is ```string[] ExtentionOFVariable```. and 
```code
Console.Write(ExtentionOFVariable[lineNumber] + " " + line + "\n");
```


so concept is clear if explain using ```python``` that is 
$${\color{Red} Python }$$
```python
name = "Name"
Ratings = "Ratings"
releseYear = "releseYear"
Language = "Language"
Herro = "Herro"
villan = "villan"
Herroin = "Herroin"
linksToDowenload = "linksToDowenload"
AavailableOnYoutub = "AavailableOnYoutub"
movietype = "movietype"
count = "country"


E = [ "Movie Name is : ",
    "Ratings : ",
    "releseYear : ", 
    "Language : ", 
    "Herro : ", 
    "villan : ", 
    "Herroin : ", 
    "linksToDowenload : ", 
    "AavailableOnYoutub : ", 
    "movietype : ", 
    "country : "
]

v = [name, 
    Ratings,
    releseYear,
    Language,
    Herro,
    villan,
    Herroin,
    linksToDowenload,
    AavailableOnYoutub,
    movietype,
    count,
]

for i in range(len(v)):
    print(E[i], v[i])
```

##  removeMovie( )  funcrion : in this function just delete that file
$${\color{Red}C-Sharp }$$
```csharp
public void removeMovie(string name)
{
    if (File.Exists(FilePath + "/" + name + ".txt"))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        File.Delete(FilePath + "/" + name + ".txt");
        Console.WriteLine("file was deleted");
        Console.ForegroundColor= ConsoleColor.White;
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(FilePath + "/" + name + " is not exists");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
```

Now, It's time to test this program 🥰 ! But here is a problem that is I need to give a lot of input  😌  many times because I will test my program, and I don't know where is any problem. I don't want to do this many times. So I will automat this using python 🤪

$${\color{Red} Python }$$

```python
import pyautogui
import time

name = "KGF2"
ratings = "5 Stars"
releseYear = "2022"
Language = "Hindi"
Herro = "Yash"
Herroin = "Srinidhi Shetty"
villan = "Sanjay Dutt"
linksToDowenload = "https://www.youtube.com/watch?v=lbknedbzPG0" 
AavailableOnYoutub = "Yes"
movietype = "Theatrical"
country = "INDIA" 

sleep_time = 3

details = [name, 
        ratings, 
        releseYear, 
        Language, 
        Herro, 
        Herroin, 
        villan, 
        linksToDowenload,
        AavailableOnYoutub,
        movietype,
        country
        ]

time.sleep(sleep_time)

for i in details:
    pyautogui.typewrite(i)
    pyautogui.press("enter")
```

if you want to do this like me you need to install python on your computer and then install only one module that is pyautogui
* ### to install install  pyautogui open your terminal and write 

``` terminal or cmd ```

```sh
pip install PyAutoGUI
```

writing will start after 3 seconds where your computer coursor, So you need to run this program after runing your c# project. If you want to change starting time you change only sleep_time value.
