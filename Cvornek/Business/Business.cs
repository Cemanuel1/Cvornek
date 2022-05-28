using Cvornek.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cvornek.Business
{
    public class Business : IBusiness
    {
        public BusinessData DeleteAccount(int ID)
        {
            BusinessData BD = new BusinessData();
            try
            {
                using(cvformEntities db = new cvformEntities())
                {
                    Account ac = db.Account.Find(ID);
                    db.Account.Remove(ac);
                    db.SaveChanges();
                    BD.ErrorCode = "0";
                    BD.ErrorMassage = "Success";
                }
            }
            catch (Exception ex)
            {

                BD.ErrorCode = "100";
                BD.ErrorMassage = ex.Message;
            }
            return BD;
        }

        public BusinessData DeleteFormTb(int ID)
        {
            BusinessData BD = new BusinessData();
            try
            {
                using (cvformEntities db = new cvformEntities())
                {
                    FormTb ft = db.FormTb.Find(ID);
                    db.FormTb.Remove(ft);
                    db.SaveChanges();
                    BD.ErrorCode = "0";
                    BD.ErrorMassage = "Success";
                }
            }
            catch (Exception ex)
            {

                BD.ErrorCode = "100";
                BD.ErrorMassage = ex.Message;
            }
            return BD;
        }

        public BusinessData GetAccount()
        {
            BusinessData BD = new BusinessData();
            try
            {
                using (cvformEntities db = new cvformEntities())
                {
                    BD.AccountList = db.Account.ToList();                    
                    BD.ErrorCode = "0";
                    BD.ErrorMassage = "Success";
                }
            }
            catch (Exception ex)
            {

                BD.ErrorCode = "101";
                BD.ErrorMassage = ex.Message;
            }
            return BD;
        }

        public BusinessData GetFormTb()
        {
            BusinessData BD = new BusinessData();
            try
            {
                using (cvformEntities db = new cvformEntities())
                {
                    BD.FormTbList = db.FormTb.ToList();
                    BD.ErrorCode = "0";
                    BD.ErrorMassage = "Success";
                }
            }
            catch (Exception ex)
            {

                BD.ErrorCode = "101";
                BD.ErrorMassage = ex.Message;
            }
            return BD;
        }

        public BusinessData InsertAccount(Account account)
        {
            BusinessData BD = new BusinessData();
            try
            {
                using (cvformEntities db = new cvformEntities())
                {
                    db.Account.Add(account);
                    db.SaveChanges();
                    BD.ErrorCode = "0";
                    BD.ErrorMassage = "Success";
                }

            }
            catch (Exception ex)
            {

                BD.ErrorCode = "103";
                BD.ErrorMassage = ex.Message;
            }
            return BD;
        }

        public BusinessData InsertFormTb(FormTb formTb)
        {
            BusinessData BD = new BusinessData();
            try
            {
                using (cvformEntities db = new cvformEntities())
                {
                    db.FormTb.Add(formTb);
                    db.SaveChanges();
                    BD.ErrorCode = "0";
                    BD.ErrorMassage = "Success";
                }

            }
            catch (Exception ex)
            {

                BD.ErrorCode = "103";
                BD.ErrorMassage = ex.Message;
            }
            return BD;
        }

        public BusinessData UpdateAccount(Account account)
        {
            BusinessData BD = new BusinessData();
            try
            {
                using (cvformEntities db = new cvformEntities())
                {
                    var old = db.Account.Find(account.Id);
                    db.Entry(old).State = EntityState.Detached;
                    db.Entry(account).State = EntityState.Modified;
                    db.Account.Add(account);
                    db.SaveChanges();
                    BD.ErrorCode = "0";
                    BD.ErrorMassage = "Success";
                }

            }
            catch (Exception ex)
            {

                BD.ErrorCode = "104";
                BD.ErrorMassage = ex.Message;
            }
            return BD;
        }

        public BusinessData UpdateFormTb(FormTb formTb)
        {
            BusinessData BD = new BusinessData();
            try
            {
                using (cvformEntities db = new cvformEntities())
                {
                    var old = db.Account.Find(formTb.Id);
                    db.Entry(old).State = EntityState.Detached;
                    db.Entry(formTb).State = EntityState.Modified;
                    db.FormTb.Add(formTb);
                    db.SaveChanges();
                    BD.ErrorCode = "0";
                    BD.ErrorMassage = "Success";
                }

            }
            catch (Exception ex)
            {

                BD.ErrorCode = "104";
                BD.ErrorMassage = ex.Message;
            }
            return BD;
        }
    }
}