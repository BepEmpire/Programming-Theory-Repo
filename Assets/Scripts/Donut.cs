using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donut : Food
{
    protected override void Action()
    {
        objectRb.AddTorque(10.0f, 10.0f, 10.0f);
        transform.localScale = new Vector3(15.0f, 15.0f, 15.0f);
    }
}
