using System.Collections;
using Assets.Core.Scripts.Extensions;
using Assets.Scripts.Entities;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class BombEffect : MonoBehaviour
    {
        [SerializeField] private ParticleSystem particleSystemPrefab;
        [SerializeField] private RectTransform radiusImage;
        [SerializeField] private float radius;
        [SerializeField] private int particleCount;
        [SerializeField] private MeshRenderer cube;

        private void Awake()
        {
            GetComponent<Projectile>().OnImpact += transform1 => 
            {
                var particleSystem = Instantiate(particleSystemPrefab);
                particleSystem.transform.position = transform1.position;
                radiusImage.localScale = Vector3.zero;
                radiusImage.DOScale(radius, .4f).SetEase(Ease.OutQuad);

                radiusImage.GetComponent<Image>().material = new Material(radiusImage.GetComponent<Image>().material);
                radiusImage.GetComponent<Image>().material.DOFade(0, "_TintColor", .4f);

                cube.material = new Material(cube.material);
                cube.material.DOFade(0,"_TintColor", .4f);

                StartCoroutine(Explode(particleSystem));
            };
        }

        private IEnumerator Explode(ParticleSystem system)
        {
            yield return new WaitForEndOfFrame();
            system.Emit(new ParticleSystem.EmitParams(), particleCount);
        }
    }
}