using UnityEngine;
using BaseGame.Shapes;

namespace InputSystem
{
    public class InputHandler : MonoBehaviour
    {
        
        [SerializeField]
        private GameObject test;
        [SerializeField]
        private GameObject test2;
        private Shape _selectedShape;

        public void InputObject(GameObject inputObject)
        {
            Shape shape = inputObject.GetComponent<Shape>();
            if(shape == null) return;

            if(_selectedShape == null)
            {
                SelectShape(shape);
            }
            else
            {
                IInteractable interact = inputObject.GetComponent<IInteractable>();
                if(interact != null) interact.Interact(_selectedShape);
                UnselectShape();
            }
        }
        
        public void InputEmpty()
        {
            if(_selectedShape != null) UnselectShape();
        }

        private void SelectShape(Shape selectShape)
        {
            _selectedShape = selectShape;
            Instantiate(test, selectShape.transform.position, Quaternion.identity);
            _selectedShape.SelectShape();
        }

        private void UnselectShape()
        {
            Instantiate(test2, _selectedShape.transform.position, Quaternion.identity);
            _selectedShape.UnselectShape();
            _selectedShape = null;
        }
    }
}