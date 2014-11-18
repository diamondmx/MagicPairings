﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Magic.Core
{
	[System.Data.Linq.Mapping.Table(Name = "Players")]
	public class dbPlayer
	{
		[System.Data.Linq.Mapping.Column(IsPrimaryKey = true)]
		public string Name;
	}

	[System.Data.Linq.Mapping.Table(Name = "Matches")]
	public class dbMatch
	{
		[System.Data.Linq.Mapping.Column()]
		public string Player1;
		[System.Data.Linq.Mapping.Column()]
		public string Player2;
		[System.Data.Linq.Mapping.Column()]
		public int Round;
		[System.Data.Linq.Mapping.Column()]
		public string Event;
		[System.Data.Linq.Mapping.Column()]
		public int Player1Wins;
		[System.Data.Linq.Mapping.Column()]
		public int Player2Wins;
		[System.Data.Linq.Mapping.Column()]
		public int Draws;
		[System.Data.Linq.Mapping.Column()]
		public bool InProgress;
	}

	[System.Data.Linq.Mapping.Table(Name = "Events")]
	public class dbEvent
	{
		[System.Data.Linq.Mapping.Column()]
		public string Name;

		[System.Data.Linq.Mapping.Column()]
		public Int32 matchesInRound;

		[System.Data.Linq.Mapping.Column()]
		public Int32 rounds;

		[System.Data.Linq.Mapping.Column()]
		public bool complete;


	}

	[System.Data.Linq.Mapping.Table(Name = "EventPlayers")]
	public class dbEventPlayers
	{
		[System.Data.Linq.Mapping.Column()]
		public string EventName;

		[System.Data.Linq.Mapping.Column()]
		public string PlayerName;

		[System.Data.Linq.Mapping.Column()]
		bool Dropped;
	}
}