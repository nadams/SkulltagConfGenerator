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
	public class CompatFlags2ViewModelTests {

		[TestMethod]
		public void FlagsValue_SetFlagsValueToPowerOfTwoNumber_GetSingleFlagBack() {
			CompatFlags2 testFlag = CompatFlags2.UseOldRandomGenerator;

			CompatFlags2ViewModel viewModel = new CompatFlags2ViewModel() {
				FlagsValue = 8
			};

			CompatFlags2 resultFlag = (CompatFlags2)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueTwoFlags_GetTwoFlagsBack() {
			CompatFlags2 testFlag = CompatFlags2.ClientSideScripts | CompatFlags2.AddNOGRAVITYToSomeActorsWhenSpawnedByMap;

			CompatFlags2ViewModel viewModel = new CompatFlags2ViewModel() {
				FlagsValue = 16 | 1
			};

			CompatFlags2 resultFlag = (CompatFlags2)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}

		[TestMethod]
		public void FlagsValue_SetFlagsValueFourFlags_GetFourFlagsBack() {
			CompatFlags2 testFlag = CompatFlags2.ClientsSendFullButtonInfo |
								CompatFlags2.NoLand |
								CompatFlags2.AddNOGRAVITYToSomeActorsWhenSpawnedByMap |
								CompatFlags2.UseOldRandomGenerator;

			CompatFlags2ViewModel viewModel = new CompatFlags2ViewModel() {
				FlagsValue = 2 | 4 | 8 | 16
			};

			CompatFlags2 resultFlag = (CompatFlags2)viewModel.FlagsValue;

			Assert.AreEqual(testFlag, resultFlag);
		}
	}
}
