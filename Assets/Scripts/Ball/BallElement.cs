using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallElement : MonoBehaviour
{
    // Gives access to the application and all instances.
    public BallApplication ball { get { return GetComponent<BallApplication>(); }}
}
