using AIE.Characters;

using UnityEngine;

namespace AIE09_Physics
{
	public class DeathZone : MonoBehaviour
	{
		[SerializeField] private CharacterMotor player;
		[SerializeField] private Transform respawnPoint;

		private void OnTriggerEnter(Collider _other)
		{
			if(_other.gameObject == player.gameObject)
			{
				// respawn
				_other.attachedRigidbody.velocity = Vector3.zero;
				_other.transform.position = respawnPoint.position;
				_other.transform.rotation = respawnPoint.rotation;
				_other.attachedRigidbody.velocity = Vector3.zero;
			}
			else
			{
				// Destroy any balls that hit this
				Destroy(_other.gameObject);
			}
		}
	}
}