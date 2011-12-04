using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Enumerations.Utils;

namespace SkulltagConfGenerator.GUI.Model {
	public class CompatFlag : Flag {
		public CompatFlag() { }

		public CompatFlag(CompatFlags flag) : base((int)flag, flag.GetFirstAlternateName(), flag.GetStringValue()) { }
	}
}
