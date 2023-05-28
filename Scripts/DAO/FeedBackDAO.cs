using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Scripts.Interface;

namespace WindowsFormsApp2.Scripts.DAO
{
    public class FeedBackDAO : IFeedBack
    {
        private static FeedBackDAO ins;
        public static FeedBackDAO Ins
        {
            get
            {
                if (ins == null)
                    ins = new FeedBackDAO();
                return ins;
            }

            private set => ins = value;
        }

        public void SendFeedBack()
        {
            MessageBox.Show("Chúng tôi sẽ phản hồi lại bạn sớm nhất!");
        }

    }
}
