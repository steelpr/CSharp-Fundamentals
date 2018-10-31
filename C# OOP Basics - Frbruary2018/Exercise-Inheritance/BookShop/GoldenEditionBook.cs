using System;
using System.Collections.Generic;
using System.Text;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price)
    {

    }

    private string title;
    private string author;
    private decimal price;

    public override string Title
    {
        get { return base.Title; }
        set { base.Title = value; }
    }

    public override string Author
    {
        get { return base.Author; }
        set { base.Author = value; }
    }

    public override decimal Price
    {
        get
        {
            return base.Price * 1.3m;
        }
        set { base.Price = value; }
    }
}
