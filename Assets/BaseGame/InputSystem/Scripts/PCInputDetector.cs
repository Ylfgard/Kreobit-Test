using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputSystem
{
    public class PCInputDetector : MonoBehaviour
    {
        [SerializeField]
        private InputHandler _inputHandler;

        private void Update()
        {
            if(Input.GetMouseButtonDown(0) == false) return;

            Vector2 inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D ray = Physics2D.Raycast(inputPos, Vector2.zero);
            Collider2D c2d = ray.collider;
            if(c2d == null) 
                _inputHandler.InputEmpty();
            else
                _inputHandler.InputObject(c2d.gameObject);
        }
    }
}