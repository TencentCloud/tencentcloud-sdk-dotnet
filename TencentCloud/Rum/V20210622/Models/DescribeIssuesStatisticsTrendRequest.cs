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

    public class DescribeIssuesStatisticsTrendRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品Id
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 提供给前端使用，当填写本字段时，会覆盖 form_list 的值
        /// </summary>
        [JsonProperty("ParamToken")]
        public string ParamToken{ get; set; }

        /// <summary>
        /// 接口调试专用，当 token 为空时，以这里的 value 作为筛选表单信息
        /// </summary>
        [JsonProperty("FormList")]
        public string FormList{ get; set; }

        /// <summary>
        /// 问题Id
        /// </summary>
        [JsonProperty("IssueId")]
        public string IssueId{ get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [JsonProperty("IssueType")]
        public long? IssueType{ get; set; }

        /// <summary>
        /// 时间窗口
        /// </summary>
        [JsonProperty("TimeWindow")]
        public long? TimeWindow{ get; set; }

        /// <summary>
        /// 累计值
        /// </summary>
        [JsonProperty("TotalSize")]
        public bool? TotalSize{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Stat")]
        public long? Stat{ get; set; }

        /// <summary>
        /// 指标类型
        /// </summary>
        [JsonProperty("MetricType")]
        public long? MetricType{ get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [JsonProperty("ExtraData")]
        public string ExtraData{ get; set; }

        /// <summary>
        /// 请求头
        /// </summary>
        [JsonProperty("RequestHeader")]
        public string RequestHeader{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("TrendStat")]
        public long? TrendStat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ParamToken", this.ParamToken);
            this.SetParamSimple(map, prefix + "FormList", this.FormList);
            this.SetParamSimple(map, prefix + "IssueId", this.IssueId);
            this.SetParamSimple(map, prefix + "IssueType", this.IssueType);
            this.SetParamSimple(map, prefix + "TimeWindow", this.TimeWindow);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
            this.SetParamSimple(map, prefix + "Stat", this.Stat);
            this.SetParamSimple(map, prefix + "MetricType", this.MetricType);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
            this.SetParamSimple(map, prefix + "RequestHeader", this.RequestHeader);
            this.SetParamSimple(map, prefix + "TrendStat", this.TrendStat);
        }
    }
}

