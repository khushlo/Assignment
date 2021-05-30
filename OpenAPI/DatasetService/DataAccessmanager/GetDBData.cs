using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatasetService
{
    public class GetDBData
    {
        /// <summary>
        /// Get All Cheese data
        /// </summary>
        /// <returns></returns>
        public WebResponse GetAllData()
        {
            try
            {
                using (var db = new DBManager().OrmLite.Open())
                {
                    var res = db.Select<Cheese>();
                    return new WebResponse(res);
                }
            }
            catch (Exception)
            {
                //TODO: Handle Error Logs
            }
            return new WebResponse();
        }

        /// <summary>
        /// Get data by primary key
        /// </summary>
        /// <param name="id">ID of Cheese</param>
        /// <returns></returns>
        public WebResponse GetDataById(int id)
        {
            try
            {
                using (var db = new DBManager().OrmLite.Open())
                {
                    var res = db.SelectByIds<Cheese>(new List<int>(){ id });
                    return new WebResponse(res);
                }
            }
            catch (Exception)
            {
                //TODO: Handle Error Logs
            }
            return new WebResponse();
        }

        /// <summary>
        /// Insert Update Cheese Object 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int InsertUpdateData(Cheese data)
        {
            try
            {
                using (var db = new DBManager().OrmLite.Open())
                {
                    if (data.CheeseId > 0)
                    {
                        db.Update<Cheese>(data);
                    }
                    else
                    {
                        db.Insert<Cheese>(data);
                    }
                    return 1;
                }
            }
            catch (Exception)
            {
                //TODO: Handle Error Logs
            }
            return 0;
        }

        /// <summary>
        /// Delete Cheese By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteById(int id)
        {
            try
            {
                using (var db = new DBManager().OrmLite.Open())
                {
                    db.DeleteById<Cheese>(id);
                    return 1;
                }
            }
            catch (Exception)
            {
                //TODO: Handle Error Logs
            }
            return 0;
        }

        /// <summary>
        /// Delete All Cheese
        /// </summary>
        /// <returns></returns>
        public int DeleteAll()
        {
            try
            {
                using (var db = new DBManager().OrmLite.Open())
                {
                    db.DeleteAll<Cheese>();
                    return 1;
                }
            }
            catch (Exception)
            {
                //TODO: Handle Error Logs
            }
            return 0;
        }
    }
}
