using UnityEngine;

namespace BrokenVector.LowPolyFencePack
{
  
    [RequireComponent(typeof(DoorController))]
	public class DoorToggle : MonoBehaviour
    {

        private DoorController doorController;

        private bool isOpen = false;

        void Awake()
        {
            doorController = GetComponent<DoorController>();
        }


        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "Player")
            {
                if (isOpen == false)
                {
                    doorController.ToggleDoor();

                    isOpen = true;
                }

                //doorController.ToggleDoor();

            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                if (isOpen == true)
                {
                    doorController.ToggleDoor();

                    isOpen=false;
                }
               // doorController.ToggleDoor();

            }
        }
    }
}