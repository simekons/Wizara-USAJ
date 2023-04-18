using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizaraTelemetry.Events;

public class LifeDisapair : GameEvent
{
    // Constructora de DashStartEvent.
    public LifeDisapair(bool picked) : base("LifeDispair")
    {
        data.Add("Picked",picked);
    }
}
