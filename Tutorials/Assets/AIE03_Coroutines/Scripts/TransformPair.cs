using System;

using UnityEngine;

namespace AIE03_Coroutines
{
	[Serializable]
	public class TransformPair
	{
		public Transform transform;
		public Color gizmoColor = Color.white;

		public void Apply(Transform _transform)
		{
			_transform.position = transform.position;
			_transform.rotation = transform.rotation;
			_transform.localScale = transform.localScale;
		}
	}
}