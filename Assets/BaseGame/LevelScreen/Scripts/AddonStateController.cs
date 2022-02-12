using UnityEngine;
using Addones.Setuper;
using System;
using CustomAttributes;

namespace LevelScreen
{
    public class AddonStateController : MonoBehaviour
    {
        [SerializeField]
        private AddoneState[] _addonesState;

        [EditorButton ("Apply changes")]
        public void ChangeAddonesState()
        {
            foreach(AddoneState addoneState in _addonesState)
                if(addoneState._state) addoneState._addone.SetupAddone();
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