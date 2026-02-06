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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFlowStatisticByNameRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 开始查找时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 流量种类（1：上行流量，2：下行流量，3：上下行总和）
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 时间粒度（1：按小时统计，2：按天统计）
        /// </summary>
        [JsonProperty("TimeGranularity")]
        public long? TimeGranularity{ get; set; }

        /// <summary>
        /// 接入区域。取值范围：['MC','AP','EU','AM'] MC=中国大陆 AP=亚太 EU=欧洲 AM=美洲。不填代表全量区域。
        /// </summary>
        [JsonProperty("AccessRegion")]
        public string AccessRegion{ get; set; }

        /// <summary>
        /// 网关类型。0：公有云网关；1：自有网关。不传默认为0。
        /// </summary>
        [JsonProperty("GatewayType")]
        public long? GatewayType{ get; set; }

        /// <summary>
        /// 设备名列表，用于查询多设备流量，该字段启用时DeviceId可传"-1"
        /// </summary>
        [JsonProperty("DeviceList")]
        public string[] DeviceList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TimeGranularity", this.TimeGranularity);
            this.SetParamSimple(map, prefix + "AccessRegion", this.AccessRegion);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamArraySimple(map, prefix + "DeviceList.", this.DeviceList);
        }
    }
}

