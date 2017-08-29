using System;
using Xamarin.Forms;

namespace FormSample.Behaviors
{
    public class NumberValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            int result;

            bool isValid = int.TryParse(args.NewTextValue, out result);

            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;

            String value = ((Entry)sender).Text;
            if (!isValid){
                value = value.Remove(value.Length-1);
                ((Entry)sender).Text = value;
            }
        }
    }
}
