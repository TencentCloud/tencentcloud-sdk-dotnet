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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyOrderStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 要更新成的状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 大订单ID，可以在本地专用集群的基础信息页获取大订单ID
        /// </summary>
        [JsonProperty("DedicatedClusterOrderId")]
        public string DedicatedClusterOrderId{ get; set; }

        /// <summary>
        /// 小订单ID，进入大订单的详情页，可以看到小订单ID
        /// </summary>
        [JsonProperty("SubOrderIds")]
        public string[] SubOrderIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DedicatedClusterOrderId", this.DedicatedClusterOrderId);
            this.SetParamArraySimple(map, prefix + "SubOrderIds.", this.SubOrderIds);
        }
    }
}

