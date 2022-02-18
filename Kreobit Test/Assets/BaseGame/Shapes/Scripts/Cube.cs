using UnityEngine;

namespace BaseGame.Shapes
{
    [RequireComponent (typeof(BoxCollider2D))]
    public class Cube : Shape, IApplicable, IMeasurable, IInteractable
    {
        [SerializeField] 
        private Transform _transform;
        [SerializeField] 
        private BoxCollider2D _collider2D;
        [SerializeField] [Range (1, 20)] 
        private int _size;
        
        public int Size => _size;

        private void Start()
        {
            ChangeScale();
        }
        
        [ContextMenu ("Change size")]
        public void ChangeScale()
        {
            _transform.localScale = Vector3.one * _size;
        }

        public void SetSize(int size)
        {
            if(size>=1 && size<=20)
                _size = size;
            ChangeScale();
        }

        public void Apply(Shape shape)
        {
            _transform.position = shape.transform.position;
            _collider2D.enabled = false;
        }     

        public void Interact(Shape shape)
        {
            Cube cube = shape.GetComponent<Cube>();
            if(cube != null) return;

            IApplicable applicableShape = shape.GetComponent<IApplicable>();
            if(applicableShape == null) return;
            applicableShape.Apply(this);
        }   
    }
}