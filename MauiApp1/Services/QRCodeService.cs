using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public class QRCodeService
    {
        public delegate Task QRCompleted(string codeContent);

        public event QRCompleted QRCompletedEvent;


        public delegate Task QRShow();

        public event QRShow QRShowEvent;

        public delegate Task QRHide();

        public event QRHide QRHideEvent;

        public async Task Scan()
        {
            if (QRShowEvent != null) await QRShowEvent();
        }

        public async Task Stop()
        {
            if (QRHideEvent != null) await QRHideEvent();
        }

        public void SetCodeContent(string content)
        {
            if(QRCompletedEvent != null) QRCompletedEvent(content);
        }
    }
}
