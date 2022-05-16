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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDedicatedClusterOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 专用集群id
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// order关联的专用集群类型数组
        /// </summary>
        [JsonProperty("DedicatedClusterTypes")]
        public DedicatedClusterTypeInfo[] DedicatedClusterTypes{ get; set; }

        /// <summary>
        /// order关联的cos存储信息
        /// </summary>
        [JsonProperty("CosInfo")]
        public CosInfo CosInfo{ get; set; }

        /// <summary>
        /// order关联的cbs存储信息
        /// </summary>
        [JsonProperty("CbsInfo")]
        public CbsInfo CbsInfo{ get; set; }

        /// <summary>
        /// 购买来源，默认为cloudApi
        /// </summary>
        [JsonProperty("PurchaseSource")]
        public string PurchaseSource{ get; set; }

        /// <summary>
        /// 当调用API接口提交订单时，需要提交DedicatedClusterOrderId
        /// </summary>
        [JsonProperty("DedicatedClusterOrderId")]
        public string DedicatedClusterOrderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamArrayObj(map, prefix + "DedicatedClusterTypes.", this.DedicatedClusterTypes);
            this.SetParamObj(map, prefix + "CosInfo.", this.CosInfo);
            this.SetParamObj(map, prefix + "CbsInfo.", this.CbsInfo);
            this.SetParamSimple(map, prefix + "PurchaseSource", this.PurchaseSource);
            this.SetParamSimple(map, prefix + "DedicatedClusterOrderId", this.DedicatedClusterOrderId);
        }
    }
}

