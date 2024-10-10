using System;

public class WebsiteNameNotFoundException : Exception
{
    public WebsiteNameNotFoundException(string website)
        : base("Website " + website + " is not defined.") 
        {
        }
}