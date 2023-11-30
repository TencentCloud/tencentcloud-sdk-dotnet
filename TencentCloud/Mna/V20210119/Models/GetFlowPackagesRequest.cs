/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFlowPackagesRequest : AbstractModel
    {
        
        /// <summary>
        /// 页码，从1开始
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页个数
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 流量包的唯一资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 流量包绑定的设备ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 流量包状态，0：未生效，1：有效期内，2：已过期
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

