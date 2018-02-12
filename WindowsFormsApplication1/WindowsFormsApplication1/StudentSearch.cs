using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;




namespace WindowsFormsApplication1
{
    public struct User
    {

        public string Name;

        public string DisplayName;

        public string ProperName;

        public string EmailAddress;

        public string Description;

        public string Department;

        public string JobTitle;

    }


    class StudentSearch
    {
        public async Task<object> Invoke(dynamic input)
        {

            var names = new List<User>();

            PrincipalContext AD = new PrincipalContext(ContextType.Domain, "labs.neit.edu");

            UserPrincipal u = new UserPrincipal(AD);

            if (input is string)
            {

                u.Name = input;

            }
            else
            {

                u.Name = input.Name;

                u.Description = input.Description;

            }

            PrincipalSearcher search = new PrincipalSearcher(u);



            foreach (UserPrincipal result in search.FindAll())
            {

                if (result != null && result.DisplayName != null)
                {

                    var direc = result.GetUnderlyingObject() as DirectoryEntry;

                    User us = new User
                    {

                        Name = tryProp(direc, "name"),

                        DisplayName = tryProp(direc, "displayName"),

                        ProperName = tryProp(direc, "givenName") + " " + tryProp(direc, "sn"),

                        EmailAddress = tryProp(direc, "mail"),

                        Description = tryProp(direc, "description"),

                        Department = tryProp(direc, "department"),

                        JobTitle = tryProp(direc, "title"),

                    };

                    names.Add(us);

                }

            }



            return names;

        }



        public static string tryProp(DirectoryEntry entry, string propName)
        {

            if (entry.Properties[propName].Value != null)

                return entry.Properties[propName].Value.ToString();

            return "";

        }
    }
}
