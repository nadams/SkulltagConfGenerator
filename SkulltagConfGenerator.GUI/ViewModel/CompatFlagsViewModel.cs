using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkulltagConfGenerator.GUI.Model;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Domain.Model;

namespace SkulltagConfGenerator.GUI.ViewModel {
	public class CompatFlagsViewModel : FlagViewModel<CompatFlag, CompatFlags> {
		public CompatFlagsViewModel() : base(new CompatFlagsWrapper()) { }
	}
}
