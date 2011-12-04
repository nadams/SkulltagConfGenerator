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
	public class DMFlags3ViewModelTests {

		[TestMethod]
		public void FlagsValue_SetFlagsValueToPowerOfTwoNumber_GetSingleFlagBack() {
			DMFlags3 testFlag = DMFlags3.EnforcesClientNotToIdentifyPlayers;

			DMFlags3ViewModel viewModel = new DMFlags3ViewModel() {
				FlagsValue = 1
			};

			DMFlags3 resultFlag = (DMFlags3)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueTwoFlags_GetTwoFlagsBack() {
			DMFlags3 testFlag = DMFlags3.EnforcesClientNotToIdentifyPlayers | DMFlags3.DisableUnlagged;

			DMFlags3ViewModel viewModel = new DMFlags3ViewModel() {
				FlagsValue = 1 | 8
			};

			DMFlags3 resultFlag = (DMFlags3)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueFourFlags_GetFourFlagsBack() {
			DMFlags3 testFlag = DMFlags3.ApplyLMSSpectatorSettingsInallGameModes |
								DMFlags3.DoNotDrawCoopInfo |
								DMFlags3.DisableUnlagged |
								DMFlags3.EnforcesClientNotToIdentifyPlayers;

			DMFlags3ViewModel viewModel = new DMFlags3ViewModel() {
				FlagsValue = 2 | 8 | 1 | 4
			};

			DMFlags3 resultFlag = (DMFlags3)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}
	}
}
