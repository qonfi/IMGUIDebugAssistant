
using System.Collections.Generic;
using UnityEngine;


namespace IMGUI
{


    public class TogglePlacer
    {

        private bool Debugging { get; set; }


        public void PlaceToggles(List<IDebuggerRow> rows) 
        {
            GUILayout.BeginHorizontal();

            Debugging = GUILayout.Toggle(Debugging, "Debug");

            if (Debugging == false)
            {
                foreach(IDebuggerRow row in rows) { row.Visible = false; }
                GUILayout.EndHorizontal();
                return;
            }

            for (int i = 0; i< rows.Count; i++)
            {
                rows[i].Visible = GUILayout.Toggle(rows[i].Visible, i.ToString());
            }

            GUILayout.EndHorizontal();
        }


    }



}