namespace BeeX.Tween
{
    using UnityEngine;
    using DG.Tweening;

    [RequireComponent(typeof(RectTransform))]
    public class TweenAnchorMax : TweenBase
    {
        RectTransform rectTransform;


        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
        }

        public void DoAnchorMax(Vector2 maxAnchors)
        {
            Play(rectTransform.DOAnchorMax(maxAnchors, Time));
        }
    }
}