namespace MyNameSpace1
{
    using System;
    using Apex.AI;
    using Apex.Serialization;
    using UnityEngine;

    public sealed class HasLowOilScorer : OptionScorerBase<GameObject>
    {

        [
            ApexSerialization(defaultValue = 10f),
            FriendlyName("Score", "The score output for the option that evaluates true")
        ]

        public float score;


        public override float Score(IAIContext c, GameObject option)
        {
            var context = (TargetContext)c;

            score = context.oil;
            return this.score;

        }
    }

}

