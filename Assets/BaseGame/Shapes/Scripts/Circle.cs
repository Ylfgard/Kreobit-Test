using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomAttributes;

namespace Shapes
{
    [RequireComponent (typeof(CircleCollider2D))]
    public class Circle : Shape, IInteractable
    {
        [SerializeField] 
        private Transform _transform;
        [SerializeField] [Range (1, 20)]
        private int _size;
        
        [EditorButton ("Change size")]
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
        }
    }
}
