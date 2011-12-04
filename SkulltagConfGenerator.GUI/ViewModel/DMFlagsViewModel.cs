using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.GUI.Model;
using SkulltagConfGenerator.Domain.Model;

namespace SkulltagConfGenerator.GUI.ViewModel {
	public class DMFlagsViewModel : FlagViewModel<DMFlag, DMFlags> {
		public DMFlagsViewModel() : base(new DMFlagsWrapper()) { }
	}
}
