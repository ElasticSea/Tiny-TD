using System.Collections;
using Assets.Scripts.Entities;
using UnityEngine;

namespace Assets.Scripts
{
    public class WaveManager : MonoBehaviour
    {
        [SerializeField] private float waveInterval;
        [SerializeField] private float creepInterval;
        [SerializeField] private int creeps;

        [SerializeField] private Creep creepPrefab;
        [SerializeField] private Path path;
        private Wave wave;

        private void Awake()
        {
            StartCoroutine(SpawnWave());
        }

        private IEnumerator SpawnWave()
        {
            wave = new Wave();
            wave.OnDeath += () =>
            {
                // TODO wave killed run the next wave
            };

            StartCoroutine(SpawnCreep());

            yield return new WaitForSeconds(waveInterval);

            StartCoroutine(SpawnWave());
        }

        private IEnumerator SpawnCreep()
        {
            for (int i = 0; i < creeps; i++)
            {
                var creep = Instantiate(creepPrefab);
                creep.Path = path;
                wave.Add(creep);
                yield return new WaitForSeconds(creepInterval);
            }
        }
    }
}