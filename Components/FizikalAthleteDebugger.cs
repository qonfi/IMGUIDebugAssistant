
//using System.Collections.Generic;
using System;
using UnityEngine;
using Fizix;

namespace IMGUI
{


    public class FizikalAthleteDebugger : MonoBehaviour, IDebuggerRow
    {
        public bool Visible { get; set; }
        public GameObject Player;

        private CCJump Jump { get; set; }
        private CCLookAround LookAround { get; set; }
        private CCMove Move { get; set; }
        CCWalk Walk { get; set; }
        GravitySimulator Gravity { get; set; }
        GroundDetector Detector { get; set; }
        InertiaSimulator Inertia { get; set; }


        private void Start()
        {
            Jump = Player.GetComponent<CCJump>();
            LookAround = Player.GetComponent<CCLookAround>();
            Move = Player.GetComponent<CCMove>();
            Walk = Player.GetComponent<CCWalk>();
            Gravity = Player.GetComponent<GravitySimulator>();
            Detector = Player.GetComponent<GroundDetector>();
            Inertia = Player.GetComponent<InertiaSimulator>();
        }


        public void Display()
        {
            GUILayout.Box(
                "Move.TotalMovement : " + Move.TotalMovement + "\n" +
                "Walk.MovementPF : " + Walk.MovementPerFrame + "\n" +
                "Gravity.MovementPF : " + Gravity.MovementPerFrame + "\n" +
                "Gravity.FloatingTime : " + Gravity.FloatingTime + "\n" +
                "Detector.IsGrounding : " + Detector.IsGrounding + "\n" +
                "Detector.LastGround : " + Detector.LastDetectedGround.name + "\n" +
                "Inertia.MovementPF : " + Inertia.MovementPerFrame + "\n"
                );
        }
    }


}