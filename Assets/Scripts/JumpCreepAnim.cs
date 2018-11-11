using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts
{
    public class JumpCreepAnim : MonoBehaviour
    {
        private void Awake()
        {
            transform
                .DOLocalMoveY(.3f, .25f)
                .SetEase(Ease.InQuart)
                .SetDelay(Random.value * .25f)
                .SetLoops(-1, LoopType.Yoyo);
        }
    }
}