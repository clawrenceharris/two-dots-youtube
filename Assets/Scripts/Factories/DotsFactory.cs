using UnityEngine;

public class DotsFactory
{
    /// <summary>
    /// Create the dot that matches the given type and initializes its values
    /// </summary>
    public static Dot CreateDot(DotType type, int col, int row)
    {
        Dot dot = Object.Instantiate(PrefabLibrary.instance.GetDotPrefab(type), new Vector2(col, row) * Board.offset, Quaternion.identity);
        if (dot is IColorable colorable)
        {
            DotColor color = ColorSchemeManager.Instance.GetRandomColor();
            while (color == DotColor.Blank)
            {
                color = ColorSchemeManager.Instance.GetRandomColor();
            }
            colorable.SetColor(color);
        }

        return dot;

        
    }
}
