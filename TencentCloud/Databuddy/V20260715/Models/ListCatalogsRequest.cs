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

    public class ListCatalogsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间唯一id</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

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
        /// <p>catalog类型，可填：TABLE、MODEL、VOLUME</p>
        /// </summary>
        [JsonProperty("Types")]
        public string[] Types{ get; set; }

        /// <summary>
        /// <p>是否只返回当前工作空间有权限的，false时会额外返回当前用户有权限管理的catalog</p>
        /// </summary>
        [JsonProperty("CurrentWorkspaceOnly")]
        public bool? CurrentWorkspaceOnly{ get; set; }

        /// <summary>
        /// <p>数据获取选项，可选，控制是否返回权限信息及按权限过滤</p>
        /// </summary>
        [JsonProperty("FetchOption")]
        public FetchOption FetchOption{ get; set; }

        /// <summary>
        /// 数据目录来源筛选（融合版新增字段），取值参考 CatalogSourceEnum。空数组或不传→只查tclake；["METALAKE"]→只查tclake；["CONNECTION"]→只查分析版ana_catalog；["METALAKE","CONNECTION"]→合并返回
        /// </summary>
        [JsonProperty("CatalogSources")]
        public string[] CatalogSources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "PageToken", this.PageToken);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
            this.SetParamSimple(map, prefix + "CurrentWorkspaceOnly", this.CurrentWorkspaceOnly);
            this.SetParamObj(map, prefix + "FetchOption.", this.FetchOption);
            this.SetParamArraySimple(map, prefix + "CatalogSources.", this.CatalogSources);
        }
    }
}

