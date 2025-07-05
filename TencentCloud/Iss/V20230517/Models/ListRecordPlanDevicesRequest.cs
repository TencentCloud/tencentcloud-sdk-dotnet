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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListRecordPlanDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 上云计划ID
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// 每页最大数量
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 按照设备名称查询，为空时，不参考该参数
        /// 通道名称、设备名称、组织名称同时只有一个有效，如果同时多个字段有值，按照通道名称、设备名称、组织名称的优先级顺序查询，如果都为空，则全量查询。长度不超过32字节
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 按照通道名称查询，为空时，不参考该参数
        /// 通道名称、设备名称、组织名称同时只有一个有效，如果同时多个字段有值，按照通道名称、设备名称、组织名称的优先级顺序查询，如果都为空，则全量查询。长度不超过32字节
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 按照组织名称查询|，为空时，不参考该参数
        /// 通道名称、设备名称、组织名称同时只有一个有效，如果同时多个字段有值，按照通道名称、设备名称、组织名称的优先级顺序查询，如果都为空，则全量查询。长度不超过32字节
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
        }
    }
}

