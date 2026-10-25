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

    public class DialTask : AbstractModel
    {
        
        /// <summary>
        /// <p>任务 ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>任务状态。取值说明：active、paused；已删除任务不返回。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>探测类型。取值说明：icmp、tcp。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>执行时机。取值说明：realtime、after_request、after_error、after_slow、after_dns_slow。</p>
        /// </summary>
        [JsonProperty("ExecutionTime")]
        public string ExecutionTime{ get; set; }

        /// <summary>
        /// <p>监听域名。非 realtime 时有值。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WatchDomain")]
        public string WatchDomain{ get; set; }

        /// <summary>
        /// <p>拨测目标。域名、IP 或 ldns。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DialDomain")]
        public string DialDomain{ get; set; }

        /// <summary>
        /// <p>TCP 端口。仅 tcp 任务返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>实时拨测间隔，单位毫秒。仅 realtime 返回。取值说明：60000、300000、600000、900000、1800000、3600000。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrequencyMs")]
        public long? FrequencyMs{ get; set; }

        /// <summary>
        /// <p>单次探测超时，单位毫秒。范围 1000 到 20000。</p>
        /// </summary>
        [JsonProperty("TimeoutMs")]
        public long? TimeoutMs{ get; set; }

        /// <summary>
        /// <p>探测周期，单位毫秒。</p>
        /// </summary>
        [JsonProperty("PeriodMs")]
        public long? PeriodMs{ get; set; }

        /// <summary>
        /// <p>发包次数。范围 3 到 40。</p>
        /// </summary>
        [JsonProperty("PackageCount")]
        public long? PackageCount{ get; set; }

        /// <summary>
        /// <p>ICMP 包大小，单位字节。范围 32 到 1024，默认 64。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageSize")]
        public long? PackageSize{ get; set; }

        /// <summary>
        /// <p>是否做路由追踪。取值说明：0 否，1 是。</p>
        /// </summary>
        [JsonProperty("NeedMTR")]
        public long? NeedMTR{ get; set; }

        /// <summary>
        /// <p>路由追踪超时，单位毫秒。NeedMTR 为 1 时有值。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MTRTimeoutMs")]
        public long? MTRTimeoutMs{ get; set; }

        /// <summary>
        /// <p>路由追踪最大跳数。NeedMTR 为 1 时有值。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MTRMaxHop")]
        public long? MTRMaxHop{ get; set; }

        /// <summary>
        /// <p>每一跳发包次数。范围 3 到 40。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MTRPingCount")]
        public long? MTRPingCount{ get; set; }

        /// <summary>
        /// <p>慢请求阈值，单位毫秒。after_slow、after_dns_slow 时使用，默认 2000。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlowThresholdMs")]
        public long? SlowThresholdMs{ get; set; }

        /// <summary>
        /// <p>错误类型过滤。after_error 时使用。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorType")]
        public string ErrorType{ get; set; }

        /// <summary>
        /// <p>允许启动的客户端地区，逗号分隔，名称与分析页客户端地区一致。空表示不限制。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Regions")]
        public string Regions{ get; set; }

        /// <summary>
        /// <p>允许启动的客户端运营商，逗号分隔，名称与分析页客户端运营商一致。空表示不限制。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operators")]
        public string Operators{ get; set; }

        /// <summary>
        /// <p>允许启动的用户 ID，逗号分隔。空表示不限制。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserIds")]
        public string UserIds{ get; set; }

        /// <summary>
        /// <p>允许启动的设备 ID，逗号分隔。空表示不限制。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceIds")]
        public string DeviceIds{ get; set; }

        /// <summary>
        /// <p>创建人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ExecutionTime", this.ExecutionTime);
            this.SetParamSimple(map, prefix + "WatchDomain", this.WatchDomain);
            this.SetParamSimple(map, prefix + "DialDomain", this.DialDomain);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "FrequencyMs", this.FrequencyMs);
            this.SetParamSimple(map, prefix + "TimeoutMs", this.TimeoutMs);
            this.SetParamSimple(map, prefix + "PeriodMs", this.PeriodMs);
            this.SetParamSimple(map, prefix + "PackageCount", this.PackageCount);
            this.SetParamSimple(map, prefix + "PackageSize", this.PackageSize);
            this.SetParamSimple(map, prefix + "NeedMTR", this.NeedMTR);
            this.SetParamSimple(map, prefix + "MTRTimeoutMs", this.MTRTimeoutMs);
            this.SetParamSimple(map, prefix + "MTRMaxHop", this.MTRMaxHop);
            this.SetParamSimple(map, prefix + "MTRPingCount", this.MTRPingCount);
            this.SetParamSimple(map, prefix + "SlowThresholdMs", this.SlowThresholdMs);
            this.SetParamSimple(map, prefix + "ErrorType", this.ErrorType);
            this.SetParamSimple(map, prefix + "Regions", this.Regions);
            this.SetParamSimple(map, prefix + "Operators", this.Operators);
            this.SetParamSimple(map, prefix + "UserIds", this.UserIds);
            this.SetParamSimple(map, prefix + "DeviceIds", this.DeviceIds);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
        }
    }
}

