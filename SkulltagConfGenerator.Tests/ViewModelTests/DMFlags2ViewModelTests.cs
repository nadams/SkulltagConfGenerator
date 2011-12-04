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
	public class DMFlags2ViewModelTests {

		[TestMethod]
		public void FlagsValue_SetFlagsValueToPowerOfTwoNumber_GetSingleFlagBack() {
			DMFlags2 testFlag = DMFlags2.NoPlayerSwitching;

			DMFlags2ViewModel viewModel = new DMFlags2ViewModel() {
				FlagsValue = 16
			};

			DMFlags2 resultFlag = (DMFlags2)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueTwoFlags_GetTwoFlagsBack() {
			DMFlags2 testFlag = DMFlags2.EnforceAlphaOptions | DMFlags2.LoseFragWhenKilled;

			DMFlags2ViewModel viewModel = new DMFlags2ViewModel() {
				FlagsValue = 65536 | 2097152
			};

			DMFlags2 resultFlag = (DMFlags2)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueFourFlags_GetFourFlagsBack() {
			DMFlags2 testFlag = DMFlags2.DropWeaponOnDeath |
								DMFlags2.NoPlayerSwitching |
								DMFlags2.SpawnSinglePlayerActors |
								DMFlags2.RespawnInSamePlace;

			DMFlags2ViewModel viewModel = new DMFlags2ViewModel() {
				FlagsValue = 4096 | 2 | 536870912 | 16
			};

			DMFlags2 resultFlag = (DMFlags2)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}
	}
}
