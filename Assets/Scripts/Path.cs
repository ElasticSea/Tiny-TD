using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    public class Path : MonoBehaviour
    {
        [SerializeField] private Transform[] points;

        public IEnumerable<Vector3> Points => points.Select(t => t.position).ToList();
    }
}