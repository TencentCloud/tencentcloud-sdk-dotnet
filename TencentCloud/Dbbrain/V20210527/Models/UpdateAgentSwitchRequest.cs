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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAgentSwitchRequest : AbstractModel
    {
        
        /// <summary>
        /// Agent标识。可通过 [DescribeDiagDBInstances](https://cloud.tencent.com/document/api/1130/57798) 接口获取。
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// 停止或重连Agent，支持值包括："on" - 重连Agent， "off" - 停止Agent。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 服务产品类型，仅支持 "dbbrain-mysql" - 自建MySQL。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

