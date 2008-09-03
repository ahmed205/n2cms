using System;
using System.Collections.Generic;
using System.Text;
using N2.Integrity;
using N2.Details;
using N2.Templates.Items;

namespace N2.Templates.Items
{
    [Definition("Statistics", "Statistics")]
    [WithEditableTitle("Title", 10)]
    [RestrictParents(typeof(RootPage))]
    [AllowedZones(Zones.Left, "Center", Zones.Right)]
    public class Statistics : AbstractItem
    {
        [Editable("Latest changes max count", typeof(System.Web.UI.WebControls.TextBox), "Text", 100)]
        public virtual int LatestChangesMaxCount
        {
            get { return (int)(GetDetail("LatestChangesMaxCount") ?? 5); }
            set { SetDetail("LatestChangesMaxCount", value); }
        }

        protected override string TemplateName
        {
            get { return "Statistics"; }
        }
    }
}