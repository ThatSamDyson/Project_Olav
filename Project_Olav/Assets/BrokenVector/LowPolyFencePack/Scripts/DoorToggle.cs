using UnityEngine;

namespace BrokenVector.LowPolyFencePack
{
  
    [RequireComponent(typeof(DoorController))]
	public class DoorToggle : MonoBehaviour
    {

        private DoorController doorController;

        void Awake()
        {
            doorController = GetComponent<DoorController>();
        }


        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "Player")
            {
                doorController.ToggleDoor();

            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                doorController.ToggleDoor();

            }
        }
    }
}