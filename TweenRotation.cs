namespace Cuku.Tween
{
    using DG.Tweening;

    public class TweenRotation : TweenBase
    {
        public void DoRotation(UnityEngine.Vector3 rotation)
        {
            Play(transform.DOLocalRotate(rotation, Time));
        }
    }
}