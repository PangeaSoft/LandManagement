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
    public partial class tbsystipocliente
    {
        #region Primitive Properties
    
        public virtual int stc_id
        {
            get;
            set;
        }
    
        public virtual string stc_codigo
        {
            get;
            set;
        }
    
        public virtual string stc_descripcion
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual ICollection<tbclienteoperacion> tbclienteoperacion
        {
            get
            {
                if (_tbclienteoperacion == null)
                {
                    var newCollection = new FixupCollection<tbclienteoperacion>();
                    newCollection.CollectionChanged += Fixuptbclienteoperacion;
                    _tbclienteoperacion = newCollection;
                }
                return _tbclienteoperacion;
            }
            set
            {
                if (!ReferenceEquals(_tbclienteoperacion, value))
                {
                    var previousValue = _tbclienteoperacion as FixupCollection<tbclienteoperacion>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixuptbclienteoperacion;
                    }
                    _tbclienteoperacion = value;
                    var newValue = value as FixupCollection<tbclienteoperacion>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixuptbclienteoperacion;
                    }
                }
            }
        }
        private ICollection<tbclienteoperacion> _tbclienteoperacion;

        #endregion

        #region Association Fixup
    
        private void Fixuptbclienteoperacion(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (tbclienteoperacion item in e.NewItems)
                {
                    item.tbsystipocliente = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (tbclienteoperacion item in e.OldItems)
                {
                    if (ReferenceEquals(item.tbsystipocliente, this))
                    {
                        item.tbsystipocliente = null;
                    }
                }
            }
        }

        #endregion

    }
}
