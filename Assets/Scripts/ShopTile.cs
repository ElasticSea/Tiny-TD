using System;
using Assets.Core.Extensions;
using Assets.Scripts.Entities;
using Assets.Scripts.LevelEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ShopTile : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private RawImage image;
        [SerializeField] private Text label;
        [SerializeField] private Material grayscale;

        private Tower item;
        private RenderMesh renderMesh;
        private bool towerEnabled;

        public event Action<Tower> OnClick = t => { };
        public Tower Item
        {
            get { return item; }
            set
            {
                item = value;
                label.text = item.name.ToUpper();
                GameObject copy = null;
                Func<GameObject> clone = () =>
                {
                    copy = Instantiate(item.gameObject);
                    copy.GetComponentsInChildren<Behaviour>().ForEach(b => b.enabled = false);
                    return copy;
                };
                var meshJob = new RenderMesh.MeshJob()
                {
                    GameObject = clone,
                    Callback = tex =>
                    {
                        if (image)
                        {
                            image.texture = tex;
                        }

                        DestroyImmediate(copy);
                    },
                    Height = 200,
                    Width = 200
                };
                renderMesh.Render(meshJob);
            }
        }

        public bool Enabled
        {
            get { return towerEnabled; }
            set
            {
                towerEnabled = value;
                image.material = value ? null : grayscale;
            }
        }

        private void Awake()
        {
            renderMesh = FindObjectOfType<RenderMesh>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (Enabled) OnClick(Item);
        }
    }
}