using UnityEngine;
using System.Collections;
using TMPro;

namespace QDS.MushWars
{
	public class TypeEffect : MonoBehaviour
	{
		public float Delay = 0.125f;
		
		private TMP_Text _text;
		private string _story;

		void Awake()
		{
			_text = GetComponent<TMP_Text>();
			_story = _text.text;
			_text.text = "";

			StartCoroutine("PlayText");
		}

		IEnumerator PlayText()
		{
			foreach (char c in _story)
			{
				_text.text += c;
				yield return new WaitForSeconds(Delay);
			}
		}
	}
}