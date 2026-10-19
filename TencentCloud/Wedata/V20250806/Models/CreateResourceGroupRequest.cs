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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateResourceGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资源组名称。创建通用资源组的名称，必须以字母开头，可包含字母、数字、下划线（_），最多 64 个字符。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>开通的资源组信息</p>
        /// </summary>
        [JsonProperty("Type")]
        public ResourceType Type{ get; set; }

        /// <summary>
        /// <p>是否自动续费</p>
        /// </summary>
        [JsonProperty("AutoRenewEnabled")]
        public bool? AutoRenewEnabled{ get; set; }

        /// <summary>
        /// <p>购买时长，单位月</p>
        /// </summary>
        [JsonProperty("PurchasePeriod")]
        public long? PurchasePeriod{ get; set; }

        /// <summary>
        /// <p>vpcId</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网</p>
        /// </summary>
        [JsonProperty("SubNet")]
        public string SubNet{ get; set; }

        /// <summary>
        /// <p>资源购买地域</p>
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// <p>关联项目空间项目id</p>
        /// </summary>
        [JsonProperty("AssociatedProjectId")]
        public string AssociatedProjectId{ get; set; }

        /// <summary>
        /// <p>资源组描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>标签值</p>
        /// </summary>
        [JsonProperty("Tags")]
        public ResourceTag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Type.", this.Type);
            this.SetParamSimple(map, prefix + "AutoRenewEnabled", this.AutoRenewEnabled);
            this.SetParamSimple(map, prefix + "PurchasePeriod", this.PurchasePeriod);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubNet", this.SubNet);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "AssociatedProjectId", this.AssociatedProjectId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

