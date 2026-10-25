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

    public class ModifyTDEMDialTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用 ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>任务 ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>任务状态。取值说明：active、paused。不传表示不修改。不能改为 deleted。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>探测类型。创建后不可修改。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>执行时机。创建后不可修改。</p>
        /// </summary>
        [JsonProperty("ExecutionTime")]
        public string ExecutionTime{ get; set; }

        /// <summary>
        /// <p>监听域名。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("WatchDomain")]
        public string WatchDomain{ get; set; }

        /// <summary>
        /// <p>拨测目标。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("DialDomain")]
        public string DialDomain{ get; set; }

        /// <summary>
        /// <p>TCP 端口。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>实时拨测间隔，单位毫秒。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("FrequencyMs")]
        public long? FrequencyMs{ get; set; }

        /// <summary>
        /// <p>单次探测超时，单位毫秒。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("TimeoutMs")]
        public long? TimeoutMs{ get; set; }

        /// <summary>
        /// <p>探测周期，单位毫秒。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("PeriodMs")]
        public long? PeriodMs{ get; set; }

        /// <summary>
        /// <p>发包次数。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("PackageCount")]
        public long? PackageCount{ get; set; }

        /// <summary>
        /// <p>ICMP 包大小，单位字节。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("PackageSize")]
        public long? PackageSize{ get; set; }

        /// <summary>
        /// <p>是否做路由追踪。取值说明：0 否，1 是。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("NeedMTR")]
        public long? NeedMTR{ get; set; }

        /// <summary>
        /// <p>路由追踪超时，单位毫秒。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("MTRTimeoutMs")]
        public long? MTRTimeoutMs{ get; set; }

        /// <summary>
        /// <p>路由追踪最大跳数。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("MTRMaxHop")]
        public long? MTRMaxHop{ get; set; }

        /// <summary>
        /// <p>每一跳发包次数。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("MTRPingCount")]
        public long? MTRPingCount{ get; set; }

        /// <summary>
        /// <p>慢请求阈值，单位毫秒。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("SlowThresholdMs")]
        public long? SlowThresholdMs{ get; set; }

        /// <summary>
        /// <p>错误类型过滤。不传表示不修改。</p>
        /// </summary>
        [JsonProperty("ErrorType")]
        public string ErrorType{ get; set; }

        /// <summary>
        /// <p>允许启动的客户端地区，逗号分隔，名称必须与分析页客户端地区完全一致。不传保留原值，空字符串清空。空名单表示不限制。</p>
        /// </summary>
        [JsonProperty("Regions")]
        public string Regions{ get; set; }

        /// <summary>
        /// <p>允许启动的客户端运营商，逗号分隔，名称必须与分析页客户端运营商完全一致。不传保留原值，空字符串清空。空名单表示不限制。</p>
        /// </summary>
        [JsonProperty("Operators")]
        public string Operators{ get; set; }

        /// <summary>
        /// <p>允许启动的用户 ID，逗号分隔。不传保留原值，空字符串清空。空名单表示不限制。</p>
        /// </summary>
        [JsonProperty("UserIds")]
        public string UserIds{ get; set; }

        /// <summary>
        /// <p>允许启动的设备 ID，逗号分隔。不传保留原值，空字符串清空。空名单表示不限制。</p>
        /// </summary>
        [JsonProperty("DeviceIds")]
        public string DeviceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
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
        }
    }
}

