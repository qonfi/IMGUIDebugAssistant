
//using System.Collections.Generic;
using UnityEngine;


namespace IMGUI
{
    public enum Anchor { TopLeft, TopCenter, TopRight, CenterLeft, CenterCenter, CenterRight, BottomLeft, BottomCenter, BottomRight }


    /// <summary>
    /// Updates its location (manually) without "new" keyword.
    /// </summary>
    public class UpdatableRect
    {

        private Rect rect;
        private float spacing;
        public Anchor anchorPoint;


        public UpdatableRect(Anchor anchor, float spacing = 20f)
        {
            this.anchorPoint = anchor;
            this.spacing = spacing;

            rect = new Rect(0, 0, 0, 0);
        }


        /// <summary>
        /// Recalculates Rect position
        /// </summary>
        /// <returns></returns>
        public Rect Update(float width, float height)
        {
            this.rect.width = width;
            this.rect.height = height;

            this.rect.x = CalcAnchorX(width, height, this.anchorPoint);
            this.rect.y = CalcAnchorY(width, height, this.anchorPoint);

            return this.rect;
        }


        // いい名前が思いつかない。そもそもUpdateという名前がいまいちか。
        public Rect UpdateByScreenScale(float widthScale, float heightScale)
        {
            Update(Screen.width * widthScale, Screen.height * heightScale);

            return this.rect;
        }


        private float CalcAnchorX(float width, float height, Anchor anchor)
        {
            if (anchor == Anchor.TopLeft ||
                anchor == Anchor.CenterLeft ||
                anchor == Anchor.BottomLeft)
            {
                return 0 + spacing;
            }


            if (anchor == Anchor.TopCenter ||
                anchor == Anchor.CenterCenter ||
                anchor == Anchor.BottomCenter)
            {
                return (Screen.width / 2) - (width / 2);
            }


            if (anchor == Anchor.TopRight ||
                anchor == Anchor.CenterRight ||
                anchor == Anchor.BottomRight)
            {
                return Screen.width - width - spacing;
            }


            Debug.Log("想定されていないアンカー位置です。たぶん。");
            return 0;
        }


        private float CalcAnchorY(float width, float height, Anchor anchor)
        {
            if (anchor == Anchor.TopLeft ||
                anchor == Anchor.TopCenter ||
                anchor == Anchor.TopRight)
            {
                return 0 + spacing;
            }


            if (anchor == Anchor.CenterLeft ||
                anchor == Anchor.CenterCenter ||
                anchor == Anchor.CenterRight)
            {
                return (Screen.height / 2) - (width / 2);
            }


            if (anchor == Anchor.BottomLeft ||
                anchor == Anchor.BottomCenter ||
                anchor == Anchor.BottomRight)
            {
                return Screen.height - height - spacing;
            }


            Debug.Log("想定されていないアンカー位置です。たぶん。");
            return 0;
        }


    }
}