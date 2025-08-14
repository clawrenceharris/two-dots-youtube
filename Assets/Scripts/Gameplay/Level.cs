using NUnit.Framework;
using UnityEngine;


/// <summary>
/// Represents a game level with width and height of board and dots to spawn on the board.
/// </summary>
///
[CreateAssetMenu(fileName ="Level", menuName = "Scriptable Objects/Level")]
public class Level : ScriptableObject
{
    public int Width;
    public int Height;
    public DotType[] DotsToSpawn;

}