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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMonitorRequest : AbstractModel
    {
        
        /// <summary>
        /// 监控器名称
        /// </summary>
        [JsonProperty("MonitorName")]
        public string MonitorName{ get; set; }

        /// <summary>
        /// 探测协议，可选值 PING TCP HTTP HTTPS
        /// </summary>
        [JsonProperty("CheckProtocol")]
        public string CheckProtocol{ get; set; }

        /// <summary>
        /// 检查间隔（秒），可选值有15 60 120 300
        /// </summary>
        [JsonProperty("CheckInterval")]
        public ulong? CheckInterval{ get; set; }

        /// <summary>
        /// 超时时间，单位秒，可选值为2 3 5 10
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 重试次数，可选值为 0，1，2
        /// </summary>
        [JsonProperty("FailTimes")]
        public ulong? FailTimes{ get; set; }

        /// <summary>
        /// 失败比例，取值为 20 30 40 50 60 70 80 100，默认值50
        /// </summary>
        [JsonProperty("FailRate")]
        public ulong? FailRate{ get; set; }

        /// <summary>
        /// 监控节点类型，可选值有AUTO INTERNAL OVERSEAS IPV6 ALL
        /// </summary>
        [JsonProperty("DetectorStyle")]
        public string DetectorStyle{ get; set; }

        /// <summary>
        /// 探测器组id列表以,分隔
        /// </summary>
        [JsonProperty("DetectorGroupIds")]
        public ulong?[] DetectorGroupIds{ get; set; }

        /// <summary>
        /// PING 包数目，当CheckProtocol=ping时必填，可选值有20 50 100
        /// </summary>
        [JsonProperty("PingNum")]
        public ulong? PingNum{ get; set; }

        /// <summary>
        /// 检查端口，可选值在1-65535之间
        /// </summary>
        [JsonProperty("TcpPort")]
        public ulong? TcpPort{ get; set; }

        /// <summary>
        /// Host 设置，默认为业务域名
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// URL 路径，默认为“/”
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 返回错误码阈值, 可选值为 400 和 500, 默认值500
        /// </summary>
        [JsonProperty("ReturnCodeThreshold")]
        public ulong? ReturnCodeThreshold{ get; set; }

        /// <summary>
        /// 跟随 3XX 重定向 ，不开启为 DISABLED， 开启为 ENABLED，默认不开启
        /// </summary>
        [JsonProperty("EnableRedirect")]
        public string EnableRedirect{ get; set; }

        /// <summary>
        /// 启用 SNI，不开启为 DISABLED， 开启为 ENABLED，默认不开启
        /// </summary>
        [JsonProperty("EnableSni")]
        public string EnableSni{ get; set; }

        /// <summary>
        /// 丢包率告警阈值，当CheckProtocol=ping时必填取值为10 30 50 80 90 100
        /// </summary>
        [JsonProperty("PacketLossRate")]
        public ulong? PacketLossRate{ get; set; }

        /// <summary>
        /// 持续周期数，可选值1-5
        /// </summary>
        [JsonProperty("ContinuePeriod")]
        public ulong? ContinuePeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonitorName", this.MonitorName);
            this.SetParamSimple(map, prefix + "CheckProtocol", this.CheckProtocol);
            this.SetParamSimple(map, prefix + "CheckInterval", this.CheckInterval);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "FailTimes", this.FailTimes);
            this.SetParamSimple(map, prefix + "FailRate", this.FailRate);
            this.SetParamSimple(map, prefix + "DetectorStyle", this.DetectorStyle);
            this.SetParamArraySimple(map, prefix + "DetectorGroupIds.", this.DetectorGroupIds);
            this.SetParamSimple(map, prefix + "PingNum", this.PingNum);
            this.SetParamSimple(map, prefix + "TcpPort", this.TcpPort);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "ReturnCodeThreshold", this.ReturnCodeThreshold);
            this.SetParamSimple(map, prefix + "EnableRedirect", this.EnableRedirect);
            this.SetParamSimple(map, prefix + "EnableSni", this.EnableSni);
            this.SetParamSimple(map, prefix + "PacketLossRate", this.PacketLossRate);
            this.SetParamSimple(map, prefix + "ContinuePeriod", this.ContinuePeriod);
        }
    }
}

