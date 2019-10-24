using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Raycast_cmp : MonoBehaviour
{

    private float _sensibility;

    void Start()
    {
        _sensibility = 1f;
    }
    
    void Update()
    {      
        Vector3 origin = new Vector3(transform.position.x, transform.position.y, transform.position.z );
  
        
        Vector3 up = transform.TransformDirection(Vector3.up);
        Vector3 upRight = Quaternion.AngleAxis( 45.0f, Vector3.forward) * transform.right;
        Vector3 upLeft = Quaternion.AngleAxis( -45.0f, Vector3.forward) * transform.right;
        Vector3 down = transform.TransformDirection(Vector3.down);
        Vector3 downRight = Quaternion.AngleAxis( 45.0f, Vector3.forward) * -transform.right;
        Vector3 downLeft = Quaternion.AngleAxis( -45.0f, Vector3.forward) * -transform.right;
        Vector3 right = transform.TransformDirection(Vector3.right);
        Vector3 left = transform.TransformDirection(Vector3.left);
        
        
        Debug.DrawRay(origin, up * _sensibility, Color.green);
        Debug.DrawRay(origin, upRight * _sensibility, Color.yellow);
        Debug.DrawRay(origin, upLeft * _sensibility, Color.yellow);
        Debug.DrawRay(origin, down * _sensibility, Color.green);
        Debug.DrawRay(origin, downRight * _sensibility, Color.green);
        Debug.DrawRay(origin, downLeft * _sensibility, Color.green);
        Debug.DrawRay(origin, right * _sensibility, Color.green);
        Debug.DrawRay(origin, left * _sensibility, Color.green);
        
    }

    //public static void push()
    //{
    //    Transform spawner = GameObject.Find("SPAWNER").transform;
    //    Instantiate(Resources.Load("Bubble"), spawner);
    //}
}