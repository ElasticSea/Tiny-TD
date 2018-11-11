using Assets.Scripts.Entities;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameOver : MonoBehaviour
    {
        private void Awake()
        {
            DoIt();
        }

        private void DoIt()
        {
            DestroyImmediate(FindObjectOfType<WaveManager>());
            foreach (var creep in FindObjectsOfType<Creep>())
            {
                DestroyImmediate(creep.gameObject);
            }

            foreach (var renderer1 in FindObjectsOfType<MeshRenderer>())
            {
                var meshCollider = renderer1.gameObject.AddComponent<MeshCollider>();
                meshCollider.convex = true;
                meshCollider.skinWidth = .2f;
                var addComponent = renderer1.gameObject.AddComponent<Rigidbody>();
                addComponent.mass = Random.value + 1;
                addComponent.useGravity = false;
                addComponent.AddExplosionForce(200, transform.position, 10, 2);
            }
        }
    }
}