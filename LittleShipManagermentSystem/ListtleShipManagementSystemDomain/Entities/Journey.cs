using ListtleShipManagementSystemDomain.Abstract;

namespace ListtleShipManagementSystemDomain.Entities
{
    public class Journey : AggregateRoot
    {
        public int StartDockId { get; private set; }
        public Dock StartDock { get; private set; }

        public int EndDockId { get; private set; }
        public Dock EndDock { get; private set; }

        public int ShipId { get; private set; }
        public Ship Ship { get; private set; }

        public int CaptainId { get; private set; }
        public Captain Captain { get; private set; }

        public List<Worker> Workers { get; private set; }

        public string? GuessedJourneyTime { get; private set; }

        public Contract Contract { get; private set; }

        public List<Receipt> Receipts { get; private set; }

        public Journey()
        {
        }

        public Journey(int startDockId, int endDockId, int shipId, int captainId, string guessedJourneyTime)
        {
            StartDockId = startDockId;
            EndDockId = endDockId;
            ShipId = shipId;
            CaptainId = captainId;
            GuessedJourneyTime = guessedJourneyTime;
            Workers = new List<Worker>();
        }

        public void Update(int startDockId, int endDockId, int shipId, int captainId, string guessedJourneyTime)
        {
            StartDockId = startDockId;
            EndDockId = endDockId;
            ShipId = shipId;
            CaptainId = captainId;
            GuessedJourneyTime = guessedJourneyTime;
        }

        public void GoToWayShipAndWorkerAndCaptain()
        {
            foreach (var worker in Workers)
            {
                if (worker.IsOnTheWay)
                {
                    throw new Exception("Worker is Already On the Way");
                }
            }

            if (Ship.IsOnTheWay && !Captain.IsOnTheWay)
            {
                Ship.GoToWay();
                Captain.GoToWay();

                foreach (var worker in Workers)
                {
                    worker.GoToWay();
                }
            }
        }

        public void NotGoToWayShipAndWorkerAndCaptain()
        {
            Ship.NotGoToWay();
            Captain.NotGoToWay();
            foreach (var worker in Workers)
            {
                worker.NotGoToWay();
            }
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void AddWorkerToJourney(Worker worker)
        {
            Workers.Add(worker);
        }

        public void RemoveWorkerFromJourney(int workerId)
        {
            Workers.RemoveAll(w => w.Id == workerId);
        }
    }
}