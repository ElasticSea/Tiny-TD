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

        [SerializeField] private Creep[] creepPrefabs;
        [SerializeField] private Path path;
        private Wave wave;
        private int waveNum;

        private void Awake()
        {
            SpawnWave();
        }

        private void SpawnWave()
        {
            wave = new Wave();
            wave.OnDeath += () =>
            {
                if (waveNum < creepPrefabs.Length)
                {
                    SpawnWave();
                }
            };

            StartCoroutine(SpawnCreep(waveNum++));
        }

        private IEnumerator SpawnCreep(int waveN)
        {
            for (int i = 0; i < creeps; i++)
            {
                var creep = Instantiate(creepPrefabs[waveN]);
                creep.Path = path;
                wave.Add(creep);
                yield return new WaitForSeconds(creepInterval);
            }
        }
    }
}