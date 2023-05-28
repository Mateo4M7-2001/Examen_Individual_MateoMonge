using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ButtonController : MonoBehaviour
{
    public event Action<int> ScoreUpdated;
    public abstract void ButtonsCounts();
}
