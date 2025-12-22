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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReleaseOrderInfo : AbstractModel
    {
        
        /// <summary>
        /// 发布单Id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 当前版本
        /// </summary>
        [JsonProperty("CurrentVersion")]
        public VersionInfo CurrentVersion{ get; set; }

        /// <summary>
        /// 发布版本
        /// </summary>
        [JsonProperty("ReleaseVersion")]
        public VersionInfo ReleaseVersion{ get; set; }

        /// <summary>
        /// 灰度状态
        /// </summary>
        [JsonProperty("GrayStatus")]
        public string GrayStatus{ get; set; }

        /// <summary>
        /// 发布状态
        /// </summary>
        [JsonProperty("ReleaseStatus")]
        public string ReleaseStatus{ get; set; }

        /// <summary>
        /// 流量值
        /// </summary>
        [JsonProperty("TrafficTypeValues")]
        public ObjectKV[] TrafficTypeValues{ get; set; }

        /// <summary>
        /// 流量类型
        /// </summary>
        [JsonProperty("TrafficType")]
        public string TrafficType{ get; set; }

        /// <summary>
        /// 百分比
        /// </summary>
        [JsonProperty("FlowRatio")]
        public long? FlowRatio{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否发布中
        /// </summary>
        [JsonProperty("IsReleasing")]
        public bool? IsReleasing{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamObj(map, prefix + "CurrentVersion.", this.CurrentVersion);
            this.SetParamObj(map, prefix + "ReleaseVersion.", this.ReleaseVersion);
            this.SetParamSimple(map, prefix + "GrayStatus", this.GrayStatus);
            this.SetParamSimple(map, prefix + "ReleaseStatus", this.ReleaseStatus);
            this.SetParamArrayObj(map, prefix + "TrafficTypeValues.", this.TrafficTypeValues);
            this.SetParamSimple(map, prefix + "TrafficType", this.TrafficType);
            this.SetParamSimple(map, prefix + "FlowRatio", this.FlowRatio);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsReleasing", this.IsReleasing);
        }
    }
}

