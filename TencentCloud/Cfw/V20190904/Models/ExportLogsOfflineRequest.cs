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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportLogsOfflineRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>日志类型标识</p><p>枚举值：</p><ul><li>cfw_netflow_border： 流量日志-互联网边界</li><li>cfw_netflow_vpc： 流量日志-VPC边界</li><li>cfw_netflow_nat： 流量日志-NAT边界</li><li>cfw_rule_acl： 访问控制-互联网边界</li><li>cfw_rule_vpc_acl： 访问控制-VPC边界</li><li>cfw_rule_nat_acl： 访问控制-NAT边界</li><li>cfw_rule_threatinfo： 入侵防御-入侵防御</li><li>cfw_netflow_nta： 全流量检测与响应-流量分析</li><li>cfw_ndr_subject_risk： 全流量检测与响应-流量风险</li><li>cfw_ndr_ai_audit： 全流量检测与响应-AI流量风险</li><li>operate_log_all： 操作日志</li></ul>
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// <p>筛选开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>筛选结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>数据格式</p><p>枚举值：</p><ul><li>.json： JSON格式</li><li>.csv： CSV格式</li></ul>
        /// </summary>
        [JsonProperty("DataFormat")]
        public string DataFormat{ get; set; }

        /// <summary>
        /// <p>压缩方式，.zip、.tar.gz、.tar.zst、.tar.lz4、传空不压缩</p>
        /// </summary>
        [JsonProperty("CompressionFormat")]
        public string CompressionFormat{ get; set; }

        /// <summary>
        /// <p>日志排序，desc时间降序，asc时间升序</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>日志数量，传0按单次上限导出</p>
        /// </summary>
        [JsonProperty("Length")]
        public long? Length{ get; set; }

        /// <summary>
        /// <p>过滤条件组合</p>
        /// </summary>
        [JsonProperty("Filters")]
        public CommonFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>COS存储桶名称</p>
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// <p>COS存储桶地域</p>
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// <p>文件过期时长，1一天，7七天，-1永久</p>
        /// </summary>
        [JsonProperty("StorageDays")]
        public long? StorageDays{ get; set; }

        /// <summary>
        /// <p>日志分析查询语句，Query和Filters不能同时使用，在一次请求中有且只能选择一个</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// <p>导出任务类型，LogAnalysis日志分析导出，LogSearch日志审计导出</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "DataFormat", this.DataFormat);
            this.SetParamSimple(map, prefix + "CompressionFormat", this.CompressionFormat);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Length", this.Length);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "StorageDays", this.StorageDays);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
        }
    }
}

