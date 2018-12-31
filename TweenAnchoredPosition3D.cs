namespace BeeX.Tween
{
    using UnityEngine;
    using DG.Tweening;

    [RequireComponent(typeof(RectTransform))]
    public class TweenAnchoredPosition3D : TweenBase
    {
        RectTransform rectTransform;


        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
        }

        public void DoAnchoredPosition3D(Vector3 position3D)
        {
            Play(rectTransform.DOAnchorPos3D(position3D, Time));
        }
    }
}