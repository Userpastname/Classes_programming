public class Word
{
    private string _text = "";
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        if (_text != "," || _text != ".")
        {
            _isHidden = true;
        }


    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            return ReturnUnderscores(_text);
        }
    }

    public string ReturnUnderscores(string text)
    {
        int length = text.Length;
        string underscores = "";
        for (int i = 0; i < length; i++)
        {
            underscores += "_";
        } 
        return underscores;
    }
}