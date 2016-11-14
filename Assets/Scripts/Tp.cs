using UnityEngine;
using System.Collections;

public class Tp : MonoBehaviour {
    public AudioClip tp;
    public AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyUp(KeyCode.R))
        {
            source.PlayOneShot(tp);
        }
    }
}
