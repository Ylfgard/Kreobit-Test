using UnityEngine;
using TMPro;

namespace Addones.Triangles
{
    public class EnergyСounter : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _counterText;
        private int _energy;

        private void Start() 
        {       
            UpdateCounter();
        }

        public void SetEnergy(int energy)
        {
            _energy = energy;
        }
        
        private void UpdateCounter()
        {
            _counterText.text = _energy.ToString();
        }

        public bool DecreaseEnergy()
        {
            if(_energy <= 0) return false;
                
            _energy--;
            UpdateCounter();
            return true;
        } 
    }
}
