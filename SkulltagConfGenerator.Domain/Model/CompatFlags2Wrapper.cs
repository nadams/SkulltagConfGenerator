using System;
using System.Collections.Generic;
using System.Linq;
using SkulltagConfGenerator.Domain.Extensions;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Enumerations.Utils;

namespace SkulltagConfGenerator.Domain.Model {
	public class CompatFlags2Wrapper : IFlagWrapper<CompatFlags2> {
		#region Fields

		private CompatFlags2 flag;

		#endregion

		public CompatFlags2Wrapper() {
			this.flag = 0;
		}

		public CompatFlags2Wrapper(int value) {
			this.flag = (CompatFlags2)value;
		}

		public IEnumerable<IFlagWrapper<CompatFlags2>> GetAllFlags() {
			foreach(CompatFlags2 dmflag in Enum.GetValues(typeof(CompatFlags2))) {
				yield return new CompatFlags2Wrapper((int)dmflag);
			}
		}

		public IEnumerable<string> GetAlternateNames() {
			IEnumerable<string> alternateNames = this.GetAllFlags().Select(x => x.GetAlternateName());

			return alternateNames;
		}

		public IEnumerable<IFlagWrapper<CompatFlags2>> GetFlags(int value) {
			CompatFlags2 flag = (CompatFlags2)value;

			foreach(var dmflag in flag.GetIndividualValues<CompatFlags2>()) {
				yield return new CompatFlags2Wrapper((int)dmflag);
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
