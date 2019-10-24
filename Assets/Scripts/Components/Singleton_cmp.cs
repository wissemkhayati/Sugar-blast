using UnityEngine;
using System;

public class Singleton_cmp<T> : MonoBehaviour where T : class
{
    static Singleton_cmp<T> instance;

    public static T Instance
    {
        get { return instance as T; }
    }

    protected virtual void Awake()
    {
        instance = this;
    }

}