using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.GUI.Model;
using SkulltagConfGenerator.Domain.Model;

namespace SkulltagConfGenerator.GUI.ViewModel {
	public class DMFlags2ViewModel : FlagViewModel<DMFlag2, DMFlags2> {
		public DMFlags2ViewModel() : base(new DMFlags2Wrapper()) { }
	}
}
