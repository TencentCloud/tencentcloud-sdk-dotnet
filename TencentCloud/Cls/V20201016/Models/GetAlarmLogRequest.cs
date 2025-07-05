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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetAlarmLogRequest : AbstractModel
    {
        
        /// <summary>
        /// 要查询的执行详情的起始时间，Unix时间戳，单位ms。
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// 要查询的执行详情的结束时间，Unix时间戳，单位ms。
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }

        /// <summary>
        /// 查询过滤条件，例如：
        /// - 按告警策略ID查询：`alert_id:"alarm-0745ec00-e605-xxxx-b50b-54afe61fc971"`
        /// - 按监控对象ID查询：`monitored_object:"823d8bfa-76a7-xxxx-8399-8cda74d4009b" `
        /// - 按告警策略ID及监控对象ID查询：`alert_id:"alarm-0745ec00-e605-xxxx-b50b-54afe61fc971" AND monitored_object:"823d8bfa-76a7-xxxx-8399-8cda74d4009b"`
        /// - 按告警策略ID及监控对象ID查询支持SQL语句：`(alert_id:"alarm-5ce45495-09e8-4d58-xxxx-768134bf330c") AND (monitored_object:"3c514e84-6f1f-46ec-xxxx-05de6163f7fe") AND NOT condition_evaluate_result: "Skip" AND condition_evaluate_result:[* TO *] | SELECT count(*) as top50StatisticsTotalCount, count_if(condition_evaluate_result='ProcessError') as top50StatisticsFailureCount, count_if(notification_send_result!='NotSend') as top50NoticeTotalCount, count_if(notification_send_result='SendPartFail' or notification_send_result='SendFail') as top50NoticeFailureCount, alert_id, alert_name, monitored_object, topic_type, happen_threshold, alert_threshold, notify_template group by alert_id, alert_name, monitored_object,topic_type, happen_threshold, alert_threshold, notify_template order by top50StatisticsTotalCount desc limit 1`
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 单次查询返回的执行详情条数，最大值为1000
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 透传上次接口返回的Context值，可获取后续更多日志，总计最多可获取1万条原始日志，过期时间1小时。
        /// 注意：
        /// * 透传该参数时，请勿修改除该参数外的其它参数
        /// * 仅当检索分析语句(Query)不包含SQL时有效，SQL获取后续结果参考<a href="https://cloud.tencent.com/document/product/614/58977" target="_blank">SQL LIMIT语法</a>
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 原始日志是否按时间排序返回；可选值：asc(升序)、desc(降序)，默认为 desc
        /// 注意：
        /// * 仅当检索分析语句(Query)不包含SQL时有效
        /// * SQL结果排序方式参考<a href="https://cloud.tencent.com/document/product/614/58978" target="_blank">SQL ORDER BY语法</a>
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// true：代表使用新的检索结果返回方式，输出参数AnalysisRecords和Columns有效；
        /// false：代表使用老的检索结果返回方式，输出AnalysisResults和ColNames有效；
        /// 两种返回方式在编码格式上有少量区别，建议使用true。
        /// </summary>
        [JsonProperty("UseNewAnalysis")]
        public bool? UseNewAnalysis{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "UseNewAnalysis", this.UseNewAnalysis);
        }
    }
}

