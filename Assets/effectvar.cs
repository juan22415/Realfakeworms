﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class effectvar : MonoBehaviour {

    AreaEffector2D ae;
    public float timer;
    public Slider wind;
    public Text windchange;

	// Use this for initialization
	void Start () {
        timer = 20;
        ae = GetComponent<AreaEffector2D>();
        ae.forceMagnitude = Random.Range(-3f, 3f);
        wind.value = ae.forceMagnitude;

    }
	
	// Update is called once per frame
	void Update () {

        windchange.text = "Wind changes in: " + Mathf.Round(timer);
        timer -= Time.deltaTime;
        if (timer <0)
        {
            ae.forceMagnitude = Random.Range(-3f, 3f);
            wind.value = ae.forceMagnitude;
            
            timer = 20;
        }

	}

    
}
