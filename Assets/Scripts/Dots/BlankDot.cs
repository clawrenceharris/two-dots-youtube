using System;
using UnityEngine;

public class BlankDot : Dot, IColorable
{
    public DotColor Color { get => DotColor.Blank;}

    public void SetColor(DotColor color)
    {
        GetComponent<SpriteRenderer>().color = ColorSchemeManager.Instance.FromDotColor(DotColor.Blank);
    }
}