﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Apex.AI;
using System.Linq;
public sealed class ReassignWorkerToOilAction : ActionBase {


    public override void Execute(IAIContext context)
    {
        var c = (TargetContext) context;
        List<HexInfo> h = new List<HexInfo>(c.targets.OrderBy(x => x.oil));
        if (!c.workedHexInfos.Contains(h[h.Count - 1]))
        {
            c.workedHexInfos.Add(h[h.Count - 1]);
            Debug.Log("Moved Worker " + h[h.Count - 1].oil);
        }
    }
}
