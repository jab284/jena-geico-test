

class Book
{
    /*  NOTES
    General Structure to Models:
        - fields (Properties)
        - constructors
        - methods

    access_modifiers - 
        * public (can be used anywhere in application)
        * private (can only be used in context of that particular class)
        * protected (extends power of private - has access in class and derived classes)
        * internal (can be accessed within same assembly - assembly is directory or folder in which it is located in >**name space**)
    */

    //Vocab of the Day:  Encapsulation  - 1st Pillar of OOP - Object Oriented Programming
    /*  * Hiding/Protecting out data to further control who has access
        * This is not to "secure or encrypt" our data. 
        * Make *private* fields
        * Make *public* methods for accessing and manipulating those fields
                - Accessing the field: Accessors -> Getters  ex Get Title, Get
                - Modifying the field:  Modifiers/Mutators -> Setters
        * Wraps code in a method - shows what you do - but not how you do - controls who sees *how* you do it

    */
/*
     Properties
    string title;
    string author;
    int pages;
    */

    //Alternative Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }



    //Constructors
    public Book()
    {

    }

    //Constructor
    public Book(string title, string author, int pages)
    {
        /*   with "this"
        this.title = title;
        this.author = author;
        this.pages = pages;
        */

        Title = title;
        Author = author;
        Pages = pages;
    }


    // Getters and Setters
    /*
    public string GetTitle()   //**Get ->has return so use type
    {
        return title;
    }
    public void SetTitle(string title)  //**Set ->use void as has no return
    {
        this.title = title;
    }
    */

    //Methods

    //ToString
}