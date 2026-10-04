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

    public class ListSchemasRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数据目录名</p>
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// <p>最大结果条数</p>
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// <p>分页token</p>
        /// </summary>
        [JsonProperty("PageToken")]
        public string PageToken{ get; set; }

        /// <summary>
        /// <p>调用时所在workspace唯一id</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>数据获取选项，可选，控制是否返回权限信息及按权限过滤</p>
        /// </summary>
        [JsonProperty("FetchOption")]
        public FetchOption FetchOption{ get; set; }

        /// <summary>
        /// 数据源连接ID，可选（融合版新增字段）。非空→走分析版路径，空/缺省→走专业版TcLake路径
        /// </summary>
        [JsonProperty("ConnectionId")]
        public string ConnectionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "PageToken", this.PageToken);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamObj(map, prefix + "FetchOption.", this.FetchOption);
            this.SetParamSimple(map, prefix + "ConnectionId", this.ConnectionId);
        }
    }
}

