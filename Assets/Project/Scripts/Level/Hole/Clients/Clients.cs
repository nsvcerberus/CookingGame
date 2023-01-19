using System.Threading.Tasks;
using UnityEngine;

namespace Cooking.Level.Hole
{
    public class Clients : MonoBehaviour
    {
        [SerializeField] private ClientsSO clientsSO;

        private void Start()
        {
            ClientsManager.instance.CreateClient += CreateClient;
        }

        public void CreateClient(Vector3 position)
        {
            Debug.Log("Create Client!");

            //await Task.Run(() => {
                //Debug.Log("client count = " + clientsSO.Clients.Count);
                //Debug.Log("client = " + clientsSO.Clients[1]);
                //Instantiate(clientsSO.Clients[0].gameObject, transform);
            //});
        }
    }
}