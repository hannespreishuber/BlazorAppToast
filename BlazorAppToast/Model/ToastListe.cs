using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppToast.Model
{
    public class ToastListe
         {
             public event Action OnToastsUpdated;
             public ToastListe()
             {
                 Toasts = new List<ToastItem>();
              }
             public void Add(string par1)
             {
               var t = new ToastItem();
               t.Titel = par1;
               Toasts.Add(t);
     
                OnToastsUpdated?.Invoke();
            }
            public void Remove(string par1)
            {
                var item = Toasts.Where(x => x.Titel == par1).FirstOrDefault();
                Toasts.Remove(item);
     
                OnToastsUpdated?.Invoke();
            }
     
            public List<ToastItem> Toasts { get; set; }
        }
}
