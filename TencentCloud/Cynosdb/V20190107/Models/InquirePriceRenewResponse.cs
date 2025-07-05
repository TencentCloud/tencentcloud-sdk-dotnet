/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquirePriceRenewResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 实例ID列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 对应的询价结果数组
        /// </summary>
        [JsonProperty("Prices")]
        public TradePrice[] Prices{ get; set; }

        /// <summary>
        /// 续费计算节点的总价格
        /// </summary>
        [JsonProperty("InstanceRealTotalPrice")]
        public long? InstanceRealTotalPrice{ get; set; }

        /// <summary>
        /// 续费存储节点的总价格
        /// </summary>
        [JsonProperty("StorageRealTotalPrice")]
        public long? StorageRealTotalPrice{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "Prices.", this.Prices);
            this.SetParamSimple(map, prefix + "InstanceRealTotalPrice", this.InstanceRealTotalPrice);
            this.SetParamSimple(map, prefix + "StorageRealTotalPrice", this.StorageRealTotalPrice);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

