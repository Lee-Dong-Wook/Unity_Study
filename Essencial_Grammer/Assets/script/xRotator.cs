using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xRotator : BaseRotator
{
    protected virtual void Rotate()
    {
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
