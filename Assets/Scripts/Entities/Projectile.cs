using System;
using Assets.Core.Extensions;
using UnityEngine;

namespace Assets.Scripts.Entities
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float speed;
        [SerializeField] private bool stopOnImpact;
        private bool alive = true;

        public event Action<Transform> OnImpact = t => {};

        public Transform Target
        {
            get { return target; }
            set { target = value; }
        }

        private void Update()
        {
            if (target == false)
            {
                return;
            }

            var distance = target.position.Distance(transform.position);
            var dir = (target.position - transform.position).normalized;
            var moveBudget = speed * Time.deltaTime;
            if (distance > moveBudget)
            {
                transform.position += moveBudget * dir;
            }
            else
            {
                if (alive)
                {
                    alive = false;
                    OnImpact(target);
                    if (stopOnImpact)
                    {
                        target = null;
                    }
                    Destroy(gameObject, 2f);
                }
            }
        }
    }
}