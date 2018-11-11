using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float max;
        [SerializeField] private float current;
        [SerializeField] private bool colorize;
        private bool alive = true;

        public event Action OnDeath = () => { };
        public event Action OnDamaged = () => { };

        public float Max
        {
            get { return max; }
            set { max = value; }
        }

        public float Current
        {
            get { return current; }
            set { current = value; }
        }

        public float Delta => Current / Max;

        public void Damage(float value)
        {
            if (alive == false) return;

            Current -= value;
            if (Current <= 0)
            {
                alive = false;
                Destroy(gameObject);
                OnDeath();
            }
            else
            {
                OnDamaged();
            }
        }

        private void Update()
        {
            if (colorize == false) return;

            foreach (var componentsInChild in GetComponentsInChildren<Renderer>())
            {
                foreach (var material in componentsInChild.materials)
                {
                    material.color = Color.Lerp(Color.red, Color.green, Current / Max);
                }
            }
        }
    }
}