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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AggregateResourceInfo : AbstractModel
    {
        
        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 资源状态
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public string ResourceStatus{ get; set; }

        /// <summary>
        /// 是否删除 1:已删除 0:未删除
        /// </summary>
        [JsonProperty("ResourceDelete")]
        public ulong? ResourceDelete{ get; set; }

        /// <summary>
        /// 资源创建时间
        /// </summary>
        [JsonProperty("ResourceCreateTime")]
        public string ResourceCreateTime{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("ResourceZone")]
        public string ResourceZone{ get; set; }

        /// <summary>
        /// 合规状态
        /// </summary>
        [JsonProperty("ComplianceResult")]
        public string ComplianceResult{ get; set; }

        /// <summary>
        /// 资源所属用户ID
        /// </summary>
        [JsonProperty("ResourceOwnerId")]
        public ulong? ResourceOwnerId{ get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("ResourceOwnerName")]
        public string ResourceOwnerName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
            this.SetParamSimple(map, prefix + "ResourceDelete", this.ResourceDelete);
            this.SetParamSimple(map, prefix + "ResourceCreateTime", this.ResourceCreateTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ResourceZone", this.ResourceZone);
            this.SetParamSimple(map, prefix + "ComplianceResult", this.ComplianceResult);
            this.SetParamSimple(map, prefix + "ResourceOwnerId", this.ResourceOwnerId);
            this.SetParamSimple(map, prefix + "ResourceOwnerName", this.ResourceOwnerName);
        }
    }
}

