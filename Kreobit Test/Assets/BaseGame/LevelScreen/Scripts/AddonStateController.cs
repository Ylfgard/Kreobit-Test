using UnityEngine;
using Addones.Setuper;
using System;

namespace BaseGame.LevelScreen
{
    public class AddonStateController : MonoBehaviour
    {
        [SerializeField]
        private AddoneState[] _addonesState;

        [ContextMenu ("Apply changes")]
        public void ChangeAddonesState()
        {
            foreach(AddoneState addoneState in _addonesState)
                addoneState._addone.SetAddoneState(addoneState._state);
        }
    }

    [Serializable]
    public struct AddoneState
    {
        public string name;
        public bool _state;
        public AddoneSetuper _addone; 
    }
}