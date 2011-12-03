using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SkulltagConfGenerator.GUI.ViewModel {
	public abstract class FlagViewModel<T> : ViewModelBase {
		public abstract int FlagsValue { get; set; }
		public abstract IEnumerable<T> FlagModel { get; }

		protected virtual void RaiseFlagsValuePropertyChange(object sender, PropertyChangedEventArgs e) {
			this.RaiseFlagsValuePropertyChange();
		}

		protected virtual void RaiseFlagsValuePropertyChange() {
			this.RaisePropertyChanged("FlagsValue");
		}
	}
}
