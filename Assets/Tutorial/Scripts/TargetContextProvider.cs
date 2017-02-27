using Apex.AI.Components;

namespace MyNameSpace1
{

    using System;
    using UnityEngine;
    using Apex.AI;


    public class TargetContextProvider : MonoBehaviour, IContextProvider
    {


        [SerializeField]
        private GameObject[] _targets = new GameObject[0];

        private TargetContext _context;

        public void OnEnable()
        {
            _context = new TargetContext(this.transform, _targets);
        }

        public IAIContext GetContext(Guid aiId)
        {
            return _context;
        }

    }

}

