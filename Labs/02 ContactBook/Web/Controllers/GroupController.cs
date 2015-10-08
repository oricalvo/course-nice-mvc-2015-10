using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddressBook.BL;

namespace AddressBook.Web.Controllers
{
    [Authorize]
    public class GroupController : Controller
    {
        public ActionResult Index(int? id)
        {
            BLM blm = BLM.Load();

            Group group = (Group)blm.GetItemByID(id);

            return View(group);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult ConfirmDelete(int id)
        {
            BLM blm = BLM.Load();

            BookItem item = blm.GetItemByID(id);

            return View(item);

        }

        [Authorize(Roles="Admin")]
        public ActionResult Delete(int id)
        {
            BLM blm = BLM.Load();

            BookItem item = blm.GetItemByID(id);
            Group parent = item.Parent;

            blm.DeleteItem(item);

            return RedirectToAction("Index", new { id = parent.ID });
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult New(int parentId)
        {
            BLM blm = BLM.Load();

            Group parent = (Group)blm.GetItemByID(parentId);
            Group newGroup = new Group() { Parent = parent };

            return View(newGroup);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult New(int parentId, Group group)
        {
            BLM blm = BLM.Load();

            if (!ModelState.IsValid)
            {
                Group parent = (Group)blm.GetItemByID(parentId);
                group.Parent = parent;

                return View(group);
            }

            blm.AddGroup(parentId, group);

            return RedirectToAction("Index", new { id = parentId });
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            BLM blm = BLM.Load();

            Group group = (Group)blm.GetItemByID(id);

            return View(group);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id, bool? dummy)
        {
            BLM blm = BLM.Load();

            Group group = (Group)blm.GetItemByID(id);

            if(!TryUpdateModel(group))
            {
                return View(group);
            }

            blm.Save();

            return RedirectToAction("Index", new { id = group.Parent.ID });
        }
    }
}
