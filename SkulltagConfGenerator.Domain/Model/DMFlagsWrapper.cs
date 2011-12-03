using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Enumerations.Utils;
using SkulltagConfGenerator.Domain.Extensions;

namespace SkulltagConfGenerator.Domain.Model {
	public class DMFlagsWrapper : IFlagWrapper<DMFlags> {

		#region Fields

		private DMFlags flag;

		#endregion

		public DMFlagsWrapper() {
			this.flag = 0;
		}

		public DMFlagsWrapper(int value) {
			this.flag = (DMFlags)value;
		}

		public IEnumerable<IFlagWrapper<DMFlags>> GetAllFlags() {
			foreach(DMFlags dmflag in Enum.GetValues(typeof(DMFlags))) {
				yield return new DMFlagsWrapper((int)dmflag);
			}
		}

		public IEnumerable<string> GetAlternateNames() {
			IEnumerable<string> alternateNames = this.GetAllFlags().Select(x => x.GetAlternateName());

			return alternateNames;
		}

		public IEnumerable<IFlagWrapper<DMFlags>> GetFlags(int value) {
			DMFlags flag = (DMFlags)value;

			foreach(var dmflag in flag.GetIndividualValues<DMFlags>()) {
				yield return new DMFlagsWrapper((int)dmflag);
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
