using Assets.Scripts.Entities;
using UnityEngine;

namespace Assets.Scripts
{
    public class SimpleDamage : MonoBehaviour
    {
        [SerializeField] private float damage;

        private void Awake()
        {
            GetComponent<Projectile>().OnImpact += t => 
            {
                t.GetComponent<Health>().Damage(damage);
            };
        }
    }
}