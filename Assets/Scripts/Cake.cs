using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : Food
{
    protected override void Action()
    {
        Debug.Log("Hello, my name is Cake");
    }
}
