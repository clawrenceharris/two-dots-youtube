using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Dot : MonoBehaviour
{
    [SerializeField] private DotType type;
    public DotType Type { get => type; }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
