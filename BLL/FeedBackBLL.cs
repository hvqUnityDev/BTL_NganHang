using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.DAO;

namespace BLL
{
    public class FeedBackBLL
    {
        public void SendFeedBack()
        {
            FeedBackDAO.Ins.SendFeedBack();
        }
    }
}
