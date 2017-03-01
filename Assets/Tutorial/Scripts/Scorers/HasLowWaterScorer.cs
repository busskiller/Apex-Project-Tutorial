namespace MyNameSpace1
{
    using System;
    using Apex.AI;
    using Apex.Serialization;
    using UnityEngine;

    public sealed class HasLowWaterScorer : OptionScorerBase<GameObject>
    {

        [
            ApexSerialization(defaultValue = 10f),
            FriendlyName("Score", "The score output for the option that evaluates true")
        ]

        public int test;

        public override float Score(IAIContext c, GameObject option)
        {
            // Cast the provided context to your concrete context type
            var context = (TargetContext)c;

            test = context.water;
            // Put scoring logic here

            return test;
        }
    }

}

