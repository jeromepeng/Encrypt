using JEncrypt.Implemention;
using JEncrypt.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEncrypt
{
    public class EncryptFactory
    {
        private CompositionContainer container;

        [ImportMany(typeof(IJEncrypt))]
        public IEnumerable<IJEncrypt> Encrypts { get; set; }

        public EncryptFactory()
        {
            Compose();
        }

        public IJEncrypt GetEncryptInstance(string encryptName)
        {
            foreach (var e in Encrypts)
            {
                //TO DO
            }
            if (string.IsNullOrEmpty(encryptName))
            {
                return new DefaultJEncrypt();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void Compose()
        {
            var catalog = new AggregateCatalog();
            //Adds all the parts found in the same assembly as the Program class  
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(EncryptFactory).Assembly));

            //Create the CompositionContainer with the parts in the catalog  
            container = new CompositionContainer(catalog);

            //Fill the imports of this object  
            try
            {
                this.container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }
    }
}
