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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePartitionMonitorOverviewRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资源分区编码</p>
        /// </summary>
        [JsonProperty("PartitionCode")]
        public string PartitionCode{ get; set; }

        /// <summary>
        /// <p>资源组（队列）名称，可选。不传时返回 partition 维度指标（含 pending_workloads / admission_wait_seconds / top_queue_by_cpu 排队卡片、<em>_limit_business 计费口径已使用量、</em><em>quota_total 配额、postpay_month_consumed_total 当月已消耗）；传入时切换为 queue 维度：仅返回 queue</em> 前缀指标（queue_<em><em>limit_business 计费口径已使用量 / queue</em></em>_admitted Kueue 对照口径 / queue_pending_workloads / queue_admission_wait_seconds）+ 该队列的配额指标（cpu_quota_total / memory_quota_total / gpu_quota_total / vram_quota_total，数值来自队列的 resource_usage 而非分区 resource_config）+ postpay_month_consumed_total</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>指标 key 过滤列表，为空则返回全部指标</p>
        /// </summary>
        [JsonProperty("MetricKeys")]
        public string[] MetricKeys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionCode", this.PartitionCode);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamArraySimple(map, prefix + "MetricKeys.", this.MetricKeys);
        }
    }
}

