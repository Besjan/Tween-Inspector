namespace BeeX.Tween
{
    using DG.Tweening;
    using UnityEngine;

    [RequireComponent(typeof(CanvasGroup))]
    public class TweenTransparencyCanvasGroup : TweenBase
    {
        CanvasGroup canvasGroup;


        private void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        public void DoTransparency(float opacity)
        {
            Play(canvasGroup.DOFade(opacity, Time));
        }
    }
}