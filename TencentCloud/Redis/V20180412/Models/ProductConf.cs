/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductConf : AbstractModel
    {
        
        /// <summary>
        /// 产品类型，2-Redis主从版，3-CKV主从版，4-CKV集群版，5-Redis单机版，7-Redis集群版
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 产品名称，Redis主从版，CKV主从版，CKV集群版，Redis单机版，Redis集群版
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 购买时的最小数量
        /// </summary>
        [JsonProperty("MinBuyNum")]
        public long? MinBuyNum{ get; set; }

        /// <summary>
        /// 购买时的最大数量
        /// </summary>
        [JsonProperty("MaxBuyNum")]
        public long? MaxBuyNum{ get; set; }

        /// <summary>
        /// 产品是否售罄
        /// </summary>
        [JsonProperty("Saleout")]
        public bool? Saleout{ get; set; }

        /// <summary>
        /// 产品引擎，腾讯云CKV或者社区版Redis
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// 兼容版本，Redis-2.8，Redis-3.2，Redis-4.0
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 规格总大小，单位G
        /// </summary>
        [JsonProperty("TotalSize")]
        public string[] TotalSize{ get; set; }

        /// <summary>
        /// 每个分片大小，单位G
        /// </summary>
        [JsonProperty("ShardSize")]
        public string[] ShardSize{ get; set; }

        /// <summary>
        /// 副本数量
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public string[] ReplicaNum{ get; set; }

        /// <summary>
        /// 分片数量
        /// </summary>
        [JsonProperty("ShardNum")]
        public string[] ShardNum{ get; set; }

        /// <summary>
        /// 支持的计费模式，1-包年包月，0-按量计费
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 是否支持副本只读
        /// </summary>
        [JsonProperty("EnableRepicaReadOnly")]
        public bool? EnableRepicaReadOnly{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "MinBuyNum", this.MinBuyNum);
            this.SetParamSimple(map, prefix + "MaxBuyNum", this.MaxBuyNum);
            this.SetParamSimple(map, prefix + "Saleout", this.Saleout);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArraySimple(map, prefix + "TotalSize.", this.TotalSize);
            this.SetParamArraySimple(map, prefix + "ShardSize.", this.ShardSize);
            this.SetParamArraySimple(map, prefix + "ReplicaNum.", this.ReplicaNum);
            this.SetParamArraySimple(map, prefix + "ShardNum.", this.ShardNum);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "EnableRepicaReadOnly", this.EnableRepicaReadOnly);
        }
    }
}

