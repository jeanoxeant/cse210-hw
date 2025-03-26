using System;


public class Reference
{
    /*
    public string GetDisplayText()
    {
        
    }
*/
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = verse;
        this._endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }

    public override string ToString() //Get the chapter's name and the reference ordered at the begging of the verse.
    {
        if (_startVerse == _endVerse)
        return $"{_book} {_chapter}:{_startVerse}";
        else
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}