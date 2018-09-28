using _3Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3RemoteController
{
    public class RemoteControl<T>{
        private IExChangeAble<T> host;

        public List<Button<T>> Buttons { get; set; }

        public RemoteControl(IExChangeAble<T> host) {
            this.host = host;
            this.Buttons = new List<Button<T>>();
        }

        public void PressButton(string btn) {
            foreach (var item in Buttons) {
                if (item.Description.Equals(btn)) {
                    Submit(item.Click());
                    break;
                }
            }
        }

        private void Submit(T toSubmit) {
            host.Exchange(toSubmit);
        }
        public void Exchange(T data) {
            throw new NotImplementedException();
        }

    }
}
