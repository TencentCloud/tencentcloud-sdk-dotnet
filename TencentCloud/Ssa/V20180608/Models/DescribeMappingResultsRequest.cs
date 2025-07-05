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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMappingResultsRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件，FilterKey 取值范围：AssetId，AssetIp，PrivateIp，Protocol，Service，OS，Process，Component，AssetType，Domain，Port，LastMappingTime，MappingType，Disposal，Vpc
        /// </summary>
        [JsonProperty("Filter")]
        public AssetQueryFilter[] Filter{ get; set; }

        /// <summary>
        /// 排序条件，SortKey取值范围：CreateTime，LastMappingTime
        /// </summary>
        [JsonProperty("Sorter")]
        public QuerySort[] Sorter{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageIndex")]
        public ulong? PageIndex{ get; set; }

        /// <summary>
        /// 页大小，默认大小20
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArrayObj(map, prefix + "Sorter.", this.Sorter);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

