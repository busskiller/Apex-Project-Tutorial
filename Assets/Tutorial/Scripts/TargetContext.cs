

    using Apex.AI;
    using UnityEngine;

    public sealed class TargetContext : IAIContext
    {


        public TargetContext(Transform transform, GameObject[] targets)
        {
            this.self = transform;
            this.targets = targets;

        }

        public Transform self { get; private set; }

        public GameObject[] targets { get; private set; }

    }



