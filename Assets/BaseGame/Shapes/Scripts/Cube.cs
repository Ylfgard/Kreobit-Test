using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomAttributes;

namespace Shapes
{
    [RequireComponent (typeof(BoxCollider2D))]
    public class Cube : Shape, IApplicable, ISelectable, IMeasurable
    {
        [SerializeField] 
        private Transform _transform;
        [SerializeField] [Range (1, 20)] 
        private int _size;
        
        public int Size => _size;

        public void SetSize(int size)
        {

        }

        [EditorButton ("Change size")]
        public void ChangeScale()
        {
            _transform.localScale = Vector3.one * _size;
        }

        public void Select()
        {

        }

        public void Apply()
        {

        }        
    }
}