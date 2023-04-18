using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizaraTelemetry.Events;

public class ShieldCastEvent : GameEvent
{
    public ShieldCastEvent(string event_info) : base(event_info) { }
}
