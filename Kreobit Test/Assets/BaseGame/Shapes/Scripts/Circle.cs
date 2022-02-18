using UnityEngine;
using BaseGame.Player;

namespace BaseGame.Shapes
{
    [RequireComponent (typeof(CircleCollider2D))]
    public class Circle : Shape, IInteractable, IMovable
    {
        public event CounterEvent MovesHappened;
        [SerializeField] 
        private Transform _transform;
        [SerializeField] 
        private CircleCollider2D _collider2D;
        [SerializeField] [Range (1, 20)]
        private int _size;
        
        [ContextMenu ("Change size")]
        public void ChangeScale()
        {
            _transform.localScale = Vector3.one * _size;
        }

        private void Start()
        {
            ChangeScale();
        }

        public void Interact(Shape shape)
        {
            IMeasurable cube = shape.GetComponent<IMeasurable>();
            if(cube == null) return;
            if(cube.Size > _size) return;

            IApplicable applicableShape = shape.GetComponent<IApplicable>();
            if(applicableShape == null) return;
            applicableShape.Apply(this);

            MovesHappened.Invoke();
            _collider2D.enabled = false;
        }
    }
}
