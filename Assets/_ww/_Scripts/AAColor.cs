
/***********************************************************************************************************
 * Produced by App Advisory - http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/



#if AADOTWEEN
using UnityEngine;
using System;
using System.Collections;


/// <summary>
/// Class to encapsulate color dark and color bright, color bright is the background
/// </summary>
[Serializable]
public class AAColor
{
	[SerializeField] public Color colorBright = Color.white;
	[SerializeField] public Color colorDark = Color.white;

	public AAColor()
	{
		this.colorBright = Color.white;
		this.colorDark = Color.white;
	}

	public AAColor(Color colorBright, Color colorDark)
	{
		this.colorBright = colorBright;
		this.colorDark = colorDark;
	}

	// Note that Color32 and Color implictly convert to each other. You may pass a Color object to this method without first casting it.
	string ColorToHex(Color32 color)
	{
		string hex = color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
		return hex;
	}

	Color HexToColor(string hex)
	{
		byte r = byte.Parse(hex.Substring(0,2), System.Globalization.NumberStyles.HexNumber);
		byte g = byte.Parse(hex.Substring(2,2), System.Globalization.NumberStyles.HexNumber);
		byte b = byte.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber);
		return new Color32(r,g,b, 255);
	}
}
#endif