using System.Linq;
using Assets.Core.Extensions;
using Assets.Scripts.Entities;
using UnityEngine;

namespace Assets.Scripts
{
    public class AOEDamage : MonoBehaviour
    {
        [SerializeField] private float damage;
        [SerializeField] private float radius;

        private void Awake()
        {
            GetComponent<Projectile>().OnImpact += t =>
            {
                FindObjectsOfType<Creep>()
                    .Select(c => new {Creep = c, Distance = c.transform.position.FromXZ().Distance(transform.position.FromXZ())})
                    .Where(anon => anon.Distance <= radius)
                    .ForEach(
                        anon =>
                        {
                            var dmg = Mathf.Lerp(damage, 0, anon.Distance / radius);
                            anon.Creep.GetComponent<Health>().Damage(dmg);
                        });
            };
        }
    }
}