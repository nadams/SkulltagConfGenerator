using System;
using System.Collections.Generic;
using System.Linq;
using SkulltagConfGenerator.Domain.Extensions;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Enumerations.Utils;

namespace SkulltagConfGenerator.Domain.Model {
	public class CompatFlagsWrapper : IFlagWrapper<CompatFlags> {
		#region Fields

		private CompatFlags flag;

		#endregion

		public CompatFlagsWrapper() {
			this.flag = 0;
		}

		public CompatFlagsWrapper(int value) {
			this.flag = (CompatFlags)value;
		}

		public IEnumerable<IFlagWrapper<CompatFlags>> GetAllFlags() {
			foreach(CompatFlags compatflag in Enum.GetValues(typeof(CompatFlags))) {
				yield return new CompatFlagsWrapper((int)compatflag);
			}
		}

		public IEnumerable<string> GetAlternateNames() {
			IEnumerable<string> alternateNames = this.GetAllFlags().Select(x => x.GetAlternateName());

			return alternateNames;
		}

		public IEnumerable<IFlagWrapper<CompatFlags>> GetFlags(int value) {
			CompatFlags flag = (CompatFlags)value;

			foreach(var compatflag in flag.GetIndividualValues<CompatFlags>()) {
				yield return new CompatFlagsWrapper((int)compatflag);
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
