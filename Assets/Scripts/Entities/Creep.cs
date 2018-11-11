using System;
using System.Linq;
using Assets.Core.Extensions;
using UnityEngine;

namespace Assets.Scripts.Entities
{
    public class Creep : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private int money;
        private Vector3[] points;
        private int pathIndex;

        public Path Path { get; set; }

        public int Money => money;

        public event Action OnPathFinished = () => {};

        private void Start()
        {
            points = Path.Points.ToArray();

            transform.position = points.First();
        }

        private static int whileLim = 1000;
        private void Update()
        {
            var moveBudget = speed * Time.deltaTime;
            var i = 0;
            while (moveBudget > 0 && i < whileLim)
            {
                i++;
                var dist = transform.position.Distance(points[pathIndex]);
                if (dist > moveBudget)
                {
                    var dir = (points[pathIndex] - transform.position).normalized;
                    transform.position += dir * moveBudget;
                    moveBudget = 0;
                }
                else
                {
                    moveBudget -= dist;
                    transform.position = points[pathIndex];

                    pathIndex++;

                    if (pathIndex == points.Length)
                    {
                        DamagePlayer();
                        OnPathFinished();
                        Destroy(gameObject);
                        break;
                    }
                }
            }
        }

        private void DamagePlayer()
        {
            GameObject.FindObjectOfType<Player>().GetComponent<Health>().Damage(1);
        }
    }
}