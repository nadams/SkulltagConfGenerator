using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Domain.Extensions;
using SkulltagConfGenerator.Enumerations.Utils;

namespace SkulltagConfGenerator.Domain.Model {
	public class DMFlags2Wrapper : IFlagWrapper<DMFlags2> {

		#region Fields

		private DMFlags2 flag;

		#endregion

		public DMFlags2Wrapper() {
			this.flag = 0;
		}

		public DMFlags2Wrapper(int value) {
			this.flag = (DMFlags2)value;
		}

		public IEnumerable<IFlagWrapper<DMFlags2>> GetAllFlags() {
			foreach(DMFlags2 dmflag in Enum.GetValues(typeof(DMFlags2))) {
				yield return new DMFlags2Wrapper((int)dmflag);
			}
		}

		public IEnumerable<string> GetAlternateNames() {
			IEnumerable<string> alternateNames = this.GetAllFlags().Select(x => x.GetAlternateName());

			return alternateNames;
		}

		public IEnumerable<IFlagWrapper<DMFlags2>> GetFlags(int value) {
			DMFlags2 flag = (DMFlags2)value;

			foreach(var dmflag in flag.GetIndividualValues<DMFlags2>()) {
				yield return new DMFlags2Wrapper((int)dmflag);
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
