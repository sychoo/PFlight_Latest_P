machine Drone
{
    var fc: FlightController;
    start state Init 
    {
        entry 
        {
            fc = new FlightController(this);
        }
    }
}

machine FailureDrone
{
    var fc: FlightController;
    var fi: FailureInjector;
    start state Init 
    {
        entry 
        {
            fc = new FlightController(this);
            fi = new FailureInjector(fc);
            send fi, eLinkInitialized;
        }
    }
}

machine FailureDroneGPT
{
    var fc: FlightController;
    var fi: FailureInjectorGPT;
    start state Init 
    {
        entry 
        {
            fc = new FlightController(this);
            fi = new FailureInjectorGPT(fc);
            send fi, eLinkInitialized;
        }
    }
}