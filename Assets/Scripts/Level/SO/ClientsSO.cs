using Cooking.Level.Hole;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking
{
    [CreateAssetMenu(fileName = "Clients", menuName = "ScriptableObjects/Clients", order = 1)]
    public class ClientsSO : ScriptableObject
    {
        [SerializeField] private List<Client> clients;

        public List<Client> Clients => clients;
    }
}