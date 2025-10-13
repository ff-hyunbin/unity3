using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControler : MonoBehaviour
{
    public float dropSpeed = 0.1f;
    public float arrowRadius = 0.3f;
    public float playerRadios = 0.7f;

    Transform playerTransfom;
    // Start is called before the first frame update
    void Start()
    {
        playerTransfom = GameObject.Find("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropSpeed, 0);

        if(transform.position.y < -7f)
        {
            Destroy(gameObject);    
        }

        CheckCollision();
    }
    void CheckCollision()
    {
        Vector2 arrowPosition = transform.position;
        Vector2 playerPosition = playerTransfom.position;
        float Distance = (arrowPosition - playerPosition).magnitude;

        //충돌 발생
        if(Distance < arrowRadius + playerRadios)
        {
            Destroy (gameObject);
        }
    }
}
