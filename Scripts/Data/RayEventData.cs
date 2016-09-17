using System.Text;
using UnityEngine.EventSystems;

namespace UnityEngine.VR.Modules
{
	public class RayEventData : PointerEventData
	{
		/// <summary>
		/// The root from where the ray is cast
		/// </summary>
		public Transform rayOrigin { get; set; }

		/// <summary>
		/// The node associated with the ray
		/// </summary>
		public Node node { get; set; }

		/// <summary>
		/// The length of the direct selection pointer
		/// </summary>
		public float pointerLength { get; set; }

		/// <summary>
		/// The time the current object was pressed
		/// </summary>
		public float pressTime;

		public RayEventData(EventSystem eventSystem) : base(eventSystem)
		{
			pressTime = 0f;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine(base.ToString());
			sb.AppendLine("<b>Ray origin position<b>" + rayOrigin.position);
			sb.AppendLine("<b>Ray origin rotation<b>" + rayOrigin.rotation);
			sb.AppendLine("<b>node<b>" + node);
			sb.AppendLine("<b>pointerLength<b>" + pointerLength);
			sb.AppendLine("<b>pressTime<b>" + pressTime);
			return sb.ToString();
		}
	}
}
