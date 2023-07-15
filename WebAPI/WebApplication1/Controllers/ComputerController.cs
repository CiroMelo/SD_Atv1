using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ComputerController : ApiController
    {

        public HttpResponseMessage Get()
        {
            string query = @"
                    SELECT id, placa_mae, processador, memoria_ram, armazenamento, gpu, fonte 
                    FROM dbo.Computer    
                    ";

            DataTable table = new DataTable();
            using(var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ComputerAppDB"].ConnectionString))
            using(var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public string Post(Computer pc)
        {
            try
            {
                string query = @"
                        INSERT INTO dbo.Computer VALUES 
                        (
                        '" + pc.placa_mae + @"'
                        ,'" + pc.processador + @"'
                        ,'" + pc.memoria_ram + @"'
                        ,'" + pc.armazenamento + @"'
                        ,'" + pc.gpu + @"'
                        ,'" + pc.fonte + @"'
                        )
                        ";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ComputerAppDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Entrada adicionada com sucesso!!";
            }
            catch (Exception)
            {
                return "Falha ao adicionar entrada!";
            }
        }

        public string Put(Computer pc)
        {
            try
            {
                string query = @"
                        UPDATE dbo.Computer SET 
                        placa_mae='" + pc.placa_mae + @"'
                        ,processador='" + pc.processador + @"'
                        ,memoria_ram='" + pc.memoria_ram + @"'
                        ,armazenamento='" + pc.armazenamento + @"'
                        ,gpu='" + pc.gpu + @"'
                        ,fonte='" + pc.fonte + @"'
                        WHERE id=" + pc.id + @"
                        ";
                        

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ComputerAppDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Entrada alterada com sucesso!!";
            }
            catch (Exception)
            {
                return "Falha ao alterar entrada!";
            }
        }

        public string Delete(int id)
        {
            try
            {
                string query = @"
                        DELETE FROM dbo.Computer
                        WHERE id=" + id + @"
                        ";


                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ComputerAppDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Entrada deletada com sucesso!!";
            }
            catch (Exception)
            {
                return "Falha ao deletar entrada!";
            }
        }
    }
}
