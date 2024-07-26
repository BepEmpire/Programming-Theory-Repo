using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CupcakesText;
    public Text DonutsText;
    public Text MushroomsText;

    private int Cupcakes = 0;
    private int Donuts = 0;
    private int Mushrooms = 0;

    private void Start()
    {
        Cupcakes = 0;
        Donuts = 0;
        Mushrooms = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cupcake")
        {
            Cupcakes += 1;
            CupcakesText.text = "Cupcakes : " + Cupcakes;
        }
        else if (other.tag == "Donut")
        {
            Donuts += 1;
            DonutsText.text = "Donuts : " + Donuts;
        }
        else if (other.tag == "Mushroom")
        {
            Mushrooms += 1;
            MushroomsText.text = "Mushrooms : " + Mushrooms;
        }
    }
}
