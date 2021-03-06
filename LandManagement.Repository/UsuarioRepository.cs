﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LandManagement.Interface;
using LandManagement.Entities;
using System.Data;

namespace LandManagement.Repository
{
    public class UsuarioRepository : IUsuario<tbusuario>
    {
        private landmanagementbdEntities _Contexto;
        public landmanagementbdEntities Contexto
        {
            set { }
            get
            {
                if (_Contexto == null)
                {
                    _Contexto = new landmanagementbdEntities();
                    _Contexto.ContextOptions.LazyLoadingEnabled = false;
                    _Contexto.ContextOptions.ProxyCreationEnabled = false;
                }
                return _Contexto;
            }
        }

        public void Create(tbusuario entity)
        {
            try
            {
                Contexto = new landmanagementbdEntities();
                Contexto.CreateObjectSet<tbusuario>().AddObject(entity);
                Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateNew(tbusuario entity)
        {
            try
            {
                EntityKey key =
                    Contexto.CreateEntityKey(Contexto.CreateObjectSet<tbusuario>().EntitySet.Name, entity);

                tbusuario entityAux = (tbusuario)Contexto.GetObjectByKey(key);

                Contexto.CreateObjectSet<tbusuario>().ApplyCurrentValues(entity);
                Contexto.ObjectStateManager.GetObjectStateEntry(entityAux).ChangeState(EntityState.Modified);
                Contexto.ObjectStateManager.ChangeObjectState(entityAux, System.Data.EntityState.Modified);

                Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(tbusuario entity)
        {
            try
            {
                //Verifico si ya existe la entidad en el contexto
                EntityKey key =
                    Contexto.CreateEntityKey(Contexto.CreateObjectSet<tbusuario>().EntitySet.Name, entity);

                tbusuario entityAux = null;
                entityAux = (tbusuario)Contexto.GetObjectByKey(key);

                // Ya existe la entidad en el contexto, aplico los cambios
                Contexto.CreateObjectSet<tbusuario>().ApplyCurrentValues(entity);
                Contexto.ObjectStateManager.GetObjectStateEntry(entityAux).ChangeState(EntityState.Modified);
                Contexto.ObjectStateManager.ChangeObjectState(entityAux, System.Data.EntityState.Modified);
                // DBK 27/03/2012
                //Contexto.SaveChanges();

                //Actualizo relaciones con tbmenu
                var usuario = Contexto.tbusuario.Include("tbmenu").Single(u => u.usu_id == entity.usu_id);
                var menues = (from m in Contexto.tbmenu.ToList()
                              from mu in entity.tbmenu
                              where m.men_id == mu.men_id
                              select m).ToList();

                usuario.tbmenu.Clear();
                foreach (var m in menues)
                    usuario.tbmenu.Add(m);

                Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(tbusuario entity)
        {
            try
            {
                tbusuario m = (tbusuario)this.GetElement(entity);
                Contexto.tbusuario.DeleteObject(m);
                Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetElement(tbusuario entity)
        {
            try
            {
                //TENIA UN ERROR CUANDO SE CARGABAN LAS GRILLAS DE PERMISOS
                //EL DE ABAJO FUNCIONA PERO HACE EL INCLUDE DE LOS MENU [REVISAR]
                //tbusuario salida = (from u in Contexto.tbusuario
                //                    where u.usu_id == entity.usu_id
                //                    select u).FirstOrDefault();
                
                //MEJORA MENU
                tbusuario salida = (from u in Contexto.tbusuario.Include("tbmenu")
                                    where u.usu_id == entity.usu_id
                                    select u).FirstOrDefault();

                return salida;
            }
            catch (ObjectNotFoundException)
            {
                throw new ExcepcionRepository();
            }
        }

        public object GetList()
        {
            return Contexto.CreateObjectSet<tbusuario>().ToList();
        }

        public object GetList(Func<tbusuario, bool> funcion)
        {
            return Contexto.tbusuario.Where(funcion).ToList();
        }
    }
}
