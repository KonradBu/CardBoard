using System;
namespace CardBoard
{
	public class CardBoardProject
	{
		public string name { get; set; }
		public string file_location { get; set; }
		public CardBoardProject(string name, string file_location)
		{
			this.name = name;
			this.file_location = file_location;
		}
	}
}