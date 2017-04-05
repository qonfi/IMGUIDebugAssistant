
//using System.Collections.Generic;
using System;
using UnityEngine;


namespace IMGUI
{


    public class CharacterControllerDebugger : MonoBehaviour, IDebuggerRow
    {

        [SerializeField] private CharacterController characterToDebug;
        public bool Visible { get; set; }


        public void Display()
        {
            if ( characterToDebug == null)
            {
                GUILayout.Box("CharacterController == null");
                return;
            }
            GUILayout.Box("colllisionFlags\n" + characterToDebug.collisionFlags);
            GUILayout.Box("isGrounded\n" + characterToDebug.isGrounded);
            GUILayout.Box("velocity" + characterToDebug.velocity);
            // GUILayout.Box("" + character.enableOverlapRecovery);
        }

    }


}