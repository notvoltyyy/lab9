using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Bus
{
    static protected string commonCode = "default";

    public int busId;
    public int routeId;
    static int composterCount = 1;
    public List<BusComposter> composterList = new List<BusComposter>();

    public Bus()
    {
        //Composter composter = new Composter();
        busId = 42114;
        routeId = 144;
        //foreach (Composter composter in composterList)
        //{
        //    composter.
        //}
    }

    public Bus(int composterNum, int busID, int routeID)
    {
        this.busId = busID;
        this.routeId = routeID;
        composterCount = composterNum;
    }

    public void Print()
    {
        Console.WriteLine(ToString());
        foreach (BusComposter composter in composterList)
        {
            Console.WriteLine("\t" + composter.ToString());
            foreach (BusTicket ticket in composter.tickets)
            {
                Console.WriteLine("\t\t" + ticket.ToString());
            }
        }
    }

    public override string ToString()
    {
        return "Bus id: " + busId + ", route id: " + routeId + ", composter count: " + composterCount;
    }
}