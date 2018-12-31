namespace BeeX.Tween
{
    using UnityEngine;
    using DG.Tweening;

    [RequireComponent(typeof(RectTransform))]
    public class TweenAnchorMin : TweenBase
    {
        RectTransform rectTransform;


        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
        }

        public void DoAnchorMin(Vector2 minAnchors)
        {
            Play(rectTransform.DOAnchorMin(minAnchors, Time));
        }
    }
}