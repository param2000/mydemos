using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace CustomFileHandlerDemo.Providers
{
    public class MyRoleProvider : RoleProvider
    {
        #region Not Implemented

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        #endregion

        public override string[] GetAllRoles()
        {
            return new string[] { "User", "Guest" };
        }

        public override string[] GetRolesForUser(string username)
        {
            if (username == "john")
            {
                return new string[] { "User" };
            }
            else if (username == "jane")
            {
                return new string[] { "Guest" };
            }
            else
            {
                return new string[] { };
            }
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            string[] roles = GetRolesForUser(username);
            return (roles.ToList().IndexOf(roleName) > -1);
        }

        public override bool RoleExists(string roleName)
        {
            string[] roles = GetAllRoles();
            return (roles.ToList().IndexOf(roleName) > -1);
        }
    }
}
