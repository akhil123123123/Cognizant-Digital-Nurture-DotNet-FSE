using System;


// Product Interface
interface Document
{
    void Open();
}


// Concrete Products
class WordDocument : Document
{
    public void Open()
    {
        Console.WriteLine("Opening Word Document");
    }
}


class PdfDocument : Document
{
    public void Open()
    {
        Console.WriteLine("Opening PDF Document");
    }
}


// Creator Abstract Class
abstract class DocumentFactory
{
    public abstract Document CreateDocument();
}


// Concrete Creators
class WordFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new WordDocument();
    }
}


class PdfFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new PdfDocument();
    }
}


class Program
{
    static void Main(string[] args)
    {
        DocumentFactory factory;


        factory = new WordFactory();
        Document word = factory.CreateDocument();
        word.Open();


        factory = new PdfFactory();
        Document pdf = factory.CreateDocument();
        pdf.Open();
    }
}