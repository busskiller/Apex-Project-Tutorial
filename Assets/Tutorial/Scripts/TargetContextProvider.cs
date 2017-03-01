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

        [SerializeField]
        private int _oil = 10;
        [SerializeField]
        private int _wood = 10;
        [SerializeField]
        private int _water = 10;
        [SerializeField]
        private int _food = 10;


        private TargetContext _context;

        public void OnEnable()
        {
            _context = new TargetContext(this.transform, _targets, _oil, _wood, _water, _food);
        }

        public IAIContext GetContext(Guid aiId)
        {
            return _context;
        }

    }

}

