using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Person : IAsset
    {

        private List<IAsset> assets = new List<IAsset>();
        //private List<Asset> assets = new ArrayList<>();

        public void accept(IVisitor visitor)
        {
            //for (IAsset asset : IAsset)
            //{
            //    asset.accept(visitor);
            //}

            foreach (var item in assets)
            {
                item.accept(visitor);
            }


        }

        public List<IAsset> getAssets()
        {
            return assets;
        }

    }
}
