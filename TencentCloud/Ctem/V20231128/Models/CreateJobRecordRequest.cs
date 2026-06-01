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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateJobRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>企业ID</p>
        /// </summary>
        [JsonProperty("CustomerId")]
        public long? CustomerId{ get; set; }

        /// <summary>
        /// <p>任务类型：即时任务</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>资产收集、漏洞信息、弱口令、目录爆破、暗网泄露、Github泄露、文库网盘泄露、敏感信息泄露，其中资产收集必包含，多个用英文逗号隔离，例如：资产收集,漏洞信息</p>
        /// </summary>
        [JsonProperty("ScanType")]
        public string ScanType{ get; set; }

        /// <summary>
        /// <p>qps设置</p>
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// <p>是否包含完整扫描</p>
        /// </summary>
        [JsonProperty("IsIncludeFullScan")]
        public bool? IsIncludeFullScan{ get; set; }

        /// <summary>
        /// <p>端口扫描 QPS，默认 100，下限 10，保守值 200，上限 5000</p><p>默认值：100</p>
        /// </summary>
        [JsonProperty("PortScanQps")]
        public long? PortScanQps{ get; set; }

        /// <summary>
        /// <p>单 IP 任务并发数，默认 1，下限 1，保守值 3，上限 10</p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("SingleIPTaskLimit")]
        public long? SingleIPTaskLimit{ get; set; }

        /// <summary>
        /// <p>任一速率超过保守值时必须为 true，否则参数错误</p>
        /// </summary>
        [JsonProperty("HighRiskAck")]
        public bool? HighRiskAck{ get; set; }

        /// <summary>
        /// <p>知情同意勾选清单，用于审计回放</p>
        /// </summary>
        [JsonProperty("ScanRateAckChecklist")]
        public string[] ScanRateAckChecklist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "ScanType", this.ScanType);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "IsIncludeFullScan", this.IsIncludeFullScan);
            this.SetParamSimple(map, prefix + "PortScanQps", this.PortScanQps);
            this.SetParamSimple(map, prefix + "SingleIPTaskLimit", this.SingleIPTaskLimit);
            this.SetParamSimple(map, prefix + "HighRiskAck", this.HighRiskAck);
            this.SetParamArraySimple(map, prefix + "ScanRateAckChecklist.", this.ScanRateAckChecklist);
        }
    }
}

