using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorSchemeManager : MonoBehaviour
{
    public Color32 Blank;
    public Color32 Red;
    public Color32 Yellow;
    public Color32 Green;
    public Color32 Blue;
    public Color32 Purple;
    public static ColorSchemeManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    public Color32 FromDotColor(DotColor color)
    {
        switch (color)
        {
            case DotColor.Blank: return Blank;
            case DotColor.Yellow: return Yellow;
            case DotColor.Red: return Red;
            case DotColor.Green: return Green;
            case DotColor.Purple: return Purple;
            case DotColor.Blue: return Blue;
            default: throw new ArgumentException("No color found that matches the given Dot Color");
        }
    }

    public DotColor GetRandomColor()
    {
        DotColor[] colors = (DotColor[])Enum.GetValues(typeof(DotColor));
        
        int rand = Random.Range(0, colors.Length);
        return colors[rand];
    }
}
