using ATKSmartApi.Common.Constants;
using ATKSmartApi.Data;
using ATKSmartApi.Entities.Auth;
using ATKSmartApi.Helpers;
using ATKSmartApi.Models.Auth;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATKSmartApi.Services.Auth
{
    public interface IStoreService
    {
        Store PostStore();
        string PostCRUStore(StoreModel model, out StoreModel outStore);
    }

    public class StoreService : IStoreService
    {
        private readonly ATKSmartContext _dbContext;
        private readonly IMapper _mapper;

        public StoreService(IOptions<AppSettings> appSettings, ATKSmartContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Store PostStore()
        {
            return _dbContext.Stores.FirstOrDefault();
        }

        public string PostCRUStore(StoreModel model, out StoreModel outStore)
        {
            string msg = "";
            outStore = null;

            var store = _mapper.Map<Store>(model);
            if (store == null) return MessageForUser.OBJ_MAPPER_INVALID;

            var existsStore = _dbContext.Stores.Any(x => x.StoreId == model.StoreId);
            if (!existsStore) _dbContext.Stores.Add(store);
            else _dbContext.Stores.Update(store);

            try
            {
                int count = _dbContext.SaveChanges();
                if (count <= 0) return MessageForUser.EXECUTE_CRUD_FAILD;
            }
            catch (Exception ex) { msg = ex.Message; }

            outStore = _mapper.Map(store, model);
            return msg;
        }
    }
}
