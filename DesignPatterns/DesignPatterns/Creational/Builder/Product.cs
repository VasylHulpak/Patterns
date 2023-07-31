namespace DesignPatterns.Creational.Builder
{
	/// <summary>
	/// Class Product.
	/// </summary>
	public class Product
	{
		private List<object> _parts = new List<object>();
    
		/// <summary>
		/// Method Add.
		/// </summary>
		/// <param name="part"></param>
		public void Add(string part)
		{
			_parts.Add(part);
		}
    
		/// <summary>
		/// Method ListParts.
		/// </summary>
		/// <returns>string</returns>
		public string ListParts()
		{
			string str = string.Empty;

			for (int i = 0; i < this._parts.Count; i++)
			{
				str += this._parts[i] + ", ";
			}

			str = str.Remove(str.Length - 2); 

			return "Product parts: " + str + "\n";
		}
	}
}
