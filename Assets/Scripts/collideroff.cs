using UnityEngine;
using System.Collections;

public class collideroff : MonoBehaviour {

    public float timer = 4.9f;
    // Use this for initialization
    void Start()
    {
        if (PlayerController.weapon == 2)
        {
            GetComponent<CircleCollider2D>().enabled = false;


        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            GetComponent<CircleCollider2D>().enabled = true;
        }


    }
}
