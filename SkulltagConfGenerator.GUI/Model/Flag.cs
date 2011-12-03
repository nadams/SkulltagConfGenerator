using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;

namespace SkulltagConfGenerator.GUI.Model {
	public abstract class Flag : ViewModelBase {

		#region Fields

		private string name, description;
		private int value;
		private bool isChecked;

		#endregion

		#region Properties

		public int Value {
			get {
				return this.value;
			}

			set {
				this.value = value;
			}
		}

		public string Name {
			get {
				return this.name;
			}

			set {
				this.name = value;
			}
		}

		public string Description {
			get {
				return string.Format("{0} ({1})", this.description, this.value);
			}

			set {
				this.description = value;
			}
		}

		public bool IsEnabled {
			get {
				return this.isChecked;
			}

			set {
				this.isChecked = value;
				this.RaisePropertyChanged("IsEnabled");
			}
		}

		#endregion

		public Flag() { }

		public Flag(int value, string name, string description) {
			this.IsEnabled = false;
			this.value = value;
			this.name = name;
			this.description = description;
		}
	}
}
