

using UnityEngine;


namespace IMGUI
{


    public interface IDebuggerRow
    {
        bool Visible { get; set; }
        /// <summary>
        /// GUILayout.Box などの処理をここで行ってください。このメソッドを他クラスのOnGUI() で呼びます。
        /// </summary>
        void Display();
    }


}