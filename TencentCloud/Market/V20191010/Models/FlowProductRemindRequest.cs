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

namespace TencentCloud.Market.V20191010.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowProductRemindRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务商uin
        /// </summary>
        [JsonProperty("ProviderUin")]
        public string ProviderUin{ get; set; }

        /// <summary>
        /// 服务商实例ID
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }

        /// <summary>
        /// 云市场实例ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 实例总流量
        /// </summary>
        [JsonProperty("TotalFlow")]
        public string TotalFlow{ get; set; }

        /// <summary>
        /// 剩余流量
        /// </summary>
        [JsonProperty("LeftFlow")]
        public string LeftFlow{ get; set; }

        /// <summary>
        /// 流量单位
        /// </summary>
        [JsonProperty("FlowUnit")]
        public string FlowUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProviderUin", this.ProviderUin);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "TotalFlow", this.TotalFlow);
            this.SetParamSimple(map, prefix + "LeftFlow", this.LeftFlow);
            this.SetParamSimple(map, prefix + "FlowUnit", this.FlowUnit);
        }
    }
}

