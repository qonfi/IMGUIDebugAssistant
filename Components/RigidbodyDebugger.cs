
//using System.Collections.Generic;
using System;
using UnityEngine;

namespace IMGUI
{


    /// <summary>
    /// コンポーネント。Rigidbodyを取得してくるためにはコンポーネントのほうが都合が良さそうだったので。
    /// </summary>
    public class RigidbodyDebugger : MonoBehaviour, IDebuggerRow
    {

        public bool Visible { get; set; }
        public Rigidbody rigidbodyToDebug;
        

        public void Display()
        {
            if (rigidbodyToDebug == null)
            {
                GUILayout.Box("Rigidbody == null");
                return;
            }

            GUILayout.Box("Rigidbody\n" + rigidbodyToDebug);
            GUILayout.Box("velocity\n" + rigidbodyToDebug.velocity);
        }

    }


}