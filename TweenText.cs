namespace Cuku.Tween
{
    using DG.Tweening;
    using TMPro;

    [UnityEngine.RequireComponent(typeof(TextMeshProUGUI))]
    public class TweenText : TweenBase
    {
        public bool richTextEnabled = true;
        public ScrambleMode scrambleMode = ScrambleMode.None;
        public string scrambleChars = null;

        TextMeshProUGUI tmpText;


        private void Awake()
        {
            tmpText = GetComponent<TextMeshProUGUI>();
        }

        public void DoText(string text)
        {
            Play(tmpText.DOText(text, Time, richTextEnabled, scrambleMode, scrambleChars));
        }
    }
}