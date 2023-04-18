using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizaraTelemetry.Events;

public class PlayerReceiveDamage : GameEvent
{
    // Constructora de DashStartEvent.
    public PlayerReceiveDamage( DamageType enemy) : base("PlayerReceiveDamage")
    {
        data.Add("DamageFrom",enemy.ToString());
    }
}
