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

    public class MonitorDetail : AbstractModel
    {
        
        /// <summary>
        /// 探测规则id
        /// </summary>
        [JsonProperty("MonitorId")]
        public ulong? MonitorId{ get; set; }

        /// <summary>
        /// 监控器名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorName")]
        public string MonitorName{ get; set; }

        /// <summary>
        /// 所属用户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 监控节点id组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectorGroupIds")]
        public ulong?[] DetectorGroupIds{ get; set; }

        /// <summary>
        /// 探测协议 PING TCP HTTP HTTPS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckProtocol")]
        public string CheckProtocol{ get; set; }

        /// <summary>
        /// 探测周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckInterval")]
        public ulong? CheckInterval{ get; set; }

        /// <summary>
        /// 发包数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PingNum")]
        public ulong? PingNum{ get; set; }

        /// <summary>
        /// tcp端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcpPort")]
        public ulong? TcpPort{ get; set; }

        /// <summary>
        /// 探测 host
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 探测路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 返回值阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReturnCodeThreshold")]
        public ulong? ReturnCodeThreshold{ get; set; }

        /// <summary>
        /// 是否开启3xx重定向跟随 ENABLED DISABLED
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableRedirect")]
        public string EnableRedirect{ get; set; }

        /// <summary>
        /// 是否启用 sni
        /// ENABLED DISABLED
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableSni")]
        public string EnableSni{ get; set; }

        /// <summary>
        /// 丢包率上限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PacketLossRate")]
        public ulong? PacketLossRate{ get; set; }

        /// <summary>
        /// 探测超时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 失败次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailTimes")]
        public ulong? FailTimes{ get; set; }

        /// <summary>
        /// 失败率上限100
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailRate")]
        public ulong? FailRate{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// 监控节点类型
        /// AUTO INTERNAL OVERSEAS IPV6 ALL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectorStyle")]
        public string DetectorStyle{ get; set; }

        /// <summary>
        /// 探测次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectNum")]
        public ulong? DetectNum{ get; set; }

        /// <summary>
        /// 持续周期数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContinuePeriod")]
        public ulong? ContinuePeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonitorId", this.MonitorId);
            this.SetParamSimple(map, prefix + "MonitorName", this.MonitorName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamArraySimple(map, prefix + "DetectorGroupIds.", this.DetectorGroupIds);
            this.SetParamSimple(map, prefix + "CheckProtocol", this.CheckProtocol);
            this.SetParamSimple(map, prefix + "CheckInterval", this.CheckInterval);
            this.SetParamSimple(map, prefix + "PingNum", this.PingNum);
            this.SetParamSimple(map, prefix + "TcpPort", this.TcpPort);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "ReturnCodeThreshold", this.ReturnCodeThreshold);
            this.SetParamSimple(map, prefix + "EnableRedirect", this.EnableRedirect);
            this.SetParamSimple(map, prefix + "EnableSni", this.EnableSni);
            this.SetParamSimple(map, prefix + "PacketLossRate", this.PacketLossRate);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "FailTimes", this.FailTimes);
            this.SetParamSimple(map, prefix + "FailRate", this.FailRate);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "DetectorStyle", this.DetectorStyle);
            this.SetParamSimple(map, prefix + "DetectNum", this.DetectNum);
            this.SetParamSimple(map, prefix + "ContinuePeriod", this.ContinuePeriod);
        }
    }
}

