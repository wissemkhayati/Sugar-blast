using UnityEngine;

public class BallController : BallElement
{
    

    public void OnClick()
    {
        if (Input.GetMouseButtonUp (0)) {
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection (ray, Mathf.Infinity);
            
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == name)
                {
                    if (hit.collider.gameObject.GetComponent<Sensor_cmp>() == null)
                    {
                        BallModel.isBeKilled = false;
                        hit.collider.gameObject.AddComponent<Sensor_cmp>();
                    }
                    
                }
            }
        }
    }
}
