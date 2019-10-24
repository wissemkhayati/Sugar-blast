using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class for all elements in this application.
public class appElement : Singleton_cmp<appElement>
{
    // Gives access to the application and all instances.
    public appApplication app { get { return GameObject.FindObjectOfType<appApplication>(); }}
}