using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Transfer;

namespace Client
{
    public class Communication
    {
        private static Communication instance;
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();

        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        public bool Connect()
        {
            try
            {
                if (socket == null || !socket.Connected)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect("localhost", 9090);
                    stream = new NetworkStream(socket);
                }
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        private void SendRequest(Object obj, Operation operation)
        {
            Request request = new Request();
            request.Object = obj;
            request.Operation = operation;
            formatter.Serialize(stream, request);
        }

        internal bool LoginSailor(Sailor s)
        {
            SendRequest(s, Operation.LoginSailor);
            Response r = (Response)formatter.Deserialize(stream);
            if (r.Signal.Equals(Signal.Ok))
            {
                return true;
            }
            return false;
        }

        internal bool LoginAdministrator(Administrator a)
        {
            SendRequest(a, Operation.LoginAdministrator);
            Response r = (Response)formatter.Deserialize(stream);
            if (r.Signal.Equals(Signal.Ok))
            {
                return true;
            }
            return false;
        }

        internal string AddCompany(Company c)
        {
            SendRequest(c, Operation.AddCompany);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal string AddEngagement(Engagement e)
        {
            SendRequest(e, Operation.AddEngagement);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal string AddSailor(Sailor s)
        {
            SendRequest(s, Operation.AddSailor);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal string DeleteCompany(Company c)
        {
            SendRequest(c, Operation.DeleteCompany);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal List<Company> FindCompanies(Company c)
        {
            SendRequest(c, Operation.FindCompanies);
            Response r = (Response)formatter.Deserialize(stream);
            MessageBox.Show(r.Message);
            return (List<Company>)r.Object;
        }

        internal List<Administrator> FindAdministrators(Administrator a)
        {
            SendRequest(a, Operation.FindAdministrators);
            Response r = (Response)formatter.Deserialize(stream);
            MessageBox.Show(r.Message);
            return (List<Administrator>)r.Object;
        }

        internal List<Engagement> FindEngagements(Engagement e)
        {
            SendRequest(e, Operation.FindEngagements);
            Response r = (Response)formatter.Deserialize(stream);
            MessageBox.Show(r.Message);
            return (List<Engagement>)r.Object;
        }

        internal List<Sailor> FindSailors(Sailor s)
        {
            SendRequest(s, Operation.FindSailors);
            Response r = (Response)formatter.Deserialize(stream);
            MessageBox.Show(r.Message);
            return (List<Sailor>)r.Object;
        }

        internal List<Workplace> FindWorkplaces(Workplace w)
        {
            SendRequest(w, Operation.FindWorkplaces);
            Response r = (Response)formatter.Deserialize(stream);
            MessageBox.Show(r.Message);
            return (List<Workplace>)r.Object;
        }

        internal List<Company> ReturnCompanies()
        {
            SendRequest(null, Operation.ReturnCompanies);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<Company>)r.Object;
        }

        internal List<Country> ReturnCountries()
        {
            SendRequest(null, Operation.ReturnCountries);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<Country>)r.Object;
        }

        internal List<Engagement> ReturnEngagements()
        {
            SendRequest(null, Operation.ReturnEngagements);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<Engagement>)r.Object;
        }

        internal List<SailorRank> ReturnRanks()
        {
            SendRequest(null, Operation.ReturnRanks);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<SailorRank>)r.Object;
        }

        internal List<Sailor> ReturnSailors()
        {
            SendRequest(null, Operation.ReturnSailors);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<Sailor>)r.Object;
        }

        internal List<Workplace> ReturnWorkplaces()
        {
            SendRequest(null, Operation.ReturnWorkplaces);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<Workplace>)r.Object;
        }

        internal string UpdateCompany(Company c)
        {
            SendRequest(c, Operation.UpdateCompany);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal string UpdateSailor(Sailor s)
        {
            SendRequest(s, Operation.UpdateSailor);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal string UpdateWorkplace(Workplace w)
        {
            SendRequest(w, Operation.UpdateWorkplace);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }
    }
}
