using Assets.Scripts.Entities;
using UnityEngine;

namespace Assets.Scripts.Logic
{
    public class InterestManager : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private float interestRate;
        [SerializeField] private float interestInterval;
        private float lastTime;

        public float UntilInterest => lastTime + interestInterval - Time.time;

        private void Update()
        {
            if (lastTime + interestInterval < Time.time)
            {
                EarnInterest();
                lastTime = Time.time;
            }
        }

        private void Awake()
        {
            lastTime = Time.time;
        }

        private void EarnInterest()
        {
            player.Money += Mathf.Max((int) (player.Money * interestRate), 1);
        }
    }
}