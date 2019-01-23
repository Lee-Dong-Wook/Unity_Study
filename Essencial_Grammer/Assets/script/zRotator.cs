using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zRotator : BaseRotator
{
	protected override void Rotate()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}


