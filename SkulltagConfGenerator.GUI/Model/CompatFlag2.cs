using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Enumerations.Utils;

namespace SkulltagConfGenerator.GUI.Model {
	public class CompatFlag2 : Flag {
		public CompatFlag2() { }

		public CompatFlag2(CompatFlags2 flag) : base((int)flag, flag.GetFirstAlternateName(), flag.GetStringValue()) { }
	}
}
