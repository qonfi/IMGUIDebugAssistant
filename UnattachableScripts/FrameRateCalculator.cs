
//using System.Collections.Generic;
using UnityEngine;


namespace IMGUI
{


    public class FrameRateCalculator
    {

        public float PassedTime { get; private set; }
        private float FrameRate { get; set; }
        public float TruncatedFrameRate { get; private set; }

        private float lastCalcTime;
        private float CalcInterval;


        public FrameRateCalculator()
        {
            CalcInterval = 1f;
        }

        
        public void Update()
        {

            PassedTime += Time.deltaTime;

            if ( PassedTime > lastCalcTime + CalcInterval)
            {
                Calc();
                lastCalcTime = PassedTime;
            }

        }


        private void Calc()
        {
            FrameRate = 1f / Time.deltaTime;
            TruncatedFrameRate = Mathf.Floor(FrameRate);
        }
    }


}