using Assets.Core.Extensions;
using Assets.Scripts.Entities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    public class Shop : MonoBehaviour
    {
        [SerializeField] private TowerUpgrade[] defaultUpgrades;
        [SerializeField] private ShopTile tilePrefab;
        [SerializeField] private Transform tileGrid;
        private ShadowTowerPlacer shadow;
        private TowerUpgrade upgrade;

        private void Start()
        {
            tileGrid.RemoveAllChildren();

            foreach (var defaultUpgrade in defaultUpgrades)
            {
                var tile = Instantiate(tilePrefab);
                tile.Item = defaultUpgrade.tower;
                tile.Enabled = FindObjectOfType<Player>().Money >= defaultUpgrade.price;
                tile.OnClick += tower => ShowTower(defaultUpgrade);
                tile.transform.SetParent(tileGrid, false);
            }
        }

        private void ShowTower(TowerUpgrade upgrade)
        {
            if(shadow) DestroyImmediate(shadow.gameObject);
            shadow = new GameObject("Shadow Tower Place").AddComponent<ShadowTowerPlacer>();
            shadow.Tower = upgrade.tower;
            this.upgrade = upgrade;
        }

        private void Update()
        {
            if (shadow && shadow.Valid && Input.GetMouseButtonDown(0) && IsPointerOverGameObject() == false)
            {
                var tower = Instantiate(shadow.Tower);
                FindObjectOfType<Player>().Money -= upgrade.price;
                tower.transform.position = shadow.transform.position;
                DestroyImmediate(shadow.gameObject);
            }
        }
        private static bool IsPointerOverGameObject()
        {
#if !UNITY_EDITOR && (UNITY_ANDROID || UNITY_IPHONE)
        const int fingerId = 0;
#else
            const int fingerId = -1;
#endif

            return EventSystem.current.IsPointerOverGameObject(fingerId);
        }
    }
}