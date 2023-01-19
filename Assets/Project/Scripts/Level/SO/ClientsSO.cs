using Cooking.Level.Hole;
using UnityEngine;

namespace Cooking
{
    [CreateAssetMenu(fileName = "Clients", menuName = "ScriptableObjects/Clients", order = 1)]
    public class ClientsSO : ScriptableObject
    {
        [SerializeField] private Client boy1;
        [SerializeField] private Client boy2;
        [SerializeField] private Client boy3;
        [SerializeField] private Client boy4;
        [SerializeField] private Client girl1;
        [SerializeField] private Client girl2;
        [SerializeField] private Client girl3;
        [SerializeField] private Client man1;
        [SerializeField] private Client man2;
        [SerializeField] private Client man3;

        public Client GetClientByName(string name)
        {
            return name switch
            {
                "boy1" => boy1,
                "boy2" => boy2,
                "boy3" => boy3,
                "boy4" => boy4,
                "girl1" => girl1,
                "girl2" => girl2,
                "girl3" => girl3,
                "man1" => man1,
                "man2" => man2,
                "man3" => man3,
                _ => null
            };
        }
    }
}