using BLL.Interfaces;
using DAL;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Impl
{
    public class ClientService : IClientService
    {
        public async Task<Response> Insert(ClientDTO client)
        {
            using (MarketContext context = new MarketContext())
            {
                Response response = new Response();

                if (string.IsNullOrWhiteSpace(client.Name))
                {
                    response.Errors.Add("O cliente deve ser informado");
                }
                else if (client.Name.Length < 2 && client.Name.Length > 20)
                {
                    response.Errors.Add("O cliente deve conter entre 2 e 50 caracteres =3");
                    response.Success = false;
                    return response;
                }

                if (response.Errors.Count != 0)
                {
                    response.Success = false;
                    return response;
                }

                try
                {
                    context.Clients.Add(client);
                    await context.SaveChangesAsync();
                    response.Success = true;
                    return response;
                }
                catch (Exception ex)
                {
                    response.Errors.Add("Erro no banco contate o adm");
                    response.Success = false;
                    File.WriteAllText("Log.txt", ex.Message);
                    return response;
                }
            }
        }

        public async Task<List<ClientDTO>> GetClient()
        {
            using (MarketContext context = new MarketContext())
            {
                return await context.Clients.ToListAsync();
            }
        }

        public Task<List<ClientDTO>> GetClient(int page, int size)
        {
            throw new NotImplementedException();
        }
    }
}
