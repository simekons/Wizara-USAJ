using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizaraTelemetry.Events;

public class PuzzleFinishEvent : GameEvent
{
    public PuzzleFinishEvent() : base("PuzzleEnd") { }
}
