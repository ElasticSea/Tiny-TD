using Assets.Scripts.Entities;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Ui : MonoBehaviour
    {
        [SerializeField] private Tower tower;
        [SerializeField] private Player player;
        [SerializeField] private Text moneyText;

        private void Update()
        {
            moneyText.text = $"{player.Money}$";
        }
    }
}