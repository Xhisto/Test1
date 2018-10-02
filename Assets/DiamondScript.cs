using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    public int MyValue;
    public SpriteRenderer rend;
    public Color newColor;

    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
