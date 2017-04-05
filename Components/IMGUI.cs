

using System.Collections.Generic;
using UnityEngine;


namespace IMGUI
{


    public class IMGUI : MonoBehaviour
    {

        public List<IDebuggerRow> Rows { get; set; }
        private UpdatableRect topLeftAreaRect;
        private TogglePlacer togglePlacer;


        private void Start()
        {
            Rows = new List<IDebuggerRow>();
            topLeftAreaRect = new UpdatableRect(Anchor.TopLeft);
            togglePlacer = new TogglePlacer();

            // 指定のインターフェイスを実装しているコンポーネントを"すべて"取得してそれらをリストに加える。 一行で済んじゃった! 
            Rows.AddRange( GetComponents<IDebuggerRow>());
        }


        // フレームごとに呼ばれる。
        private void OnGUI()
        {
            // BeginArea でできた領域は背景が無いのでLabelは使わずBoxを配置すると見やすいかも。
            GUILayout.BeginArea(topLeftAreaRect.UpdateByScreenScale(0.9f, 0.9f));
            GUILayout.BeginVertical();

            togglePlacer.PlaceToggles(Rows);

            foreach (IDebuggerRow line in Rows)
            {
                if (line.Visible == false) { continue; }
                GUILayout.BeginHorizontal();
                line.Display();
                GUILayout.EndHorizontal();
            }

            GUILayout.EndVertical();
            GUILayout.EndArea();
        }

    }


}