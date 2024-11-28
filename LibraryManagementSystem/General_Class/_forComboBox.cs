using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Notice.Warning.Types;

namespace LibraryManagementSystem.General_Class
{
    internal class _forComboBox
    {
        string[] categories =
        {
            "Biography and Memoir",
            "History",
            "Science and Nature",
            "Self-Help and Personal Development",
            "Travel and Adventure",
            "Religion and Spirituality",
            "Cookbooks and Food",
            "Health and Wellness",
            "Technology and Programming",
            "STEM",
            "Social Sciences",
            "Humanities",
            "Business and Management",
            "Law and Legal Studies",
            "Medicine and Health Science",
            "Education",
            "Reference Materials",
            "Thesis",
            "Academic Journals"
        };
        public _forComboBox(ComboBox combo)
        {
            for (int i = 0; i < categories.Length; i++)
            {
                combo.Items.Add(categories[i]);
            }
        }
    }
}
