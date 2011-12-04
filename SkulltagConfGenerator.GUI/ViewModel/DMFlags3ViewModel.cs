using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkulltagConfGenerator.GUI.Model;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Domain.Model;

namespace SkulltagConfGenerator.GUI.ViewModel {
	public class DMFlags3ViewModel : FlagViewModel<DMFlag3, DMFlags3> {
		public DMFlags3ViewModel() : base(new DMFlags3Wrapper()) { }
	}
}
