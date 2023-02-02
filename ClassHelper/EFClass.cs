using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndrKarmStore.DB;

namespace AndrKarmStore.ClassHelper
{
    class EFClass
    {
        public static DB.ClothingStoreEntities Context { get; } = new DB.ClothingStoreEntities();
    }
}
