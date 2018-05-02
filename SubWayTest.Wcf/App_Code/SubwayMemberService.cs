﻿using SubWayTest.Domain;
using SubWayTest.Wcf;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;

namespace SubWayTest.Wcf
{
    public class SubwayMemberService : ISubwayMemberService
    {
        private SubwayContext db = new SubwayContext();

        public void Create(SubwayMember subwayMember)
        {
            try
            {
                db.SubwayMember.Add(subwayMember);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public void Delete(Guid id)
        {
            SubwayMember subwayMember = db.SubwayMember.Find(id);
            db.SubwayMember.Remove(subwayMember);
            db.SaveChanges();
        }

        public void Index()
        {
        }

        public void Update(SubwayMember subwayMember)
        {
            db.Entry(subwayMember).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}