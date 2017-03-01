namespace MyNameSpace1
{
    using System;
    using Apex.AI;
    using Apex.Serialization;
    using UnityEngine;

    public sealed class HasLowWoodScorer : OptionScorerBase<GameObject>
    {

        [
            ApexSerialization(defaultValue = 10f),
            FriendlyName("Score", "The score output for the option that evaluates true")
        ]

        public float score = 10f;


        public override float Score(IAIContext c, GameObject option)
        {
            var context = (TargetContext)c;
            var targets = context.targets;
           // var index = Array.IndexOf(targets, option);

            //if (Mathf.RoundToInt(Time.time) % targets.Length == index)
            //{
            //    return this.score;
            //}
            return 0f;
        }
    }

}


