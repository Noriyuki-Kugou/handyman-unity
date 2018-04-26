using UnityEngine;

namespace SIGVerse.Competition.Handyman
{
	public class HandymanBirdsEyeViewCameraController : MonoBehaviour
	{
		public GameObject robot;

		private float cameraPosY;

		private void Start()
		{
			this.cameraPosY = this.transform.position.y;
		}

		private void LateUpdate()
		{
			this.transform.position = new Vector3(this.robot.transform.position.x, this.cameraPosY, this.robot.transform.position.z);
		}
	}
}
