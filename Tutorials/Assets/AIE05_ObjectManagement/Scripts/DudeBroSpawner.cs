using UnityEngine;

namespace AIE05_ObjectManagement
{
	public class DudeBroSpawner : MonoBehaviour
	{
		[SerializeField, Range(1, 20)] private int dudeBroAmount = 15;
		[SerializeField] private GameObject[] dudeBroPrefabs;

		private void Start()
		{
			DontDestroyOnLoad(gameObject);
			
			for(int i = 0; i < dudeBroAmount; i++)
			{
				GameObject newDudeBro = Instantiate(dudeBroPrefabs[Random.Range(0, dudeBroPrefabs.Length)]);

				Vector2 pos = Random.insideUnitCircle.normalized * 5;
				newDudeBro.transform.position = new Vector3(pos.x, newDudeBro.transform.position.y, pos.y);

				Vector3 heading = newDudeBro.transform.position - dudeBroPrefabs[0].transform.position;
				
				newDudeBro.transform.forward = -heading.normalized;
				// newDudeBro.transform.Rotate(Vector3.up, 90);
			}
		}
	}
}