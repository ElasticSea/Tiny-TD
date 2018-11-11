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
        [SerializeField] private TowerUpgrade[] upgrades;

        private float lastAttack;

        public TowerUpgrade[] Upgrades => upgrades;

        private void Update()
        {
            if (lastAttack + interval > Time.time) return;

            var creeps = FindObjectsOfType<Creep>();
            var target = creeps
                .Select(c =>
                {
                    var distance = c.transform.position.Distance(transform.position);
                    var foo = new {Creep = c, Distance = distance};
                    return foo;
                })
                .OrderBy(pair => pair.Distance)
                .FirstOrDefault(pair => pair.Distance <= range)?.Creep;

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