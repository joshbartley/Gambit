using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gambit.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateUser()
        {

            var userService = new Gambit.Services.User();
            var result = userService.Create(new Models.User()
            {

            });

            Assert.IsTrue(result, "User was not created");
        }


        [TestMethod]
        public void LogActivity()
        {
            var userActivityService = new Gambit.Services.UserActivity();
         
            var userService = new Gambit.Services.User();
            var user = new Models.User()
            {

            };

            var result = userService.Create(user);

            var userActivity = new Gambit.Models.UserActivity();

            userActivityService.RecordUserActivity(userActivity);           

        }


        [TestMethod]
        public void CreateBadgeRule()
        {
            var badgeService = new Gambit.Services.Badge();

            var newBadge = new Gambit.Models.Badge();
            newBadge.Rules.Add(new Gambit.Models.Rule()
                {
                    Condition = Models.Condtion.Exists,
                    ActivityIds = new List<string>(){ "badgeRuleTest"},
                }
            );


        }

    }
}
