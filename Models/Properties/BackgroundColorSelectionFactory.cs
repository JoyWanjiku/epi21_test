using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;

namespace epi21_test.Models.Properties
{
    public class BackgroundColorSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var selections = new List<ISelectItem>
            {
                new SelectItem { Value = "", Text = "Ingen klass vald" },
                new SelectItem { Value = "green", Text = "Nackademin grön" },
                new SelectItem { Value = "blue", Text = "Nackademin blå" },
                new SelectItem { Value = "red", Text = "Nackademin röd" },
                new SelectItem { Value = "black", Text = "Nackademin svart" },
            };

            return selections;
        }
    }
}