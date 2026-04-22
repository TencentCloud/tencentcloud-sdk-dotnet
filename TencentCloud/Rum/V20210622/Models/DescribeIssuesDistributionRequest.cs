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
        /// <p>产品Id</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>接口调试专用，当 token 为空时，以这里的 value 作为筛选表单信息</p>
        /// </summary>
        [JsonProperty("FormListString")]
        public string FormListString{ get; set; }

        /// <summary>
        /// <p>分布维度是自定义维度时，填‘user_custom’</p>
        /// </summary>
        [JsonProperty("DimType")]
        public string DimType{ get; set; }

        /// <summary>
        /// <p>维度，e.g. os_version, app_version, model等</p>
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// <p>数字类型字段的区间范围</p>
        /// </summary>
        [JsonProperty("Intervals")]
        public long?[] Intervals{ get; set; }

        /// <summary>
        /// <p>提供给前端使用，当填写本字段时，会覆盖 form_list 的值</p>
        /// </summary>
        [JsonProperty("ParamToken")]
        public string ParamToken{ get; set; }

        /// <summary>
        /// <p>问题Id</p>
        /// </summary>
        [JsonProperty("IssueId")]
        public string IssueId{ get; set; }

        /// <summary>
        /// <p>问题类型</p>
        /// </summary>
        [JsonProperty("IssueType")]
        public long? IssueType{ get; set; }

        /// <summary>
        /// <p>限制返回的个数，默认返回所有值</p>
        /// </summary>
        [JsonProperty("ParamLimit")]
        public long? ParamLimit{ get; set; }

        /// <summary>
        /// <p>键</p>
        /// </summary>
        [JsonProperty("MapKey")]
        public string MapKey{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("MapName")]
        public string MapName{ get; set; }

        /// <summary>
        /// <p>指标类型</p>
        /// </summary>
        [JsonProperty("MetricType")]
        public long? MetricType{ get; set; }

        /// <summary>
        /// <p>每页数目</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>页码</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>用户自定义维度key</p>
        /// </summary>
        [JsonProperty("UserCustomKey")]
        public string UserCustomKey{ get; set; }

        /// <summary>
        /// <p>拓展字段</p>
        /// </summary>
        [JsonProperty("ExtraData")]
        public string ExtraData{ get; set; }

        /// <summary>
        /// <p>请求头</p>
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

