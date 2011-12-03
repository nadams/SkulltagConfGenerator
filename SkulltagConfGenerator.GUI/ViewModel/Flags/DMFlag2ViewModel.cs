using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using SkulltagConfGenerator.Domain.Extensions;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Enumerations.Utils;
using SkulltagConfGenerator.GUI.Model;

namespace SkulltagConfGenerator.GUI.ViewModel.Flags {
	public class DMFlag2ViewModel : FlagViewModel<DMFlag2> {
		#region Fields

		private IEnumerable<DMFlag2> flags;

		#endregion

		#region Properties

		public override int FlagsValue {
			get {
				int flag = 0;

				foreach(DMFlag2 dmflag in this.FlagModel.Where(x => x.IsEnabled)) {
					flag |= dmflag.Value;
				}

				return flag;
			}

			set {
				DMFlags2 flag = (DMFlags2)value;

				IEnumerable<DMFlags2> validFlags = flag.GetIndividualValues<DMFlags2>();
				IEnumerable<string> splitFlagsAlternateNames = validFlags.Select(x => x.GetFirstAlternateName());
				IEnumerable<DMFlag2> enabledFlags = this.flags.Where(dmflag => splitFlagsAlternateNames.Contains(dmflag.Name));
				foreach(DMFlag2 dmflag in this.flags) {
					dmflag.IsEnabled = false;
				}

				foreach(var item in enabledFlags) {
					item.IsEnabled = true;
				}

				this.RaiseFlagsValuePropertyChange();
			}
		}

		public override IEnumerable<DMFlag2> FlagModel {
			get {
				return this.flags;
			}
		}

		#endregion

		public DMFlag2ViewModel() {
			List<DMFlag2> flags = new List<DMFlag2>();

			foreach(DMFlags2 item in Enum.GetValues(typeof(DMFlags2))) {
				DMFlag2 flag = new DMFlag2(item);
				flag.PropertyChanged += new PropertyChangedEventHandler(this.RaiseFlagsValuePropertyChange);
				flags.Add(flag);
			}

			this.flags = flags;
		}
	}
}
