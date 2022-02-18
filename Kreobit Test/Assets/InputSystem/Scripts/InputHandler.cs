using UnityEngine;
using BaseGame.Shapes;

namespace InputSystem
{
    public class InputHandler : MonoBehaviour
    {
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
            _selectedShape.SelectShape();
        }

        private void UnselectShape()
        {
            _selectedShape.UnselectShape();
            _selectedShape = null;
        }
    }
}