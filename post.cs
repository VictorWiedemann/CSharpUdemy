using System;

public class Post
{
    private int VoteCount { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }


    public Post(string title, string description)
    {
        if (title == null || description == null)
        {
            throw new NullReferenceException();
        }


        VoteCount = 0;
        Title = title;
        Description = description;
    }

    public void UpVote()
    {
        VoteCount++;
    }

    public void DownVote()
    {
        VoteCount--;
    }

    public void EditTitle(string title)
    {
        if (title == null)
        {
            throw new NullReferenceException();
        }

        Title = title;
    }

    public void EditDescription(string description)
    {
        if (description == null)
        {
            throw new NullReferenceException();
        }

        Description = description;
    }

    public void print()
    {
        Console.WriteLine("vote count {0}, title {1}, Description {2}", VoteCount, Title, Description);
    }
}