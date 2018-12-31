namespace BeeX.Tween
{
    using DG.Tweening;
    using Sirenix.OdinInspector;

    [HideMonoScript]
    public abstract class TweenBase : SerializedMonoBehaviour
    {
        public float Time = 0.3f;

        [UnityEngine.SerializeField] Ease ease = Ease.OutQuad;


        public void Play(Tweener tweener)
        {
            tweener.SetEase(ease);
            tweener.Play();
        }
    }
}