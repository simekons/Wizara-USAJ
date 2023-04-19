using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizaraTelemetry.Events;

public class ThunderboltCastEvent : GameEvent
{
        public ThunderboltCastEvent(CastHit ch) : base("ThunderHit") {

        data.Add("Hit",ch.ToString());

         }
}
