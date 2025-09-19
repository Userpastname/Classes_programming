using System.Numerics;
using Microsoft.VisualBasic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private bool _allHidden = false;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] strings = text.Split(" ");

        for (int i = 0; i < strings.Length; i++)
        {
            Word wordword = new Word(strings[i]);
            _words.Add(wordword);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int numberHidden = 0;
        int totalHidden = 0;
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == true)
            {
                totalHidden++;
            }
        }
        if (totalHidden == _words.Count)
        {
            _allHidden = true;
        }
        else if (_words.Count - totalHidden > numberToHide)
        {
            while (numberHidden < numberToHide)
            {
                int wordNum = random.Next(0, _words.Count);
                if (_words[wordNum].IsHidden() == false)
                {
                    _words[wordNum].Hide();
                    numberHidden++;
                }
            }
        }
        else
        {
            numberToHide = _words.Count - totalHidden;
            while (numberHidden < numberToHide)
            {
                int wordNum = random.Next(0, _words.Count);
                if (_words[wordNum].IsHidden() == false)
                {
                    _words[wordNum].Hide();
                    numberHidden++;
                }
            }
        }

    }

    public string GetDisplayText()
    {
        string text = "";
        text += _reference.GetDisplayText();
        text += " ";
        for (int i = 0; i < _words.Count; i++)
        {
            text += _words[i].GetDisplayText();
            text += " ";
        }
        return text;
    }

    public bool isAllHidden()
    {
        return _allHidden;
    }
}