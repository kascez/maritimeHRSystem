using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Transfer;
using Domain;
using System.IO;

namespace Server
{
    public class ClientHandler
    {
        private Socket clientSocket;
        private NetworkStream stream;
        private BinaryFormatter formatter;
        private List<Socket> connectedClients;

        public ClientHandler(Socket clientSocket, List<Socket> connectedClients)
        {
            this.clientSocket = clientSocket;
            this.stream = new NetworkStream(clientSocket);
            formatter = new BinaryFormatter();
            this.connectedClients = connectedClients;

            Thread clientThread = new Thread(HandleRequest);
            clientThread.IsBackground = true;
            clientThread.Start();
        }

        private void HandleRequest()
        {
            bool end = false;
            while (!end)
            {
                try
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response = null;
                    switch (request.Operation)
                    {
                        case Operation.LoginSailor:
                            response = LoginSailor((Sailor)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.LoginAdministrator:
                            response = LoginAdministrator((Administrator)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnRanks:
                            response = ReturnRanks();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnCountries:
                            response = ReturnCountries();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnCompanies:
                            response = ReturnCompanies();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnSailors:
                            response = ReturnSailors();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnWorkplaces:
                            response = ReturnWorkplaces();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnEngagements:
                            response = ReturnEngagements();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.FindCompanies:
                            response = FindCompanies((Company)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.FindSailors:
                            response = FindSailors((Sailor)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.FindAdministrators:
                            response = FindAdministrators((Administrator)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.FindEngagements:
                            response = FindEngagements((Engagement)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.FindWorkplaces:
                            response = FindWorkplaces((Workplace)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.UpdateCompany:
                            response = UpdateCompany((Company)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.UpdateSailor:
                            response = UpdateSailor((Sailor)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.UpdateWorkplace:
                            response = UpdateWorkplace((Workplace)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.DeleteCompany:
                            response = DeleteCompany((Company)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.AddCompany:
                            response = AddCompany((Company)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.AddEngagement:
                            response = AddEngagement((Engagement)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.AddSailor:
                            response = AddSailor((Sailor)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        default:
                            Response r = new Response();
                            r.Signal = Signal.Error;
                            formatter.Serialize(stream, r);
                            break;
                    }
                }
                catch (SocketException)
                {
                    end = true;
                    connectedClients.Remove(clientSocket);
                }
                catch (IOException)
                {
                    end = true;
                    connectedClients.Remove(clientSocket);
                }
            }
        }

        private Response FindAdministrators(Administrator a)
        {
            List<Administrator> ads = new List<Administrator>();
            ads = Controller.Controller.Instance.FindAdministrators(a);
            if (ads is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom pronalazenja administratora sa zadatim kriterijumom", ads);
            }
            if (ads.Count == 0)
            {
                return CreateResponse(Signal.Ok, "Ne postoje administratori sa zadatim kriterijumima", ads);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje administratora po kriterijumu", ads);
        }

        private Response AddSailor(Sailor s)
        {
            if (Controller.Controller.Instance.AddSailor(s))
            {
                return CreateResponse(Signal.Ok, "Uspjesno ste unijeli pomorca!", s);
            }
            return CreateResponse(Signal.Error, "Greska prilikom unosa pomorca!", s);
        }

        private Response AddEngagement(Engagement e)
        {
            if (Controller.Controller.Instance.AddEngagement(e))
            {
                return CreateResponse(Signal.Ok, "Uspjesno ste unijeli angazovanje!", e);
            }
            return CreateResponse(Signal.Error, "Greska prilikom unosa angazovanja!", e);
        }

        private Response AddCompany(Company c)
        {
            if (Controller.Controller.Instance.AddCompany(c))
            {
                return CreateResponse(Signal.Ok, "Uspjesno ste unijeli kompaniju!", c);
            }
            return CreateResponse(Signal.Error, "Greska prilikom unosa kompanije!", c);
        }

        private Response DeleteCompany(Company c)
        {
            if (Controller.Controller.Instance.DeleteCompany(c))
            {
                return CreateResponse(Signal.Ok, "Uspjesno ste obrisali kompaniju!", c);
            }
            return CreateResponse(Signal.Error, "Greska prilikom brisanja kompanije!", c);
        }

        private Response UpdateWorkplace(Workplace w)
        {
            if (Controller.Controller.Instance.UpdateWorkplace(w))
            {
                return CreateResponse(Signal.Ok, "Uspjesno azuriranje radnog mjesta!", w);
            }
            return CreateResponse(Signal.Error, "Greska prilikom azuriranja radnog mjesta!", w);
        }

        private Response UpdateSailor(Sailor s)
        {
            if (Controller.Controller.Instance.UpdateSailor(s))
            {
                return CreateResponse(Signal.Ok, "Uspjesno azuriranje pomorca!", s);
            }
            return CreateResponse(Signal.Error, "Greska prilikom azuriranja !", s);
        }

        private Response UpdateCompany(Company c)
        {
            if (Controller.Controller.Instance.UpdateCompany(c))
            {
                return CreateResponse(Signal.Ok, "Uspjesno azuriranje kompanije!", c);
            }
            return CreateResponse(Signal.Error, "Greska prilikom azuriranja kompanije!", c);
        }

        private Response FindWorkplaces(Workplace w)
        {
            List<Workplace> ws = new List<Workplace>();
            ws = Controller.Controller.Instance.FindWorkplaces(w);
            if (ws is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom pronalazenja radnih mjesta sa zadatim kriterijumom", ws);
            }
            if (ws.Count == 0)
            {
                return CreateResponse(Signal.Ok, "Ne postoje kompanije sa zadatim kriterijumima", ws);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje radnih mjesta po kriterijumu", ws);
        }

        private Response FindEngagements(Engagement e)
        {
            List<Engagement> es = new List<Engagement>();
            es = Controller.Controller.Instance.FindEngagements(e);
            if (es is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom pronalazenja zaposlenja sa zadatim kriterijumom", es);
            }
            if (es.Count == 0)
            {
                return CreateResponse(Signal.Ok, "Ne postoje zaposlenja sa zadatim kriterijumima", es);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje zaposlenja po kriterijumu", es);
        }

        private Response FindSailors(Sailor s)
        {
            List<Sailor> ss = new List<Sailor>();
            ss = Controller.Controller.Instance.FindSailors(s);
            if (ss is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom pronalazenja pomoraca sa zadatim kriterijumom", ss);
            }
            if (ss.Count == 0)
            {
                return CreateResponse(Signal.Ok, "Ne postoje pomorci sa zadatim kriterijumima", ss);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje pomoraca po kriterijumu", ss);
        }

        private Response FindCompanies(Company c)
        {
            List<Company> cs = new List<Company>();
            cs = Controller.Controller.Instance.FindCompanies(c);
            if (cs is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom pronalazenja kompanija sa zadatim kriterijumom", cs);
            }
            if (cs.Count == 0)
            {
                return CreateResponse(Signal.Ok, "Ne postoje kompanije sa zadatim kriterijumima", cs);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje kompanija po kriterijumu", cs);
        }

        private Response ReturnEngagements()
        {
            List<Engagement> es = new List<Engagement>();
            es = Controller.Controller.Instance.ReturnEngagements();
            if (es is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom ucitavanja zaposlenja!", es);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje zaposlenja!", es);
        }

        private Response ReturnWorkplaces()
        {
            List<Workplace> ws = new List<Workplace>();
            ws = Controller.Controller.Instance.ReturnWorkplaces();
            if (ws is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom ucitavanja zaposlenja!", ws);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje zaposlenja!", ws);
        }

        private Response ReturnSailors()
        {
            List<Sailor> ss = new List<Sailor>();
            ss = Controller.Controller.Instance.ReturnSailors();
            if (ss is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom ucitavanja pomoraca!", ss);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje pomoraca!", ss);
        }

        private Response ReturnCompanies()
        {
            List<Company> cs = new List<Company>();
            cs = Controller.Controller.Instance.ReturnCompanies();
            if (cs is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom ucitavanja kompanija!", cs);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje kompanija!", cs);
        }

        private Response ReturnCountries()
        {
            List<Country> cs = new List<Country>();
            cs = Controller.Controller.Instance.ReturnCountries();
            if (cs is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom ucitavanja drzava!", cs);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje drzava!", cs);
        }

        private Response ReturnRanks()
        {
            List<SailorRank> ss = new List<SailorRank>();
            ss = Controller.Controller.Instance.ReturnRanks();
            if (ss is null)
            {
                return CreateResponse(Signal.Error, "Greska prilikom ucitavanja cinova!", ss);
            }
            return CreateResponse(Signal.Ok, "Uspjesno pronalazenje cinova!", ss);
        }

        private Response LoginAdministrator(Administrator a)
        {
            if (Controller.Controller.Instance.LoginAdministrator(a))
            {
                return CreateResponse(Signal.Ok, "Uspjesno ste se prijavili. (Administrator)", a);
            }
            return CreateResponse(Signal.Error, "Greska prilikom prijavljivanja!", a);
        }

        private Response LoginSailor(Sailor s)
        {
            if (Controller.Controller.Instance.LoginSailor(s))
            {
                return CreateResponse(Signal.Ok, "Upsjesno ste se prijavili.", s);
            }
            return CreateResponse(Signal.Error, "Greska prilikom prijavljivanja!", s);
        }

        private Response CreateResponse(Signal signal, string message, Object o)
        {
            Response r = new Response();
            r.Signal = signal;
            r.Message = message;
            r.Object = o;
            return r;
        }
    }

}
