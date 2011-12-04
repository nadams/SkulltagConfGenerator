using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkulltagConfGenerator.GUI.Model;
using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Domain.Model;

namespace SkulltagConfGenerator.GUI.ViewModel {
	public class CompatFlags2ViewModel : FlagViewModel<CompatFlag2, CompatFlags2> {
		public CompatFlags2ViewModel() : base(new CompatFlags2Wrapper()) { }
	}
}
