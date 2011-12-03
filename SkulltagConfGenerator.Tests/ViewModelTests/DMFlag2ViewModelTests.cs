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
	public class DMFlag2ViewModelTests {

		[TestMethod]
		public void FlagsValue_SetFlagsValueToPowerOfTwoNumber_GetSingleFlagBack() {
			DMFlags2 testFlag = DMFlags2.NoRespawnProtection;

			FlagViewModel<DMFlag2, DMFlags2> viewModel = new FlagViewModel<DMFlag2, DMFlags2>(new DMFlags2Wrapper()) {
				FlagsValue = 1024
			};

			DMFlags2 resultFlag = (DMFlags2)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueTwoFlags_GetTwoFlagsBack() {
			DMFlags2 testFlag = DMFlags2.NoRespawnProtection | DMFlags2.HealthDrain;

			FlagViewModel<DMFlag2, DMFlags2> viewModel = new FlagViewModel<DMFlag2, DMFlags2>(new DMFlags2Wrapper()) {
				FlagsValue = 1024 | 128
			};

			DMFlags2 resultFlag = (DMFlags2)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueFourFlags_GetFourFlagsBack() {
			DMFlags2 testFlag = DMFlags2.NoRespawnProtection |
								DMFlags2.HealthDrain |
								DMFlags2.BFGFreelook |
								DMFlags2.EnforceOpenGLRenderingOptions;

			FlagViewModel<DMFlag2, DMFlags2> viewModel = new FlagViewModel<DMFlag2, DMFlags2>(new DMFlags2Wrapper()) {
				FlagsValue = 1024 | 128 | 256 | 262144
			};

			DMFlags2 resultFlag = (DMFlags2)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}
	}
}
