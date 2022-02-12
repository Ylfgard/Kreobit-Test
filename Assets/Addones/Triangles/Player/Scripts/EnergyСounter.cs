using UnityEngine;

namespace Player
{
    public class EnergyСounter : MonoBehaviour
    {
        private void Awake() 
        {
            var consumers = FindObjectsOfType(typeof(IEnergyСonsumer));
            foreach(IEnergyСonsumer consumer in consumers)
                consumer.EnergySpent += DecreaseEnergy;
        }

        private void DecreaseEnergy()
        {
            
        } 
    }
}
