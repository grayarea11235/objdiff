using System;

namespace objdiff
{
	public class ObjectDifference
	{
		public ObjectDifference ()
		{
		}
		
		public void ComparePorperties(object left, object right)
		{
			var leftType = left.GetType();	
			var rightType = right.GetType();

			var leftProperties = leftType.GetProperties();
			var rightProperties = rightType.GetProperties();


			foreach (var leftProperty in leftProperties)
			{
				Console.WriteLine(leftProperty.Name + " " + leftProperty.GetValue(leftProperty, null).ToString());
			}

		}
	}
}

