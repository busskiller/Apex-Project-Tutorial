

    using Apex.AI;
    using UnityEngine;

    public sealed class TargetContext : IAIContext
    {


        public TargetContext(Transform transform, GameObject[] targets, int oil, int wood, int water, int food)
        {
            this.self = transform;
            this.targets = targets;

            this.oil = oil;
            this.wood = wood;
            this.water = water;
            this.food = food;

        }

        public Transform self { get; private set; }

        public GameObject[] targets { get; private set; }



        public int oil { get;  set; }
        public int wood { get;  set; }
        public int water { get;  set; }
        public int food { get;  set; }

    }



