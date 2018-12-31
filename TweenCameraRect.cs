namespace BeeX.Tween
{
    using DG.Tweening;
    using UnityEngine;

    [RequireComponent(typeof(Camera))]
    public class TweenCameraRect : TweenBase
    {
        Camera _camera;


        private void Awake()
        {
            _camera = GetComponent<Camera>();
        }

        public void DoRect(Vector2 min, Vector2 max)
        {
            var rect = new Rect()
            {
                min = min,
                max = max
            };

            Play(_camera.DORect(rect, Time));
        }
    }
}

