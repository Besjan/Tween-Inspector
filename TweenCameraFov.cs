namespace BeeX.Tween
{
    using DG.Tweening;
    using UnityEngine;

    [RequireComponent(typeof(Camera))]
    public class TweenCameraFov : TweenBase
    {
        Camera _camera;


        private void Awake()
        {
            _camera = GetComponent<Camera>();
        }

        public void DoFov(float fov)
        {
            Play(_camera.DOFieldOfView(fov, Time));
        }
    }
}