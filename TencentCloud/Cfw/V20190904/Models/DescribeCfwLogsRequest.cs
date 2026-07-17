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
        /// <p>日志类型。首次查询必填；使用 NextToken 续查时不能传。枚举值包括 cfw_netflow_border、cfw_netflow_vpc、cfw_netflow_nat、cfw_netflow_nta、cfw_netflow_dns、cfw_rule_threatinfo、cfw_rule_acl、cfw_rule_vpc_acl、cfw_rule_nat_acl、cfw_ndr_subject_risk、cfw_ndr_dataleak_entry、cfw_ndr_ai_audit、cfw_feature_collect、cfw_behavior_collect、operate_log_all。</p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>CLS CQL 查询语句。默认 *；使用 NextToken 续查时不能传。</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// <p>查询起始时间。支持 RFC3339、YYYY-MM-DD HH:MM:SS、YYYY-MM-DD 或 Unix 时间戳；传入后从该时间向后查询 TimeRange；使用 NextToken 续查时不能传。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>查询时间范围。默认 1h；格式为正整数加单位 m/h/d，例如 5m、1h、24h、7d；使用 NextToken 续查时不能传。</p>
        /// </summary>
        [JsonProperty("TimeRange")]
        public string TimeRange{ get; set; }

        /// <summary>
        /// <p>单页返回条数。默认 100，最大 1000；使用 NextToken 续查时不能传。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>上一页 Response.Data 返回的不透明续查 token。首次查询不传；续查时只传 NextToken。无效、篡改、过期或租户不匹配会被拒绝。</p>
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

