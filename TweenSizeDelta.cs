namespace BeeX.Tween
{
    using UnityEngine;
    using DG.Tweening;

    [RequireComponent(typeof(RectTransform))]
    public class TweenSizeDelta : TweenBase
    {
        RectTransform rectTransform;


        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
        }

        public void DoSizeDelta(Vector2 sizeDelta)
        {
            Play(rectTransform.DOSizeDelta(sizeDelta, Time));
        }
    }
}