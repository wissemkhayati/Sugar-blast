using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Sensor_cmp : appElement
{
    private RaycastHit2D _hit;
    private float _sensibility;

    void Start()
    {
        GetComponent<Rigidbody2D>().simulated = false;
        _sensibility = 1f;
        
    }


    void Update(){
        
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
  
         
          _hit = Physics2D.Raycast(origin, up, _sensibility);
          onHit(_hit);
          _hit = Physics2D.Raycast(origin, upRight, _sensibility);
          onHit(_hit);
          _hit = Physics2D.Raycast(origin, upLeft, _sensibility);
          onHit(_hit);
          _hit = Physics2D.Raycast(origin, down, _sensibility);
          onHit(_hit);
          _hit = Physics2D.Raycast(origin, downRight, _sensibility);
          onHit(_hit);
          _hit = Physics2D.Raycast(origin, downLeft, _sensibility);
          onHit(_hit);
          _hit = Physics2D.Raycast(origin, right, _sensibility);
          onHit(_hit);
          _hit = Physics2D.Raycast(origin, left, _sensibility);
          onHit(_hit);
  
          
          //the last bubble
          if (BallModel.isBeKilled)
          {
              Destroy(gameObject);
          }
          else
          {
              //reset clicked bubble if hasn't other bubbles arround
              GetComponent<Rigidbody2D>().simulated = true;
              Destroy(GetComponent<Sensor_cmp>());

          }
      }
  
      public void onHit(RaycastHit2D hit)
      {
          
          //
          if (hit.collider != null && hit.collider.tag != "ground")
          {
             
              if (hit.collider.gameObject.GetComponent<BallModel>().Flag == GetComponent<BallModel>().Flag)
              {
                 
                  if (hit.collider.gameObject.GetComponent<Sensor_cmp>() == null)
                  {
                      hit.collider.gameObject.AddComponent<Sensor_cmp>();
                      BallModel.isBeKilled = true;
                  }
              }
              //app.Notify(BounceNotification.BallHitBall, hit.collider.gameObject);            
              
          }
      }
  
   
}
