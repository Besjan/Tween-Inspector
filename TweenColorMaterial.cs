namespace Cuku.Tween
{
    using UnityEngine;
    using DG.Tweening;

    [RequireComponent(typeof(Material))]
    public class TweenColorMaterial : TweenBase
    {
        Material material;


        private void Awake()
        {
            material = GetComponent<Renderer>().material;
        }

        public void DoColor(Color color)
        {
            Play(material.DOColor(color, Time));
        }
    }
}