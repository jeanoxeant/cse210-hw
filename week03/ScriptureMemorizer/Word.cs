using System;



public class Word
{
    private string _text;
    private bool _isHidden;
    public void Hide()
    {
        _isHidden = true;
    }

    /*public void Show()
    {

    }*/

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }

    public Word(string text)
    {
        this._text = text;
        _isHidden = false;
    }

}