using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;
    GameDirector gameDirector;

    AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.aud = GetComponent<AudioSource>();
        gameDirector = 
            GameObject.Find("GameDirector").GetComponent<GameDirector>();
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Àâ¾Ò´Ù!");
        if (other.gameObject.tag.Equals("apple"))
        {
            Debug.Log("»ç°ú");
            this.aud.PlayOneShot(appleSE);
            gameDirector.GetApple();
        }
        else if (other.gameObject.tag.Equals("bomb"))
        {
            Debug.Log("ÆøÅº");
            this.aud.PlayOneShot(bombSE);
            gameDirector.GetBomb();
        }

        Destroy(other.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) 
            { 
              float x = Mathf.RoundToInt(hit.point.x);
              float z = Mathf.RoundToInt(hit.point.z);
              transform.position = new Vector3(x, 0, z);
            }
        }
    }
}
