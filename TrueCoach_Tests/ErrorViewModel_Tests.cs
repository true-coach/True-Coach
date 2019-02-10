using System;
using System.Collections.Generic;
using System.Text;
using TrueCoach.Models;
using Xunit;

namespace TrueCoach_Tests
{
    public class ErrorViewModel_Tests
    {
        [Fact]  
        public void CanGetRequestID()
        {
            ErrorViewModel errorViewModel = new ErrorViewModel();
            errorViewModel.RequestId = "this";

            Assert.Equal("this", errorViewModel.RequestId);
        }

        [Fact]
        public void CanSetNameOfCourse()
        {
            ErrorViewModel errorViewModel = new ErrorViewModel();
            errorViewModel.RequestId = "this";
            errorViewModel.RequestId = "that";

            Assert.Equal("that", errorViewModel.RequestId);
        }


    }
}
