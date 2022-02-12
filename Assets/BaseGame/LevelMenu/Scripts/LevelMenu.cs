using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu.Level
{
    public class LevelMenu : MonoBehaviour
    {
        public Scene[] scenes;

        public void LoadLevel(int index)
        {
            SceneManager.LoadScene(scenes[index].name);
        }
    }
}

