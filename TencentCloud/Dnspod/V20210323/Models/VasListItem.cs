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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VasListItem : AbstractModel
    {
        
        /// <summary>
        /// 规格总数
        /// </summary>
        [JsonProperty("LimitNumber")]
        public ulong? LimitNumber{ get; set; }

        /// <summary>
        /// 购买时间
        /// </summary>
        [JsonProperty("StartedAt")]
        public string StartedAt{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("EndedAt")]
        public string EndedAt{ get; set; }

        /// <summary>
        /// 资源唯一 ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 自动续费标识
        /// </summary>
        [JsonProperty("AutoRenew")]
        public string AutoRenew{ get; set; }

        /// <summary>
        /// 已绑定的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 绑定类型
        /// </summary>
        [JsonProperty("BindType")]
        public string BindType{ get; set; }

        /// <summary>
        /// 增值服务类型
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 增值服务名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否可续费
        /// </summary>
        [JsonProperty("CanRenew")]
        public bool? CanRenew{ get; set; }

        /// <summary>
        /// 是否只允许付费套餐域名可购买
        /// </summary>
        [JsonProperty("VipDomain")]
        public bool? VipDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LimitNumber", this.LimitNumber);
            this.SetParamSimple(map, prefix + "StartedAt", this.StartedAt);
            this.SetParamSimple(map, prefix + "EndedAt", this.EndedAt);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CanRenew", this.CanRenew);
            this.SetParamSimple(map, prefix + "VipDomain", this.VipDomain);
        }
    }
}

