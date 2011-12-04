using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.GUI.ViewModel;
using SkulltagConfGenerator.GUI.Model;
using SkulltagConfGenerator.Domain.Model;

namespace SkulltagConfGenerator.Tests.ViewModelTests {

	[TestClass]
	public class DMFlagsViewModelTests {

		[TestMethod]
		public void FlagsValue_SetFlagsValueToPowerOfTwoNumber_GetSingleFlagBack() {
			DMFlags testFlag = DMFlags.KillOnExit;

			DMFlagsViewModel viewModel = new DMFlagsViewModel() {
				FlagsValue = 1024
			};

			DMFlags resultFlag = (DMFlags)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueTwoFlags_GetTwoFlagsBack() {
			DMFlags testFlag = DMFlags.KillOnExit | DMFlags.SpawnPlayersFarAway;

			DMFlagsViewModel viewModel = new DMFlagsViewModel() {
				FlagsValue = 1024 | 128
			};

			DMFlags resultFlag = (DMFlags)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueFourFlags_GetFourFlagsBack() {
			DMFlags testFlag =  DMFlags.KillOnExit | 
								DMFlags.SpawnPlayersFarAway | 
								DMFlags.RespawnDeadPlayers | 
								DMFlags.MegaPowerupsRespawn;

			DMFlagsViewModel viewModel = new DMFlagsViewModel() {
				FlagsValue = 1024 | 128 | 256 | 262144
			};

			DMFlags resultFlag = (DMFlags)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}
	}
}
