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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SessionDeviceDetail : AbstractModel
    {
        
        /// <summary>
        /// 设备类型：field或remote
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 起始点位时间，单位：秒
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 结束点位时间，单位：秒
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 码率，单位：kbps
        /// </summary>
        [JsonProperty("Rate")]
        public long?[] Rate{ get; set; }

        /// <summary>
        /// 帧率
        /// </summary>
        [JsonProperty("Fps")]
        public long?[] Fps{ get; set; }

        /// <summary>
        /// 丢包率，单位：%
        /// </summary>
        [JsonProperty("Lost")]
        public float?[] Lost{ get; set; }

        /// <summary>
        /// 网络时延，单位：ms
        /// </summary>
        [JsonProperty("NetworkLatency")]
        public long?[] NetworkLatency{ get; set; }

        /// <summary>
        /// 视频时延，单位：ms
        /// </summary>
        [JsonProperty("VideoLatency")]
        public long?[] VideoLatency{ get; set; }

        /// <summary>
        /// CPU使用率，单位：%
        /// </summary>
        [JsonProperty("CpuUsed")]
        public float?[] CpuUsed{ get; set; }

        /// <summary>
        /// 内存使用率，单位：%
        /// </summary>
        [JsonProperty("MemUsed")]
        public float?[] MemUsed{ get; set; }

        /// <summary>
        /// 时间偏移量，单位：秒
        /// </summary>
        [JsonProperty("TimeOffset")]
        public ulong?[] TimeOffset{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamArraySimple(map, prefix + "Rate.", this.Rate);
            this.SetParamArraySimple(map, prefix + "Fps.", this.Fps);
            this.SetParamArraySimple(map, prefix + "Lost.", this.Lost);
            this.SetParamArraySimple(map, prefix + "NetworkLatency.", this.NetworkLatency);
            this.SetParamArraySimple(map, prefix + "VideoLatency.", this.VideoLatency);
            this.SetParamArraySimple(map, prefix + "CpuUsed.", this.CpuUsed);
            this.SetParamArraySimple(map, prefix + "MemUsed.", this.MemUsed);
            this.SetParamArraySimple(map, prefix + "TimeOffset.", this.TimeOffset);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
        }
    }
}

