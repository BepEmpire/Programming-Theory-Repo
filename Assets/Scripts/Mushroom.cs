using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : Food
{
    protected override void Action()
    {
        objectRb.AddTorque(5.0f, 5.0f, 5.0f);
    }
}
