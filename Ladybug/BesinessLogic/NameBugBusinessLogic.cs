using Ladybug.Models.NameBug;
using LinqKit;
using System;
using System.Linq.Expressions;

namespace Ladybug.BesinessLogic
{
    public class NameBugBusinessLogic
    {
        public Expression<Func<NameBugModel, bool>> MapFillterNameBug(NameBugRequest fillter)
        {
            Expression<Func<NameBugModel, bool>> Predicate = PredicateBuilder.New<NameBugModel>(true);

            if (fillter.namebug != null)
            {
                Predicate = Predicate.And(a => a.namebug.Contains(fillter.namebug));
            }
            if (fillter.severity_id != 0 && fillter.severity_id != null)
            {
                Predicate = Predicate.And(a => a.severity_id == fillter.severity_id);
            }
            if (fillter.status_id != 0 && fillter.status_id != null)
            {
                Predicate = Predicate.And(a => a.status_id == fillter.status_id);
            }
            if (fillter.start_date != null)
            {
                Predicate = Predicate.And(a => a.start_date == fillter.start_date);
            }
            if (fillter.findername != null)
            {
                Predicate = Predicate.And(a => a.findername.Contains(fillter.findername));
            }      
            if (!fillter.is_delete)
            {
                Predicate = Predicate.And(a => a.is_delete == fillter.is_delete);
            }
            return Predicate;
        }

        public NameBugModel MapCreateNameBug(NameBugRequest nameBugRequest)
        {
            NameBugModel nameBugModel = new NameBugModel();
            try
            {
                if (nameBugRequest.namebug != null)
                {
                    nameBugModel.namebug = nameBugRequest.namebug;
                }
                if (nameBugRequest.severity_id != 0 && nameBugRequest.severity_id != null)
                {
                    nameBugModel.severity_id = (int)nameBugRequest.severity_id;
                }
                if (nameBugRequest.status_id != 0 && nameBugRequest.status_id != null)
                {
                    nameBugModel.status_id = (int)nameBugRequest.status_id;
                }
                nameBugModel.start_date = DateTime.Now;
                if (nameBugRequest.findername != null)
                {
                    nameBugModel.findername = nameBugRequest.findername;
                }
                nameBugModel.is_delete = false;
            }
            catch
            {
                Console.WriteLine();
            }
            return nameBugModel;
        }

        public NameBugModel MapUpdateNameBug(NameBugModel NameBug, NameBugRequest NameBugRequest)
        {
            if (NameBugRequest.namebug != null)
            {
                NameBug.namebug = NameBugRequest.namebug;
            }
            if (NameBugRequest.severity_id != 0 && NameBugRequest.severity_id != null)
            {
                NameBug.severity_id = (int)NameBugRequest.severity_id;
            }
            if (NameBugRequest.findername != null)
            {
                NameBug.findername = NameBugRequest.findername;
            }
            if (NameBugRequest.status_id != 0 && NameBugRequest.status_id != null)
            {
                NameBug.status_id = (int)NameBugRequest.status_id; 
            }
            NameBug.start_date = DateTime.Now;
            return NameBug;
        }
    }
}
