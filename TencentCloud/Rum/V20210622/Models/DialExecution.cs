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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DialExecution : AbstractModel
    {
        
        /// <summary>
        /// <p>任务 ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称。任务已删除时仍返回当时名称，找不到则为空。</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>拨测批次 ID</p>
        /// </summary>
        [JsonProperty("TaskSessionId")]
        public string TaskSessionId{ get; set; }

        /// <summary>
        /// <p>批次开始时间，毫秒时间戳</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>客户端平台</p>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// <p>应用版本</p>
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// <p>设备机型</p>
        /// </summary>
        [JsonProperty("Device")]
        public string Device{ get; set; }

        /// <summary>
        /// <p>网络类型</p>
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// <p>客户端运营商。不是目标 IP 运营商。</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>客户端地区。不是目标 IP 地区。</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>本批次探测到的目标 IP，顺序与 TargetIpGeo 一致</p>
        /// </summary>
        [JsonProperty("TargetIps")]
        public string[] TargetIps{ get; set; }

        /// <summary>
        /// <p>每个目标 IP 的地区和运营商</p>
        /// </summary>
        [JsonProperty("TargetIpGeo")]
        public DialTargetIpGeo[] TargetIpGeo{ get; set; }

        /// <summary>
        /// <p>本批次是否全部探测成功</p>
        /// </summary>
        [JsonProperty("Success")]
        public bool? Success{ get; set; }

        /// <summary>
        /// <p>本批次是否未实际探测</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotProbed")]
        public bool? NotProbed{ get; set; }

        /// <summary>
        /// <p>本批次成功目标的平均时延，单位毫秒</p>
        /// </summary>
        [JsonProperty("AvgDuration")]
        public float? AvgDuration{ get; set; }

        /// <summary>
        /// <p>本批次是否包含路由追踪</p>
        /// </summary>
        [JsonProperty("HasMTR")]
        public bool? HasMTR{ get; set; }

        /// <summary>
        /// <p>所属用户会话 ID</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskSessionId", this.TaskSessionId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "Device", this.Device);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArraySimple(map, prefix + "TargetIps.", this.TargetIps);
            this.SetParamArrayObj(map, prefix + "TargetIpGeo.", this.TargetIpGeo);
            this.SetParamSimple(map, prefix + "Success", this.Success);
            this.SetParamSimple(map, prefix + "NotProbed", this.NotProbed);
            this.SetParamSimple(map, prefix + "AvgDuration", this.AvgDuration);
            this.SetParamSimple(map, prefix + "HasMTR", this.HasMTR);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

