using System.Collections.Generic;
using UnityEngine;
using Cooking.Level.Hole.Clients;

namespace Cooking
{
    [CreateAssetMenu(fileName = "Clients", menuName = "ScriptableObjects/Clients", order = 1)]
    public class ClientsSO : ScriptableObject
    {
        [SerializeField] private List<ClientView> clients;

        public List<ClientView> Clients => clients;
    }
}