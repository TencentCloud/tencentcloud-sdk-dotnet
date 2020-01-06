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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamEventInfo : AbstractModel
    {
        
        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 推流域名。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 流名称。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 推流开始时间。
        /// UTC格式时间，
        /// 例如：2019-01-07T12:00:00Z。
        /// </summary>
        [JsonProperty("StreamStartTime")]
        public string StreamStartTime{ get; set; }

        /// <summary>
        /// 推流结束时间。
        /// UTC格式时间，
        /// 例如：2019-01-07T15:00:00Z。
        /// </summary>
        [JsonProperty("StreamEndTime")]
        public string StreamEndTime{ get; set; }

        /// <summary>
        /// 停止原因。
        /// </summary>
        [JsonProperty("StopReason")]
        public string StopReason{ get; set; }

        /// <summary>
        /// 推流持续时长，单位：秒。
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 主播IP。
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// 分辨率。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "StreamStartTime", this.StreamStartTime);
            this.SetParamSimple(map, prefix + "StreamEndTime", this.StreamEndTime);
            this.SetParamSimple(map, prefix + "StopReason", this.StopReason);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
        }
    }
}

