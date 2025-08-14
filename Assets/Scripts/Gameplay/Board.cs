
using UnityEngine;

public class Board : MonoBehaviour
{
    public int Width { get; private set; }
    public int Height { get; private set; }

    private DotType[] dotsToSpawn;
    public Dot[,] Dots { get; private set; }
    public static float offset = 2.5f;
    [SerializeField]private Level level;

    private void Start()
    {
        Init();
    }

    public void Init()
    {
        Dots = new Dot[level.Width, level.Height];
        Width = level.Width;
        Height = level.Height;
        dotsToSpawn = level.DotsToSpawn;
        SetupBoard();
    }

    private void SetupBoard()
    {
        SpawnDots();
    }

    private void SpawnDots()
    {
        //loop through all the dots
        for(int row = 0; row < Height; row++)
        {
            for(int col = 0; col < Width; col++)
            {
                Debug.Log(row + ", " + col);

                //if the dot is null then spawn dot

                if (Dots[col, row ] == null)
                {
                    SpawnDot(col, row);
                }
            }
        }

    }

    private void SpawnDot(int col, int row)
    {
        int rand = Random.Range(0, level.DotsToSpawn.Length - 1);
        DotType randomType = dotsToSpawn[rand];

        Dot dot = Instantiate(PrefabLibrary.instance.GetDotPrefab(randomType), new Vector2(col * offset, row * offset), Quaternion.identity);
        
        dot.name = "(" + col + ", " + row + ")";
        //put the dot gameobject in the transform of this board
        dot.transform.parent = transform;


    }
}
