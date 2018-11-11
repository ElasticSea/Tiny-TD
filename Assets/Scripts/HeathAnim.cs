using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts
{
    public class HeathAnim : MonoBehaviour
    {
        [SerializeField] private float distance;
        [SerializeField] private float heartbeetInterval;
        [SerializeField] private float minScale;
        [SerializeField] private float maxScale;
        [SerializeField] private float heartbeetScale = 1.5f;
        [SerializeField] private Color emissionMax;
        private Material mat;
        private Health health;

        private void Start()
        {
            mat = GetComponent<Renderer>().material;
            health = GetComponent<Health>();
            health.OnDamaged += () =>
            {
                transform.DOLocalRotate(new Vector3(0, 0, 180), .5f, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuad);
            };
            StartCoroutine(HearthBeet());

        }

        private void Update()
        {
            mat.color = Color.Lerp(Color.blue, Color.red, health.Delta);
            mat.SetColor("_Emission", Color.Lerp(Color.black, emissionMax, health.Delta));
        }

        private IEnumerator HearthBeet()
        {
            var min = .1f;
            var max = 1;

            var scale = Mathf.Lerp(minScale, maxScale, health.Delta);

            var expanded = scale * heartbeetScale;
            var contracted = scale;

            var interval = heartbeetInterval + (1 - health.Delta) * 4;
            DOTween.Sequence()
                .Append(
                    transform
                        .DOScale(expanded, interval / 2)
                        .SetEase(Ease.InQuad)
                ).Append(
                    transform
                        .DOScale(contracted, interval / 2)
                        .SetEase(Ease.OutQuad)
                );


//            transform.DOMove(transform.position + Vector3.up * distance, 1).SetEase(Ease.InOutQuart).SetLoops(2, LoopType.Yoyo);
            yield return new WaitForSeconds(interval );
            StartCoroutine(HearthBeet());
        }
    }
}