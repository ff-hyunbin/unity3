using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControler : MonoBehaviour
{
    float rotSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }
        
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
