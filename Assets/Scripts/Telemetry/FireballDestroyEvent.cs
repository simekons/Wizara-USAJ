using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizaraTelemetry.Events;

public class FireballDestroyEvent : GameEvent
{
    // Constructora de FireballDestroyEvent.
    public FireballDestroyEvent(CastHit ch) : base("FireballDestroy")
    {
        data.Add("Hit",ch);
    }
}
