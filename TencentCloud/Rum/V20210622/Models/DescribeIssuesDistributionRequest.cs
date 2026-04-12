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

    public class DescribeIssuesDistributionRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品Id
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 接口调试专用，当 token 为空时，以这里的 value 作为筛选表单信息
        /// </summary>
        [JsonProperty("FormListString")]
        public string FormListString{ get; set; }

        /// <summary>
        /// 分布维度是自定义维度时，填‘user_custom’
        /// </summary>
        [JsonProperty("DimType")]
        public string DimType{ get; set; }

        /// <summary>
        /// 维度，e.g. os_version, app_version, model等
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// 数字类型字段的区间范围
        /// </summary>
        [JsonProperty("Intervals")]
        public long?[] Intervals{ get; set; }

        /// <summary>
        /// 提供给前端使用，当填写本字段时，会覆盖 form_list 的值
        /// </summary>
        [JsonProperty("ParamToken")]
        public string ParamToken{ get; set; }

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
        /// 限制返回的个数，默认返回所有值
        /// </summary>
        [JsonProperty("ParamLimit")]
        public long? ParamLimit{ get; set; }

        /// <summary>
        /// 键
        /// </summary>
        [JsonProperty("MapKey")]
        public string MapKey{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("MapName")]
        public string MapName{ get; set; }

        /// <summary>
        /// 指标类型
        /// </summary>
        [JsonProperty("MetricType")]
        public long? MetricType{ get; set; }

        /// <summary>
        /// 每页数目
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 用户自定义维度key
        /// </summary>
        [JsonProperty("UserCustomKey")]
        public string UserCustomKey{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "FormListString", this.FormListString);
            this.SetParamSimple(map, prefix + "DimType", this.DimType);
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamArraySimple(map, prefix + "Intervals.", this.Intervals);
            this.SetParamSimple(map, prefix + "ParamToken", this.ParamToken);
            this.SetParamSimple(map, prefix + "IssueId", this.IssueId);
            this.SetParamSimple(map, prefix + "IssueType", this.IssueType);
            this.SetParamSimple(map, prefix + "ParamLimit", this.ParamLimit);
            this.SetParamSimple(map, prefix + "MapKey", this.MapKey);
            this.SetParamSimple(map, prefix + "MapName", this.MapName);
            this.SetParamSimple(map, prefix + "MetricType", this.MetricType);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "UserCustomKey", this.UserCustomKey);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
            this.SetParamSimple(map, prefix + "RequestHeader", this.RequestHeader);
        }
    }
}

