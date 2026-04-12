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

    public class DescribeIssuesListRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品Id
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 接口调试专用，当 token 为空时，以这里的 value 作为筛选表单信息
        /// </summary>
        [JsonProperty("FormList")]
        public string FormList{ get; set; }

        /// <summary>
        /// 接口调试专用，对比模式下条件A，当 token 为空时，以这里的 value 作为筛选表单信息
        /// </summary>
        [JsonProperty("FormListA")]
        public string FormListA{ get; set; }

        /// <summary>
        /// 接口调试专用，对比模式下条件B，当 token 为空时，以这里的 value 作为筛选表单信息
        /// </summary>
        [JsonProperty("FormListB")]
        public string FormListB{ get; set; }

        /// <summary>
        /// 提供给前端使用，当填写本字段时，会覆盖 form_list 的值
        /// </summary>
        [JsonProperty("ParamToken")]
        public string ParamToken{ get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [JsonProperty("IssueType")]
        public long? IssueType{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("SortField")]
        public string SortField{ get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

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
        /// 问题对比列表模式下，用于标识是按照sort_field字段的A值排序还是B值还是ratio值
        /// </summary>
        [JsonProperty("SortABRatio")]
        public string SortABRatio{ get; set; }

        /// <summary>
        /// 模式：false:问题列表模式，true:对比列表模式
        /// </summary>
        [JsonProperty("Compare")]
        public bool? Compare{ get; set; }

        /// <summary>
        /// 对比状态 0:所有 1:新增 2：遗留 3:已解决
        /// </summary>
        [JsonProperty("CompareStatus")]
        public long? CompareStatus{ get; set; }

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
            this.SetParamSimple(map, prefix + "FormList", this.FormList);
            this.SetParamSimple(map, prefix + "FormListA", this.FormListA);
            this.SetParamSimple(map, prefix + "FormListB", this.FormListB);
            this.SetParamSimple(map, prefix + "ParamToken", this.ParamToken);
            this.SetParamSimple(map, prefix + "IssueType", this.IssueType);
            this.SetParamSimple(map, prefix + "SortField", this.SortField);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "SortABRatio", this.SortABRatio);
            this.SetParamSimple(map, prefix + "Compare", this.Compare);
            this.SetParamSimple(map, prefix + "CompareStatus", this.CompareStatus);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
            this.SetParamSimple(map, prefix + "RequestHeader", this.RequestHeader);
        }
    }
}

