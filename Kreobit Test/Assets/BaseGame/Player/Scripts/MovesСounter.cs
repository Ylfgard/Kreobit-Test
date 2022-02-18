using UnityEngine;
using TMPro;
using System.Linq;

namespace BaseGame.Player
{
    public class MovesСounter : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _counterText;
        private int _moves = 0;

        private void Awake() 
        {
            var movables = FindObjectsOfType<MonoBehaviour>().OfType<IMovable>();
            foreach(IMovable movable in movables)
                movable.MovesHappened += IncreaseMoves;

            UpdateCounter();
        }

        private void IncreaseMoves()
        {
            _moves++;
            UpdateCounter();
        } 

        private void UpdateCounter()
        {
            _counterText.text = _moves.ToString();
        }
    }
    
    public delegate void CounterEvent();
}
