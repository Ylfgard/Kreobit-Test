﻿using UnityEngine;

namespace InputSystem
{
    public class MobileInputDetector : MonoBehaviour
    {
        [SerializeField]
        private InputHandler _inputHandler;

        void Update()
        {
            Touch touch = Input.GetTouch(0);

            Vector2 inputPos = Camera.main.ScreenToWorldPoint(touch.position);
            RaycastHit2D ray = Physics2D.Raycast(inputPos, Vector2.zero);
            Collider2D c2d = ray.collider;
            if(c2d == null) 
                _inputHandler.InputEmpty();
            else 
                _inputHandler.InputObject(c2d.gameObject);
        }
    }
}
