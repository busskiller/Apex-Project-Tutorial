    using System;
    using Apex.AI;
    using Apex.Serialization;
    using MyNameSpace1;
    using UnityEngine;

<<<<<<< HEAD
    public sealed class HasLowOilScorer : ContextualScorerBase
{
=======
    public sealed class HasLowOilScorer : OptionScorerBase<GameObject>
    {

        [
            ApexSerialization(defaultValue = 10f),
            FriendlyName("Score", "The score output for the option that evaluates true")
        ]

        public float score;

>>>>>>> origin/master

        public override float Score(IAIContext _context)
        {
<<<<<<< HEAD
            TargetContext context = (TargetContext) _context;
            //var targets = context._surroundingHexCells;
            return score = 100/context.oil;
=======
            var context = (TargetContext)c;

            score = context.oil;
            return this.score;

>>>>>>> origin/master
        }
}
