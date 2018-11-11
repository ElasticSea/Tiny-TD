using System.Linq;
using Assets.Core.Extensions;
using UnityEngine;

namespace Assets.Scripts.Entities
{
    public class Tower : MonoBehaviour
    {
        [SerializeField] private Projectile projectilePrefab;
        [SerializeField] private Transform attackPosition;
        [SerializeField] private float range;
        [SerializeField] private float interval;
        [SerializeField] private TowerUpgrade[] Upgrades;

        private float lastAttack;

        private void Update()
        {
            if (lastAttack + interval > Time.time) return;

            var creeps = FindObjectsOfType<Creep>();
            var target  = creeps.FirstOrDefault(c => c.transform.position.Distance(transform.position) <= range);

            if (target)
            {
                lastAttack = Time.time;

                var projectile = Instantiate(projectilePrefab);
                projectile.transform.position = attackPosition.transform.position;
                projectile.Target = target.transform;
            }
        }
    }
}