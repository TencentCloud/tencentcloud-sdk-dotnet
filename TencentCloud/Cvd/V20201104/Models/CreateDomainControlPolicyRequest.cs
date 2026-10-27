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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDomainControlPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>策略名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>策略类型，取值范围[&quot;WHITE&quot;,&quot;BLACK&quot;]，WHITE - 白名单策略；BLACK - 黑名单策略；默认 值为BLACK</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>域名控制规则详情</p>
        /// </summary>
        [JsonProperty("DetailSet")]
        public DomainControlDetail[] DetailSet{ get; set; }

        /// <summary>
        /// <p>IP控制规则详情</p>
        /// </summary>
        [JsonProperty("IpDetailSet")]
        public IpControlDetail[] IpDetailSet{ get; set; }

        /// <summary>
        /// <p>作用到的实例列表</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "DetailSet.", this.DetailSet);
            this.SetParamArrayObj(map, prefix + "IpDetailSet.", this.IpDetailSet);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
        }
    }
}

