using System;
using Android.Content.PM;

namespace ContactListSample.Droid
{
    public static class PermissionUtil
    {
        public static bool VerifyPermissions(Permission[] grantResults)
        {
            if (grantResults.Length < 1)
                return false;

            foreach (Permission result in grantResults)
            {
                if (result != Permission.Granted)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
