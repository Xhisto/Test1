using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    public int MyValue;
    public SpriteRenderer rend;
    public Color newColor;
    public Transform OtherSide;


    [Range(-720, 720)]
    public float rotationspeed;

    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(0.5f, 1f, 0.25F);
        //OtherSide.position = new Vector3(3, 2, OtherSide.position.z);:
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(100F * Time.deltaTime, 0, 0, Space.Self);
        }

    }
}
