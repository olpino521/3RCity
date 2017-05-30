﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasuraenFabrica : MonoBehaviour
{

    Text txt;
    public int currentscore;
    private Ciudad city;

    // Use this for initialization
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        city = Ciudad.InstanciaCiudad;
    }

    // Update is called once per frame
    void Update()
    {
        currentscore = city.NumBasuraRecogida;
        txt.text = "" + currentscore;
    }

}
