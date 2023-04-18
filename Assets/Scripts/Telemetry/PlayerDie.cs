using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizaraTelemetry.Events;

public class PlayerDie : GameEvent
{
    // Constructora de DashStartEvent.
    public PlayerDie( ) : base("PlayerDie")
    {
    }
}
