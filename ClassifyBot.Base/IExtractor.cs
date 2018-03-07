﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassifyBot
{
    public interface IExtractor<TRecord, TFeature> where TFeature : ICloneable, IComparable, IComparable<TFeature>, IConvertible, IEquatable<TFeature> where TRecord : Record<TFeature> 
    {
        StageResult Extract(int? recordBatchSize = null, int? recordLimit = null, Dictionary<string, string> options = null);
    }
}
