// ++++++++++++++++++++++++++++++++++++++++++++++++++
// This code is generated by a tool and is provided "as is", without warranty of any kind, 
// express or implied, including but not limited to the warranties of merchantability, 
// fitness for a particular purpose and non-infringement.
// In no event shall the authors or copyright holders be liable for any claim, damages or
// other liability, whether in an action of contract, tort or otherwise, arising from,
// out of or in connection with the software or the use or other dealings in the software.
// ++++++++++++++++++++++++++++++++++++++++++++++++++









using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace WebManuals.Controllers
{
	public class LanguagesController:Controller
	{
	   private WebManuals.Models.webmanualsEntities db = new WebManuals.Models.webmanualsEntities();
	   
	     //
        // GET: /languages/

        public ActionResult Index()
        {
            return View(db.languages.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
	}
}
