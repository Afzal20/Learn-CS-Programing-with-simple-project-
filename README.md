# Learn-CS-Programing-with-simple-project-
It a Vary simple project to learn C sharp programing. I thing it's the best way to learn any programing language

#### In this project my gole is learn C sharp programing by a simple project. So, I make a simple project with it because I know how apply it other language

###### At first I can plan for this project how i can make this project
in this project user can add, remuve, see movie details and also See movie list. Now we have 4 basic function 
```csharp 
    public void addMovie(string movieName) { }
    public void removeMovie(string name) { } 
    public void showMovieList() { }
    public void showMovie() { } 
```

###### Now i need to impliment all function 

   ## addMovie( )  funcrion :

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

```csharp
public void showMovie()
{
    Console.WriteLine("Enter Move name ");
    string name = Console.ReadLine();
    readFile(FilePath + "/" + name + ".txt");
}
```

### In this function there are a function called readFile( ) which is prinvate function a private function naw we need to impliment this

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

## addMovie( )  funcrion :

``` csharp
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

##  removeMovie( )  funcrion : in this function just delete that file
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
