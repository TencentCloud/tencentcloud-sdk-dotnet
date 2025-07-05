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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspaCloudResourceMeta : AbstractModel
    {
        
        /// <summary>
        /// 用户资源ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源名称。
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 资源VIP。
        /// </summary>
        [JsonProperty("ResourceVip")]
        public string ResourceVip{ get; set; }

        /// <summary>
        /// 资源端口。
        /// </summary>
        [JsonProperty("ResourceVPort")]
        public ulong? ResourceVPort{ get; set; }

        /// <summary>
        /// 资源被创建时间。
        /// </summary>
        [JsonProperty("ResourceCreateTime")]
        public string ResourceCreateTime{ get; set; }

        /// <summary>
        /// 用户资源VPC ID 字符串。
        /// </summary>
        [JsonProperty("ResourceUniqueVpcId")]
        public string ResourceUniqueVpcId{ get; set; }

        /// <summary>
        /// 用户资源Subnet ID 字符串。
        /// </summary>
        [JsonProperty("ResourceUniqueSubnetId")]
        public string ResourceUniqueSubnetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ResourceVip", this.ResourceVip);
            this.SetParamSimple(map, prefix + "ResourceVPort", this.ResourceVPort);
            this.SetParamSimple(map, prefix + "ResourceCreateTime", this.ResourceCreateTime);
            this.SetParamSimple(map, prefix + "ResourceUniqueVpcId", this.ResourceUniqueVpcId);
            this.SetParamSimple(map, prefix + "ResourceUniqueSubnetId", this.ResourceUniqueSubnetId);
        }
    }
}

