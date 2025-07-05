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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEventsAuditTrackRequest : AbstractModel
    {
        
        /// <summary>
        /// 跟踪集名称，仅支持大小写字母、数字、-以及_的组合，3-48个字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 跟踪集状态（未开启：0；开启：1）
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 数据投递存储（目前支持 cos、cls）
        /// </summary>
        [JsonProperty("Storage")]
        public Storage Storage{ get; set; }

        /// <summary>
        /// 数据过滤条件
        /// </summary>
        [JsonProperty("Filters")]
        public Filter Filters{ get; set; }

        /// <summary>
        /// 是否开启将集团成员操作日志投递到集团管理账号或者可信服务管理账号(0：未开启，1：开启，只能集团管理账号或者可信服务管理账号开启此项功能) 
        /// </summary>
        [JsonProperty("TrackForAllMembers")]
        public ulong? TrackForAllMembers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Storage.", this.Storage);
            this.SetParamObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "TrackForAllMembers", this.TrackForAllMembers);
        }
    }
}

