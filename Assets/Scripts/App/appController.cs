using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// BounceController.cs

// Controls the app workflow.
public class appController : appElement
{
    
    public int NumberOfBubble;
    public Transform Spawner;
    
    
    IEnumerator Start()
    {
        for (int i = 0; i < NumberOfBubble; i++)
        {
            GameObject Bubble_clone = Instantiate(Resources.Load("Ball"), Spawner) as GameObject;
            Bubble_clone.GetComponent<Rigidbody2D> ().velocity = 10 * transform.localScale.x * Bubble_clone.transform.up;
            yield return null;
        }
        
    }
    
}