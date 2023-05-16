using System.Collections.ObjectModel;

namespace SMCS.Web.SystemFiles
{
    public class SMCSClaims
    {
        public const string CAN_MANAGE_SYSTEM = "Can manage system";
        public const string CAN_MANAGE_USERS = "Can manage users";
        public const string CAN_VIEW_USERS = "Can view users";
        public const string CAN_MANAGE_ARTICLES = "Can manage articles";
        public const string CAN_VIEW_ARTICLES = "Can view articles";
        public const string CAN_MANAGE_TICKETS = "Can manage tickets";
        public const string CAN_VIEW_TICKETS = "Can view tickets";
        public const string CAN_MANAGE_DORMS = "Can manage dorms";
        public const string CAN_VIEW_DORMS = "Can view dorms";
        //public const string CAN_MANAGE_ = "";

        public static readonly IList<string> CLAIMS = new ReadOnlyCollection<string>
            (new List<String>
            {
                CAN_MANAGE_SYSTEM,
                CAN_MANAGE_USERS,
                CAN_VIEW_USERS,
                CAN_MANAGE_ARTICLES,
                CAN_VIEW_ARTICLES,
                CAN_MANAGE_TICKETS,
                CAN_VIEW_TICKETS,
                CAN_MANAGE_DORMS,
                CAN_VIEW_DORMS
            });
    }
}
