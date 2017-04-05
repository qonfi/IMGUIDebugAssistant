
using UnityEngine;


namespace IMGUI
{


    /// <summary>
    /// アプリケーションやシステム環境の情報を見る。
    /// </summary>
    public class EnvironmentDebugger : MonoBehaviour, IDebuggerRow
    {

        public bool Visible { get; set; }
        private FrameRateCalculator frameRateCalculator;


        public void Display()
        {
            GUILayout.Box("---Application.Platform---\n" +  Application.platform);
            GUILayout.Box("FramRate\n" + frameRateCalculator.TruncatedFrameRate);
        }


        private void Start()
        {
            frameRateCalculator = new FrameRateCalculator();
        }


        private void Update()
        {
            frameRateCalculator.Update();
        }


    }
    

}