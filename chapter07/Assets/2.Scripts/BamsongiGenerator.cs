using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    // Update is called once per frame
    void Update()
    {
        GameObject go = Instantiate(bamsongiPrefab);
        go.transform.position = new Vector3(transform.position.x,
            transform.position.y + 1,
            transform.position.z + 1);
        go.GetComponent<BamsongiController>().Shoot(new Vector3)(0, 500, 2000);
    }
}
