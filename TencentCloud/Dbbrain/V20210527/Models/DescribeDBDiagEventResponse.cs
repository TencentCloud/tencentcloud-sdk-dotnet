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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBDiagEventResponse : AbstractModel
    {
        
        /// <summary>
        /// 诊断项。
        /// </summary>
        [JsonProperty("DiagItem")]
        public string DiagItem{ get; set; }

        /// <summary>
        /// 诊断类型。支持值包括"高危账号","自增键耗尽","连接性检查","CPU利用率","死锁","全表扫描","高并发/压力请求","预编译语句过多","内存利用率","Metadata lock","磁盘超限","内存超限","只读锁","只读实例剔除","行锁","活跃会话","慢SQL","数据库快照","磁盘空间利用率","执行计划变化","主从切换","Table open cache命中率低","大表","事务未提交","事务导致复制延迟"等。
        /// </summary>
        [JsonProperty("DiagType")]
        public string DiagType{ get; set; }

        /// <summary>
        /// 事件 ID 。
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// 诊断事件详情，若无附加解释信息则输出为空。
        /// </summary>
        [JsonProperty("Explanation")]
        public string Explanation{ get; set; }

        /// <summary>
        /// 诊断概要。
        /// </summary>
        [JsonProperty("Outline")]
        public string Outline{ get; set; }

        /// <summary>
        /// 诊断出的问题。
        /// </summary>
        [JsonProperty("Problem")]
        public string Problem{ get; set; }

        /// <summary>
        /// 严重程度。严重程度分为5级，按影响程度从高至低分别为：1：致命，2：严重，3：告警，4：提示，5：健康。
        /// </summary>
        [JsonProperty("Severity")]
        public long? Severity{ get; set; }

        /// <summary>
        /// 开始时间。格式: "yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 诊断建议，若无建议则输出为空。
        /// </summary>
        [JsonProperty("Suggestions")]
        public string Suggestions{ get; set; }

        /// <summary>
        /// 保留字段。
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 结束时间。格式: "yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiagItem", this.DiagItem);
            this.SetParamSimple(map, prefix + "DiagType", this.DiagType);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Explanation", this.Explanation);
            this.SetParamSimple(map, prefix + "Outline", this.Outline);
            this.SetParamSimple(map, prefix + "Problem", this.Problem);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Suggestions", this.Suggestions);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

