using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallModel : BallElement
{
    
    public int Flag;
    public static bool isBeKilled;
    public SpriteRenderer Sprite_renderer;
    
    
    void Start()
    {
        int _team = Random.Range(0,5);
        
        //give a team flag 
        Flag = _team;
        
        //provide a sprite color
        Sprite_renderer.sprite = appElement.Instance.app.model.Sprites [_team];
    }
    

}