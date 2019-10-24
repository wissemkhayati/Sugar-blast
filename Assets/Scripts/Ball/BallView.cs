using UnityEngine;

// BallView.cs

// Describes the Ball view and its features.
public class BallView : BallElement
{
    // Only this is necessary. Physics is doing the rest of work.
    // Callback called upon collision.
    // void OnCollisionEnter() { app.Notify(BounceNotification.BallHitGround,this); }

    void Update()
    {
        if (Input.GetMouseButtonUp (0))
        {
            ball.controller.OnClick();
        }
    }
}