using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    GenerateTarget gt;

    // Start is called before the first frame update
    void Start()
    {
        gt = GameObject.FindObjectOfType<GenerateTarget>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals("bamsonggi"))
        {
            gt.Generate();
            //Destroy(Collision.gameObjedct);
            Destroy(gameObject);
    }
}
}
