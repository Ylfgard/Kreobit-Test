using UnityEngine;

namespace InputSystem
{
    public class MobileInputDetector : MonoBehaviour
    {
        [SerializeField]
        private GameObject test;
        [SerializeField]
        private GameObject test2;
        [SerializeField]
        private InputHandler _inputHandler;

        void Update()
        {
            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0); 
                if(touch.phase != TouchPhase.Began) return;

                Vector2 inputPos = Camera.main.ScreenToWorldPoint(touch.position);
                RaycastHit2D ray = Physics2D.Raycast(inputPos, Vector2.zero);
                Collider2D c2d = ray.collider;
                if(c2d == null) 
                {
                    Instantiate(test, inputPos, Quaternion.identity);
                    _inputHandler.InputEmpty();
                }
                else 
                {
                    Instantiate(test2, inputPos, Quaternion.identity);
                    _inputHandler.InputObject(c2d.gameObject);
                }
            }
        }
    }
}
