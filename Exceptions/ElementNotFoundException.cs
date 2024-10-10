using System;

public class ElementNotFoundException : Exception
{
    public ElementNotFoundException(string locatorType, string locator, Exception exception)
        : base("Element searched by " + locatorType + " " + locator + " not found.\nError: " + exception.Message) 
        {
        }
}