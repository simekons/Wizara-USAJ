﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoverLife : MonoBehaviour
{
    public int lifeToRecover, timeToDestroy;
    private void Start()
    {
        Invoke("Destroy", timeToDestroy);
    }
    //cuando entra en colision destruye el objeto y avisa al GM de que hay que sumar vida
    private void OnTriggerEnter2D(Collider2D collision)
    { Life life = collision.gameObject.GetComponent<Life>();
        if ( life!= null){
        life.IncreaseLife(lifeToRecover);
        GameManager.instance.getTracker().sendEvent(new LifeDisapair(true));
        } 
        Destroy(this.gameObject);
    }
    void Destroy()
    {
        GameManager.instance.getTracker().sendEvent(new LifeDisapair(false));
        Destroy(this.gameObject);
    }
}

