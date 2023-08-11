using UnityEngine;

namespace AIE05_ObjectManagement
{
	public class DudeBroController : MonoBehaviour
	{
		private void OnMouseUpAsButton()
		{
			Destroy(gameObject);
		}
	}
}