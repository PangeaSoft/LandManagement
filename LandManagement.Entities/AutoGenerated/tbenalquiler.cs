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
    public partial class tbenalquiler
    {
        #region Primitive Properties
    
        public virtual int ena_id
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_precio_primer_anio
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_precio_segundo_anio
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_precio_tercer_anio
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_precio_cuarto_anio
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_precio_quinto_anio
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_expensas
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_abl
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_aguas
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_luz
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_gas
        {
            get;
            set;
        }
    
        public virtual Nullable<double> ena_telefono
        {
            get;
            set;
        }
    
        public virtual string ena_observaciones
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<tboperaciones> tboperaciones
        {
            get
            {
                if (_tboperaciones == null)
                {
                    var newCollection = new FixupCollection<tboperaciones>();
                    newCollection.CollectionChanged += Fixuptboperaciones;
                    _tboperaciones = newCollection;
                }
                return _tboperaciones;
            }
            set
            {
                if (!ReferenceEquals(_tboperaciones, value))
                {
                    var previousValue = _tboperaciones as FixupCollection<tboperaciones>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixuptboperaciones;
                    }
                    _tboperaciones = value;
                    var newValue = value as FixupCollection<tboperaciones>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixuptboperaciones;
                    }
                }
            }
        }
        private ICollection<tboperaciones> _tboperaciones;

        #endregion
        #region Association Fixup
    
        private void Fixuptboperaciones(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (tboperaciones item in e.NewItems)
                {
                    item.tbenalquiler = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (tboperaciones item in e.OldItems)
                {
                    if (ReferenceEquals(item.tbenalquiler, this))
                    {
                        item.tbenalquiler = null;
                    }
                }
            }
        }

        #endregion
    }
}
