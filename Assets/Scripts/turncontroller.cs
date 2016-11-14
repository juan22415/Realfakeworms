using UnityEngine;
using System.Collections;

public class turncontroller : MonoBehaviour {

    public static int activeplayer=0;

  

	// Use this for initialization
	void Start () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


    }
}
