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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要开通服务的资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonProperty("ModuleSet")]
        public string[] ModuleSet{ get; set; }

        /// <summary>
        /// 实例版本
        /// </summary>
        [JsonProperty("ResourceEdition")]
        public string ResourceEdition{ get; set; }

        /// <summary>
        /// 资源节点数
        /// </summary>
        [JsonProperty("ResourceNode")]
        public long? ResourceNode{ get; set; }

        /// <summary>
        /// 自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 带宽扩展包个数(4M)
        /// </summary>
        [JsonProperty("PackageBandwidth")]
        public long? PackageBandwidth{ get; set; }

        /// <summary>
        /// 授权点数扩展包个数(50点)
        /// </summary>
        [JsonProperty("PackageNode")]
        public long? PackageNode{ get; set; }

        /// <summary>
        /// 日志投递
        /// </summary>
        [JsonProperty("LogDelivery")]
        public long? LogDelivery{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "ModuleSet.", this.ModuleSet);
            this.SetParamSimple(map, prefix + "ResourceEdition", this.ResourceEdition);
            this.SetParamSimple(map, prefix + "ResourceNode", this.ResourceNode);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PackageBandwidth", this.PackageBandwidth);
            this.SetParamSimple(map, prefix + "PackageNode", this.PackageNode);
            this.SetParamSimple(map, prefix + "LogDelivery", this.LogDelivery);
        }
    }
}

