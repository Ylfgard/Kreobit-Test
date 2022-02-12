using UnityEngine;
using CustomAttributes;
using Player;

namespace Shapes
{
    [RequireComponent (typeof(BoxCollider2D))]
    public class Cube : Shape, IApplicable, IMeasurable, IMovable
    {
        public event CounterEvent MovesHappened;
        [SerializeField] 
        private Transform _transform;
        [SerializeField] 
        private BoxCollider2D _collider2D;
        [SerializeField] [Range (1, 20)] 
        private int _size;
        
        public int Size => _size;
        
        [EditorButton ("Change size")]
        public void ChangeScale()
        {
            _transform.localScale = Vector3.one * _size;
        }

        private void Start()
        {
            ChangeScale();
        }

        public void Apply(Shape shape)
        {
            _transform.position = shape.transform.position;
            MovesHappened.Invoke();
            _collider2D.enabled = false;
        }        
    }
}