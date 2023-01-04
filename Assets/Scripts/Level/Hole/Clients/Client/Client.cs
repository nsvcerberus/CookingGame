using System;
using UnityEngine;
using DG.Tweening;

namespace Cooking.Level.Hole
{
    public class Client : MonoBehaviour
    {
        public event Func<float> ReturnSpeed;
        public event Action PlaceAnOrder;

        //[SerializeField] private OrderListView orderList;

        public void GoToOrderPlaceFromEntryPlace(Vector3 position)
        {
            Sequence sequence = DOTween.Sequence();
            sequence
                .Append(transform.DOMove(position, ReturnSpeed.Invoke()))
                .AppendCallback(OnPlaceAnOrder);
        }

        public void GoFromOrderPlaceToExitPlace(Vector3 position)
        {

        }

        private void OnPlaceAnOrder() => PlaceAnOrder?.Invoke();

        public void SetPosition(Vector3 position) => transform.position = position;
        public void SetAsFirstSibling() => transform.SetAsFirstSibling();

        //public OrderListView OrderList => orderList;
    }
}