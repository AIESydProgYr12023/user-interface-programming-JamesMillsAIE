using UnityEngine;
using UnityEngine.SceneManagement;

namespace AIE04_SceneLoading
{
	public class SceneLoading : MonoBehaviour
	{
		[SerializeField] private bool isSphereScene;
		[SerializeField] private bool loadAdditively;

		private void OnGUI()
		{
			if(isSphereScene)
			{
				// Load the cube scene if this button is pressed
				if(GUILayout.Button("Load Cube Scene"))
				{
					SceneManager.LoadSceneAsync("AIE04_SceneLoading_Cube", loadAdditively ? LoadSceneMode.Additive : LoadSceneMode.Single);
				}
			}
			else
			{
				// Load the sphere scene if this button is pressed
				if(GUILayout.Button("Load Sphere Scene"))
				{
					SceneManager.LoadScene("AIE04_SceneLoading_Sphere", loadAdditively ? LoadSceneMode.Additive : LoadSceneMode.Single);
				}
			}
		}
	}
}