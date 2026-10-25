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

    public class CreateTDEMDialTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用 ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>任务名称，最长 128 个字符</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>探测类型。取值说明：icmp、tcp。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>执行时机。取值说明：realtime、after_request、after_error、after_slow、after_dns_slow。tcp 不能使用 after_dns_slow。</p>
        /// </summary>
        [JsonProperty("ExecutionTime")]
        public string ExecutionTime{ get; set; }

        /// <summary>
        /// <p>单次探测超时，单位毫秒。范围 1000 到 20000。</p>
        /// </summary>
        [JsonProperty("TimeoutMs")]
        public long? TimeoutMs{ get; set; }

        /// <summary>
        /// <p>探测周期，单位毫秒，必须大于 0。</p>
        /// </summary>
        [JsonProperty("PeriodMs")]
        public long? PeriodMs{ get; set; }

        /// <summary>
        /// <p>发包次数。范围 3 到 40。</p>
        /// </summary>
        [JsonProperty("PackageCount")]
        public long? PackageCount{ get; set; }

        /// <summary>
        /// <p>任务状态。取值说明：active、paused。不传时默认为 active。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>监听域名。ExecutionTime 不是 realtime 时必填。</p>
        /// </summary>
        [JsonProperty("WatchDomain")]
        public string WatchDomain{ get; set; }

        /// <summary>
        /// <p>拨测目标。域名、IP 或 ldns。after_dns_slow 固定为 ldns，其它时机必填。</p>
        /// </summary>
        [JsonProperty("DialDomain")]
        public string DialDomain{ get; set; }

        /// <summary>
        /// <p>TCP 端口，1 到 65535。Type 为 tcp 时必填。</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>实时拨测间隔，单位毫秒。ExecutionTime 为 realtime 时必填。取值说明：60000、300000、600000、900000、1800000、3600000。</p>
        /// </summary>
        [JsonProperty("FrequencyMs")]
        public long? FrequencyMs{ get; set; }

        /// <summary>
        /// <p>ICMP 包大小，单位字节。范围 32 到 1024。不传时默认 64。</p>
        /// </summary>
        [JsonProperty("PackageSize")]
        public long? PackageSize{ get; set; }

        /// <summary>
        /// <p>是否做路由追踪。取值说明：0 否，1 是。不传时为 0。</p>
        /// </summary>
        [JsonProperty("NeedMTR")]
        public long? NeedMTR{ get; set; }

        /// <summary>
        /// <p>路由追踪超时，单位毫秒。NeedMTR 为 1 时必填。</p>
        /// </summary>
        [JsonProperty("MTRTimeoutMs")]
        public long? MTRTimeoutMs{ get; set; }

        /// <summary>
        /// <p>路由追踪最大跳数。NeedMTR 为 1 时填写。</p>
        /// </summary>
        [JsonProperty("MTRMaxHop")]
        public long? MTRMaxHop{ get; set; }

        /// <summary>
        /// <p>每一跳发包次数。范围 3 到 40。</p>
        /// </summary>
        [JsonProperty("MTRPingCount")]
        public long? MTRPingCount{ get; set; }

        /// <summary>
        /// <p>慢请求阈值，单位毫秒。after_slow、after_dns_slow 不传时默认 2000。</p>
        /// </summary>
        [JsonProperty("SlowThresholdMs")]
        public long? SlowThresholdMs{ get; set; }

        /// <summary>
        /// <p>错误类型过滤。after_error 时使用。</p>
        /// </summary>
        [JsonProperty("ErrorType")]
        public string ErrorType{ get; set; }

        /// <summary>
        /// <p>允许启动的客户端地区，逗号分隔，名称必须与分析页客户端地区完全一致。不传或空字符串表示不限制。</p>
        /// </summary>
        [JsonProperty("Regions")]
        public string Regions{ get; set; }

        /// <summary>
        /// <p>允许启动的客户端运营商，逗号分隔，名称必须与分析页客户端运营商完全一致。不传或空字符串表示不限制。</p>
        /// </summary>
        [JsonProperty("Operators")]
        public string Operators{ get; set; }

        /// <summary>
        /// <p>允许启动的用户 ID，逗号分隔。不传或空字符串表示不限制。</p>
        /// </summary>
        [JsonProperty("UserIds")]
        public string UserIds{ get; set; }

        /// <summary>
        /// <p>允许启动的设备 ID，逗号分隔。不传或空字符串表示不限制。</p>
        /// </summary>
        [JsonProperty("DeviceIds")]
        public string DeviceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ExecutionTime", this.ExecutionTime);
            this.SetParamSimple(map, prefix + "TimeoutMs", this.TimeoutMs);
            this.SetParamSimple(map, prefix + "PeriodMs", this.PeriodMs);
            this.SetParamSimple(map, prefix + "PackageCount", this.PackageCount);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "WatchDomain", this.WatchDomain);
            this.SetParamSimple(map, prefix + "DialDomain", this.DialDomain);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "FrequencyMs", this.FrequencyMs);
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
        }
    }
}

