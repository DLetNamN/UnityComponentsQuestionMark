using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yaes : MonoBehaviour
{

    public int a;
    public Color orange;
    public SpriteRenderer rend;
    public float rotationSpeed = 360f;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-2f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-2f / 2 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        }
        
    }
}
