using UnityEngine;

namespace Assets.Scripts.Entities
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int money;

        public int Money
        {
            get { return money; }
            set { money = value; }
        }
    }
}