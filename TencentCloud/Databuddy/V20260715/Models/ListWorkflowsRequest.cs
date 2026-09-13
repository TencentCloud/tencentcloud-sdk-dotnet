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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListWorkflowsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间ID，可通过 ListWorkspaces 获取。必填</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>分页页码，从 1 开始。非必填，默认 1</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页大小。非必填，默认 10，取值范围 [10, 200]</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>工作流名称关键字，对 WorkflowName 做模糊匹配。非必填，单值</p>
        /// </summary>
        [JsonProperty("WorkflowNameKeyword")]
        public string WorkflowNameKeyword{ get; set; }

        /// <summary>
        /// <p>工作流名称，精确匹配。非必填，多选（多个值之间为 OR 关系）</p>
        /// </summary>
        [JsonProperty("WorkflowNames")]
        public string[] WorkflowNames{ get; set; }

        /// <summary>
        /// <p>工作流ID，精确匹配。非必填，多选（多个值之间为 OR 关系）</p>
        /// </summary>
        [JsonProperty("WorkflowIds")]
        public string[] WorkflowIds{ get; set; }

        /// <summary>
        /// <p>工作流运行人UIN，精确匹配。非必填，多选（多个值之间为 OR 关系）</p>
        /// </summary>
        [JsonProperty("RunUserUins")]
        public string[] RunUserUins{ get; set; }

        /// <summary>
        /// <p>标签名称ID，精确匹配，可通过标签相关接口获取。非必填，多选（多个值之间为 OR 关系）</p>
        /// </summary>
        [JsonProperty("LabelKeyIds")]
        public string[] LabelKeyIds{ get; set; }

        /// <summary>
        /// <p>标签值ID，精确匹配，可通过标签相关接口获取。非必填，多选（多个值之间为 OR 关系）</p>
        /// </summary>
        [JsonProperty("LabelValueIds")]
        public string[] LabelValueIds{ get; set; }

        /// <summary>
        /// <p>快速筛选类型。非必填，单值</p><p>对齐老云 API（wedata/2025-10-10）文档示例值：</p><ul><li>MY_FAVORITE：我收藏的</li><li>MY_OWNER：我负责的</li><li>MY_AUTHORITY：我有权限</li><li>WorkflowId：支持多个工作流ID筛选</li></ul><p>后端实现现状：当前仅 MY_FAVORITE 生效（设置 favoriteUserUin 过滤当前用户收藏），MY_OWNER / MY_AUTHORITY 暂未在 Service 层实现，传入会被忽略（按全量返回）。</p>
        /// </summary>
        [JsonProperty("QuickSelectionType")]
        public string QuickSelectionType{ get; set; }

        /// <summary>
        /// <p>排序条件，多个之间按数组顺序表示优先级。非必填。<br>可排序字段白名单：CreateTime</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "WorkflowNameKeyword", this.WorkflowNameKeyword);
            this.SetParamArraySimple(map, prefix + "WorkflowNames.", this.WorkflowNames);
            this.SetParamArraySimple(map, prefix + "WorkflowIds.", this.WorkflowIds);
            this.SetParamArraySimple(map, prefix + "RunUserUins.", this.RunUserUins);
            this.SetParamArraySimple(map, prefix + "LabelKeyIds.", this.LabelKeyIds);
            this.SetParamArraySimple(map, prefix + "LabelValueIds.", this.LabelValueIds);
            this.SetParamSimple(map, prefix + "QuickSelectionType", this.QuickSelectionType);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
        }
    }
}

