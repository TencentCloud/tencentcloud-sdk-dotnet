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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SessionResult : AbstractModel
    {
        
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("RealName")]
        public string RealName{ get; set; }

        /// <summary>
        /// 主机账号
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 会话大小
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 设备名
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 内部Ip
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 外部Ip
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 来源Ip
        /// </summary>
        [JsonProperty("FromIp")]
        public string FromIp{ get; set; }

        /// <summary>
        /// 会话持续时长
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 该会话内命令数量 ，搜索图形会话时该字段无意义
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 该会话内高危命令数，搜索图形时该字段无意义
        /// </summary>
        [JsonProperty("DangerCount")]
        public ulong? DangerCount{ get; set; }

        /// <summary>
        /// 会话状态，如1会话活跃  2会话结束  3强制离线  4其他错误
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 会话Id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 设备所属的地域
        /// </summary>
        [JsonProperty("ApCode")]
        public string ApCode{ get; set; }

        /// <summary>
        /// 会话协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 应用资产类型：1-web
        /// </summary>
        [JsonProperty("AppAssetKind")]
        public ulong? AppAssetKind{ get; set; }

        /// <summary>
        /// 应用资产url
        /// </summary>
        [JsonProperty("AppAssetUrl")]
        public string AppAssetUrl{ get; set; }

        /// <summary>
        /// 回放类型 默认0, 1-rfb 2-mp4 3-ssh
        /// </summary>
        [JsonProperty("ReplayType")]
        public ulong? ReplayType{ get; set; }

        /// <summary>
        /// 会话资产类型
        /// </summary>
        [JsonProperty("DeviceKind")]
        public string DeviceKind{ get; set; }

        /// <summary>
        /// K8S集群命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// K8S集群工作负载
        /// </summary>
        [JsonProperty("Workload")]
        public string Workload{ get; set; }

        /// <summary>
        /// K8S集群容器名称
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// 访问方式 1-直链 2-客户端 3-web 大部分情况下是2
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// 是否禁用会话监控。0-不禁用；1-禁用会话，仅展示中断；2-禁用会话，不展示中断
        /// </summary>
        [JsonProperty("DisableMonitor")]
        public long? DisableMonitor{ get; set; }

        /// <summary>
        /// 实时入带宽，单位Mbps
        /// </summary>
        [JsonProperty("RealTimeBandwidthIn")]
        public float? RealTimeBandwidthIn{ get; set; }

        /// <summary>
        /// 实时出带宽，单位Mbps
        /// </summary>
        [JsonProperty("RealTimeBandwidthOut")]
        public float? RealTimeBandwidthOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "RealName", this.RealName);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "FromIp", this.FromIp);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "DangerCount", this.DangerCount);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ApCode", this.ApCode);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "AppAssetKind", this.AppAssetKind);
            this.SetParamSimple(map, prefix + "AppAssetUrl", this.AppAssetUrl);
            this.SetParamSimple(map, prefix + "ReplayType", this.ReplayType);
            this.SetParamSimple(map, prefix + "DeviceKind", this.DeviceKind);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Workload", this.Workload);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "DisableMonitor", this.DisableMonitor);
            this.SetParamSimple(map, prefix + "RealTimeBandwidthIn", this.RealTimeBandwidthIn);
            this.SetParamSimple(map, prefix + "RealTimeBandwidthOut", this.RealTimeBandwidthOut);
        }
    }
}

