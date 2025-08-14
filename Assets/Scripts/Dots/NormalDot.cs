using UnityEngine;

public class NormalDot : Dot, IColorable
{
    private DotColor color;
    public DotColor Color { get => color; }

    public void SetColor(DotColor color)
    {
        
        this.color = color;
        GetComponent<SpriteRenderer>().color = ColorSchemeManager.Instance.FromDotColor(color);
    }
}