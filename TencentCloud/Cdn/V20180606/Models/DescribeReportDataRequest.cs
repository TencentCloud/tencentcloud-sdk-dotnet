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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReportDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询起始时间：yyyy-MM-dd
        /// 当报表类型为daily，起始时间和结束时间必须为同一天
        /// 当报表类型为weekly，起始时间须为周一，结束时间须为同一周的周日
        /// 当报表类型为monthly，起始时间须为自然月第一天，即1号，结束时间须为该自然月最后一天
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间：yyyy-MM-dd
        /// 当报表类型为daily，起始时间和结束时间必须为同一天
        /// 当报表类型为weekly，起始时间须为周一，结束时间须为同一周的周日
        /// 当报表类型为monthly，起始时间须为自然月第一天，即1号，结束时间须为该自然月最后一天
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 报表类型
        /// daily：日报表
        /// weekly：周报表（周一至周日）
        /// monthly：月报表（自然月）
        /// </summary>
        [JsonProperty("ReportType")]
        public string ReportType{ get; set; }

        /// <summary>
        /// 域名加速区域
        /// mainland：中国境内
        /// overseas：中国境外
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 偏移量，默认0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 数据个数，默认1000。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 按项目ID筛选
        /// </summary>
        [JsonProperty("Project")]
        public long? Project{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Project", this.Project);
        }
    }
}

