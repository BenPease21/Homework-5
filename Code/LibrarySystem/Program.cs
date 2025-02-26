using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;

public class Book
{
    //Variables
    private string title;
    private string author;
    private int yearPublished;

    //Gets&Sets
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int YearPublished
    {
        get { return yearPublished; }
        set { yearPublished = value; }
    }

    //Constructors 
    public Book() {/* empty constructor */}
    public Book(string aTitle, string aAuthor, int aYearPublished)
    {
        Title = aTitle;
        Author = aAuthor;
        yearPublished = aYearPublished;
    }

    //Methods
    public override string ToString()
    {
        return $"{Title} by {Author}, {YearPublished}";
    }
}


public class Ebook : Book
{
    //Variables
    string fileSize;

    //Gets&Sets
    string FileSize
    {
        get { return fileSize; }
        set { fileSize = value; }
    }

    //Constructor 
    public Ebook() {/* empty constructor */}
    public Ebook(string aTitle, string aAuthor, int aYearPublished, string aFileSize) : base(aTitle,aAuthor,aYearPublished)
    {
        fileSize = aFileSize;
    }

    //Methods

    public override string ToString()
    {
        return $"{base.ToString()} \n File Size = {FileSize} MB";
    }
}


public class PrintedBook : Book
{
    //Variables 
    double pageCount = 0;

    //Gets&Sets
    double PageCount
    {
        get { return pageCount; }
        set { pageCount = value; }
    }

    //Constructor 
    public PrintedBook() { }
    public PrintedBook(string aTitle, string aAuthor, int aYearPublished, int aPageCount) : base(aTitle, aAuthor, aYearPublished)
    {
        pageCount = aPageCount;
    }

    //Methods
    public override string ToString()
    {
        return $"{base.ToString()} \n Page Count = {PageCount}";
    }
}

public class program
{
    static void Main(string[] args)
    {
        PrintedBook HowToTrain = new PrintedBook("How To Train Your Draogn", "Cressida Cowell", 2003, 243);
        Ebook GreatExpect = new Ebook("Great Expectations", "Charles Dickens", 1861, "13.7");

        object[] BookShelf = { HowToTrain, GreatExpect };

        foreach (object obj in BookShelf)
        {Console.WriteLine(obj.ToString() + "\n\n");}

    }
}