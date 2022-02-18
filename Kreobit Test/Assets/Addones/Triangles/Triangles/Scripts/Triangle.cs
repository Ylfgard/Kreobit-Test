using UnityEngine;
using BaseGame.Shapes;

namespace Addones.Triangles
{
    [RequireComponent (typeof(PolygonCollider2D))]
    public class Triangle : Shape, IApplicable
    {
        private EnergyСounter _energyСounter;

        private void Awake()
        {
            _energyСounter = FindObjectOfType<EnergyСounter>();
        }

        public void Apply(Shape shape)
        {
            IMeasurable cube = shape.GetComponent<IMeasurable>();
            if(cube == null) return;
            if(_energyСounter.DecreaseEnergy() == false) return;
            
            cube.SetSize(cube.Size-1);
            Destroy(gameObject);
        }        
    }
}