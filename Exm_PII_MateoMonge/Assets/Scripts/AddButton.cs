using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButton : ButtonController
{
    public enum Buttons
    {
        one, two, three, four
    }
    public Buttons buttons;

    public override void ButtonsCounts()
    {
        switch (buttons)
        {
            case Buttons.one:
                ScoreManager.GetInstance().MoreScore(1);
                break; 
            case Buttons.two:
                ScoreManager.GetInstance().MoreScore(2);
                break; 
            case Buttons.three:
                ScoreManager.GetInstance().MoreScore(3);
                break;
            case Buttons.four:
                ScoreManager.GetInstance().MoreScore(4);
                break;
        }

        
    }
}
