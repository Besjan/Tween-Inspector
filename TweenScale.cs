namespace Cuku.Tween
{
    using DG.Tweening;
    using UnityEngine;

    public class TweenScale : TweenBase
    {
        public void DoScale(Vector3 size)
        {
            Play(transform.DOScale(size, Time));
        }
    }
}