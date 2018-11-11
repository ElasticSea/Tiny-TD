using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts
{
    public class RotateCreepAnim : MonoBehaviour
    {
        private void Awake()
        {
            transform
                .DOLocalRotate(new Vector3(0, 90, 0), .5f, RotateMode.LocalAxisAdd)
                .SetEase(Ease.InOutQuad)
                .SetDelay(Random.value * .5f +2)
                .SetLoops(-1);
        }
    }
}