namespace Cuku.Tween
{
    using DG.Tweening;
    using UnityEngine.UI;

    [UnityEngine.RequireComponent(typeof(Graphic))]
    public class TweenTransparencyGraphic : TweenBase
    {
        Graphic graphic;


        private void Awake()
        {
            graphic = GetComponent<Graphic>();
        }

        public void DoTransparency(float opacity)
        {
            Play(graphic.DOFade(opacity, Time));
        }
    }
}