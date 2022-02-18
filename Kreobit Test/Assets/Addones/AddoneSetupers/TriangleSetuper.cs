using UnityEngine;
using Addones.Triangles;

namespace Addones.Setuper
{
    public class TriangleSetuper : AddoneSetuper
    {
        [SerializeField]
        private EnergyСounter _energyCounter;
        [SerializeField]
        private int _energy;

        private void Awake()
        {
            _energyCounter.SetEnergy(_energy);
        }

        public override void SetAddoneState(bool state)
        {
            _energyCounter.gameObject.SetActive(state);
        }
    }
}