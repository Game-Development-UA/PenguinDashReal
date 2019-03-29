using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeLabelText : MonoBehaviour
{
	public TextMeshProUGUI label;

	public void ChangeText( string newText ) {
		label.text = newText;
	}
}
