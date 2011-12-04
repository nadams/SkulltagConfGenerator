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
	public class CompatFlagsViewModelTests {

		[TestMethod]
		public void FlagsValue_SetFlagsValueToPowerOfTwoNumber_GetSingleFlagBack() {
			CompatFlags testFlag = CompatFlags.LimitedMovementInAir;

			CompatFlagsViewModel viewModel = new CompatFlagsViewModel() {
				FlagsValue = 131072
			};

			CompatFlags resultFlag = (CompatFlags)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueTwoFlags_GetTwoFlagsBack() {
			CompatFlags testFlag = CompatFlags.DisableCrosshair | CompatFlags.InfinitelyTallActors;

			CompatFlagsViewModel viewModel = new CompatFlagsViewModel() {
				FlagsValue = 16 | 33554432
			};

			CompatFlags resultFlag = (CompatFlags)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueFourFlags_GetFourFlagsBack() {
			CompatFlags testFlag = CompatFlags.OriginalIntermissionScreens |
									CompatFlags.UseDoomsShortestTextureAroundBehavior |
									CompatFlags.DisableTaunting |
									CompatFlags.MonstersCannotBePushedOverDropoffs;

			CompatFlagsViewModel viewModel = new CompatFlagsViewModel() {
				FlagsValue = 4194304 | 1048576 | 1 | 1073741824
			};

			CompatFlags resultFlag = (CompatFlags)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}
	}
}
