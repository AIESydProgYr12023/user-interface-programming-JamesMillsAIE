using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace AIE03_Coroutines
{
	[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
	public class CoroutinesExtension : MonoBehaviour
	{
		[SerializeField, Range(0.1f, 5f)] private float interval = 1f;
		[SerializeField] private List<TransformPair> transforms;

		private void Start() => StartCoroutine(TransformUpdateLoop_CR());

		private IEnumerator TransformUpdateLoop_CR()
		{
			int index = 0;

			while(true)
			{
				transforms[index].Apply(transform);

				yield return new WaitForSeconds(interval);

				index++;
				if(index == transforms.Count)
					index = 0;
			}
		}
	}
}