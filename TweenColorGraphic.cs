namespace BeeX.Tween
{
    using UnityEngine;
    using UnityEngine.UI;
    using DG.Tweening;

    [RequireComponent(typeof(Graphic))]
    public class TweenColorGraphic : TweenBase
    {
        Graphic graphic;


        private void Awake()
        {
            graphic = GetComponent<Graphic>();
        }

        public void DoColor(Color color)
        {
            Play(graphic.DOColor(color, Time));
        }
    }
}