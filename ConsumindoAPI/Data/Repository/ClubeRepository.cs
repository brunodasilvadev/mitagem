using ConsumindoAPI.Entities;
using Dapper;
using System;
using System.Data.Entity;
using System.Linq;

namespace ConsumindoAPI.Data.Repository
{
    public class ClubeRepository 
    {
        protected CartolaContext Db;
        protected DbSet<Clube> DbSet;

        public ClubeRepository(CartolaContext context)
        {
            Db = context;
            DbSet = Db.Set<Clube>();
        }

        public string ObterNomeTimePorIdClube(int id_Clube)
        {
            var cn = Db.Database.Connection;

            var clube = cn.Query<Clube>("SELECT * FROM CLUBE C WHERE C.ID_CLUBE = @id_Clube", new { id_Clube });

            return clube.Select(c => c.nome).FirstOrDefault();
         }
    }
}