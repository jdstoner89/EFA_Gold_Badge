using System;
using ChallengeFour_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFour_UnitTests
{
    [TestClass]
    public class OutingsRepoTests
    {
        private OutingsRepository _repo;
        private Outings _outing;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new OutingsRepository();
            _outing = new Outings("Dinner", 15, "January sixth", 100.00, 1500.00);
            _repo.AddOutingToList(_outing);
        }
        [TestMethod]
        public void AddOutingToList_ReturnNotNull()
        {
            Outings outing = new Outings();
            outing.EventType = "Golf";
            OutingsRepository repository = new OutingsRepository();

            repository.AddOutingToList(outing);
            Outings outingFromDirectory = repository.GetOutingByEventType("Golf");

            Assert.IsNotNull(outingFromDirectory);
        }
    }
}
