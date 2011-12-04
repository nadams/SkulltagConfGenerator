using System;
using System.Collections.Generic;
using System.Linq;
using SkulltagConfGenerator.Domain.Extensions;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Enumerations.Utils;

namespace SkulltagConfGenerator.Domain.Model {
	public class DMFlags3Wrapper : IFlagWrapper<DMFlags3> {
		#region Fields

		private DMFlags3 flag;

		#endregion

		public DMFlags3Wrapper() {
			this.flag = 0;
		}

		public DMFlags3Wrapper(int value) {
			this.flag = (DMFlags3)value;
		}

		public IEnumerable<IFlagWrapper<DMFlags3>> GetAllFlags() {
			foreach(DMFlags3 dmflag in Enum.GetValues(typeof(DMFlags3))) {
				yield return new DMFlags3Wrapper((int)dmflag);
			}
		}

		public IEnumerable<string> GetAlternateNames() {
			IEnumerable<string> alternateNames = this.GetAllFlags().Select(x => x.GetAlternateName());

			return alternateNames;
		}

		public IEnumerable<IFlagWrapper<DMFlags3>> GetFlags(int value) {
			DMFlags3 flag = (DMFlags3)value;

			foreach(var dmflag in flag.GetIndividualValues<DMFlags3>()) {
				yield return new DMFlags3Wrapper((int)dmflag);
			}
		}

		public string GetAlternateName() {
			return this.flag.GetFirstAlternateName();
		}

		public string GetStringValue() {
			return this.flag.GetStringValue();
		}

		public int GetValue() {
			return (int)this.flag;
		}
	}
}
