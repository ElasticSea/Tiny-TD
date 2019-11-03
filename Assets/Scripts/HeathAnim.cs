using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts
{
    public class HeathAnim : MonoBehaviour
    {
        private void Start()
        {
            transform.DOLocalRotate(new Vector3(0, 0, 180), 2f, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuad).SetLoops(-1);

        }
    }
}