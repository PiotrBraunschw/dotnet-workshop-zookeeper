using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zookeeper.Controllers;
using Zookeeper.Mail;

namespace Zookeeper.Tests
{  
    internal class NewsletterControllerTest
    {
        private Mock<IEmailService> _emaiServiceMock;
        private NewsletterController _newsletterController;


        [SetUp]
        public void SetUp()
        {
            _emaiServiceMock = new Mock<IEmailService>();
            _newsletterController = new NewsletterController(_emaiServiceMock.Object);
        }

        [Test]
        public void SubscribeSendEmails()
        {
            _newsletterController.Subscribe("Test@test.com");
            _emaiServiceMock.Verify(x=> x.SendMail("Test@test.com"));

        }


    }
}
