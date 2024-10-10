using System;

public class NotPossibleToOpenBrowser : Exception
{
    public NotPossibleToOpenBrowser(string browser, string website, Exception exception)
        : base("The browser " + browser
            + " could not open " + website
            + ".\nError: " + exception.Message) 
        {
        }
}