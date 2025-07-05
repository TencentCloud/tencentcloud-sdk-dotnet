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

namespace TencentCloud.Solar.V20181011.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProjectsRequest : AbstractModel
    {
        
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNo")]
        public ulong? PageNo{ get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 过滤规则
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 部门范围过滤
        /// </summary>
        [JsonProperty("Filters")]
        public Filters Filters{ get; set; }

        /// <summary>
        /// 项目状态, 0:编辑中 1:运营中 2:已下线 3:已删除 4:审批中
        /// </summary>
        [JsonProperty("ProjectStatus")]
        public long? ProjectStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "ProjectStatus", this.ProjectStatus);
        }
    }
}

