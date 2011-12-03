using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkulltagConfGenerator.Domain.Model {
	public interface IFlagWrapper<T> {
		IEnumerable<IFlagWrapper<T>> GetAllFlags();
		IEnumerable<IFlagWrapper<T>> GetFlags(int value);
		string GetAlternateName();
		string GetStringValue();
		int GetValue();
	}
}
