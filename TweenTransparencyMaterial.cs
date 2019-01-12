namespace Cuku.Tween
{
    using UnityEngine;
    using DG.Tweening;

    [RequireComponent(typeof(Material))]
    public class TweenTransparencyMaterial : TweenBase
    {
        Material material;


        private void Awake()
        {
            material = GetComponent<Renderer>().material;
        }

        public void DoTransparency(float opacity)
        {
            Play(material.DOFade(opacity, Time));
        }
    }
}