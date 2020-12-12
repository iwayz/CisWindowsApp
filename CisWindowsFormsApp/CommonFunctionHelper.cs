using Cis.Data;
using Cis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public class CommonFunctionHelper
    {
        public int SearchGridViewFirstTwoColumn(string searchValue, ref DataGridView dataGridView, ref List<int> foundIndices)
        {
            bool isEnd = false;
            int index = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if ((row.Cells[1].Value.ToString().ToUpper().Contains(searchValue.ToUpper()) || row.Cells[2].Value.ToString().ToUpper().Contains(searchValue.ToUpper()))
                    && !foundIndices.Any(f => f == row.Index))
                {
                    foundIndices.Add(row.Index);
                    index = row.Index;
                    break;
                }
                if (row.Index == dataGridView.Rows.Count - 1) isEnd = true;
            }

            if (isEnd)
            {
                foundIndices.Clear();
                CommonMessageHelper.NoMoreResultFound();
            }

            return index;
        }

        public bool ValidateAccess(int permissionCode)
        {
            using (var context = new CisDbContext())
            {
                var userRole = new UnitOfWork<UserRole>(context).Repository.GetAll()
                    .Where(u => u.UserId == Properties.Settings.Default.CurrentUserId);
                var permission = new UnitOfWork<Permission>(context).Repository.GetAll()
                    .Where(p => p.PermissionCode == permissionCode.ToString());
                var permissionRole = new UnitOfWork<PermissionRole>(context).Repository.GetAll().Select(pr => pr);

                var userDetail = userRole.Join(permissionRole, ur => ur.RoleId, pr => pr.RoleId, (ur, pr) => new { ur, pr })
                    .Join(permission, urpr => urpr.pr.PermisionId, p => p.Id, (urpr, p) => new { urpr, p })
                    .Select(res => res).ToList();

                if (userDetail.Count > 0) return true;
            }
            return false;
        }

        public DateTime StandardizeDateTime(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
        }
    }
}
