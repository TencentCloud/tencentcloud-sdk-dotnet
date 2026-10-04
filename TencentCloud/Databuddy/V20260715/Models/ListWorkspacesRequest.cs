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

    public class ListWorkspacesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间ID精确匹配</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>工作空间名称模糊匹配</p>
        /// </summary>
        [JsonProperty("WorkspaceKeyword")]
        public string WorkspaceKeyword{ get; set; }

        /// <summary>
        /// <p>工作空间状态过滤（多选）：0=未指定 1=创建中 2=创建失败 3=正常运行中 4=已删除</p>
        /// </summary>
        [JsonProperty("StatusList")]
        public long?[] StatusList{ get; set; }

        /// <summary>
        /// <p>多字段排序，如 [{Name: 'CreateTime', Direction: 'Desc'}]；传入单个即单字段排序，默认按创建时间降序</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }

        /// <summary>
        /// <p>页码，从1开始，默认1</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页大小，默认10，最小10，最大100</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>工作空间地域过滤（多选），如 ap-guangzhou</p>
        /// </summary>
        [JsonProperty("WorkspaceRegion")]
        public string[] WorkspaceRegion{ get; set; }

        /// <summary>
        /// <p>创建者UIN过滤（多选）</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string[] Creator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkspaceKeyword", this.WorkspaceKeyword);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "WorkspaceRegion.", this.WorkspaceRegion);
            this.SetParamArraySimple(map, prefix + "Creator.", this.Creator);
        }
    }
}

