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

    public class DescribeCfwLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志类型。首次查询必填；使用 NextToken 续查时不能传。cfw_netflow_border=互联网边界流量，cfw_netflow_vpc=VPC 东西向流量，cfw_netflow_nat=NAT 防火墙流量，cfw_netflow_nta=NDR/NTA 流量，cfw_netflow_dns=DNS 防火墙日志，cfw_rule_threatinfo=入侵防御/威胁情报告警，cfw_rule_acl=互联网边界访问控制日志，cfw_rule_vpc_acl=VPC 访问控制日志，cfw_rule_nat_acl=NAT 访问控制日志，cfw_ndr_subject_risk=NDR 专题风险，cfw_ndr_dataleak_entry=NDR 敏感数据泄露，cfw_ndr_ai_audit=NDR AI 应用识别与大模型调用审计，cfw_feature_collect=统计特征与基线异常，cfw_behavior_collect=Beacon/DNS/端口/证书/VPC 互访行为，operate_log_all=操作审计日志。
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 日志过滤表达式。默认 * 表示不过滤；例如 src_ip:1.1.1.1。可查询字段随 LogType 变化，应优先使用对应 Items 中已返回的字段名，不要猜测不存在的字段；使用 NextToken 续查时不能传。
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 查询起始时间。支持 RFC3339、YYYY-MM-DD HH:MM:SS、YYYY-MM-DD 或 Unix 时间戳；传入后从该时间向后查询 TimeRange；使用 NextToken 续查时不能传。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询时间范围。默认 1h；格式为正整数加单位 m/h/d，例如 5m、1h、24h、7d；使用 NextToken 续查时不能传。
        /// </summary>
        [JsonProperty("TimeRange")]
        public string TimeRange{ get; set; }

        /// <summary>
        /// 单页返回条数。首次查询可选，默认 100；取值 1 至 1000；使用 NextToken 续查时不能传。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 上一页 Response.Data 返回的不透明续查 token。首次查询不传；续查时只传 NextToken。无效、篡改或租户不匹配会被拒绝。
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TimeRange", this.TimeRange);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
        }
    }
}

