//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace LandManagement.Entities
{
    public partial class tbclienteoperacion
    {
        #region Primitive Properties
    
        public virtual int cli_id
        {
            get { return _cli_id; }
            set
            {
                if (_cli_id != value)
                {
                    if (tbcliente != null && tbcliente.cli_id != value)
                    {
                        tbcliente = null;
                    }
                    _cli_id = value;
                }
            }
        }
        private int _cli_id;
    
        public virtual int ope_id
        {
            get { return _ope_id; }
            set
            {
                if (_ope_id != value)
                {
                    if (tboperaciones != null && tboperaciones.ope_id != value)
                    {
                        tboperaciones = null;
                    }
                    _ope_id = value;
                }
            }
        }
        private int _ope_id;
    
        public virtual int stc_id
        {
            get { return _stc_id; }
            set
            {
                if (_stc_id != value)
                {
                    if (tbsystipocliente != null && tbsystipocliente.stc_id != value)
                    {
                        tbsystipocliente = null;
                    }
                    _stc_id = value;
                }
            }
        }
        private int _stc_id;

        #endregion

        #region Navigation Properties
    
        public virtual tbcliente tbcliente
        {
            get { return _tbcliente; }
            set
            {
                if (!ReferenceEquals(_tbcliente, value))
                {
                    var previousValue = _tbcliente;
                    _tbcliente = value;
                    Fixuptbcliente(previousValue);
                }
            }
        }
        private tbcliente _tbcliente;
    
        public virtual tboperaciones tboperaciones
        {
            get { return _tboperaciones; }
            set
            {
                if (!ReferenceEquals(_tboperaciones, value))
                {
                    var previousValue = _tboperaciones;
                    _tboperaciones = value;
                    Fixuptboperaciones(previousValue);
                }
            }
        }
        private tboperaciones _tboperaciones;
    
        public virtual tbsystipocliente tbsystipocliente
        {
            get { return _tbsystipocliente; }
            set
            {
                if (!ReferenceEquals(_tbsystipocliente, value))
                {
                    var previousValue = _tbsystipocliente;
                    _tbsystipocliente = value;
                    Fixuptbsystipocliente(previousValue);
                }
            }
        }
        private tbsystipocliente _tbsystipocliente;

        #endregion

        #region Association Fixup
    
        private void Fixuptbcliente(tbcliente previousValue)
        {
            if (previousValue != null && previousValue.tbclienteoperacion.Contains(this))
            {
                previousValue.tbclienteoperacion.Remove(this);
            }
    
            if (tbcliente != null)
            {
                if (!tbcliente.tbclienteoperacion.Contains(this))
                {
                    tbcliente.tbclienteoperacion.Add(this);
                }
                if (cli_id != tbcliente.cli_id)
                {
                    cli_id = tbcliente.cli_id;
                }
            }
        }
    
        private void Fixuptboperaciones(tboperaciones previousValue)
        {
            if (previousValue != null && previousValue.tbclienteoperacion.Contains(this))
            {
                previousValue.tbclienteoperacion.Remove(this);
            }
    
            if (tboperaciones != null)
            {
                if (!tboperaciones.tbclienteoperacion.Contains(this))
                {
                    tboperaciones.tbclienteoperacion.Add(this);
                }
                if (ope_id != tboperaciones.ope_id)
                {
                    ope_id = tboperaciones.ope_id;
                }
            }
        }
    
        private void Fixuptbsystipocliente(tbsystipocliente previousValue)
        {
            if (previousValue != null && previousValue.tbclienteoperacion.Contains(this))
            {
                previousValue.tbclienteoperacion.Remove(this);
            }
    
            if (tbsystipocliente != null)
            {
                if (!tbsystipocliente.tbclienteoperacion.Contains(this))
                {
                    tbsystipocliente.tbclienteoperacion.Add(this);
                }
                if (stc_id != tbsystipocliente.stc_id)
                {
                    stc_id = tbsystipocliente.stc_id;
                }
            }
        }

        #endregion

    }
}
