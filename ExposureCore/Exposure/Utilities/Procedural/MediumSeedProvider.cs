﻿using Exposure.Contracts;

namespace Exposure.Utilities.Procedural {
	public class MediumSeedProvider : BaseSeedProvider {
		private static int seedLength = 150;

		public MediumSeedProvider() : base(seedLength) {

		}
	}
}