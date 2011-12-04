using SkulltagConfGenerator.Enumerations;
using SkulltagConfGenerator.Enumerations.Utils;

namespace SkulltagConfGenerator.GUI.Model {
	public class DMFlag3 : Flag {
		public DMFlag3() { }

		public DMFlag3(DMFlags3 flag) : base((int)flag, flag.GetFirstAlternateName(), flag.GetStringValue()) { }
	}
}
