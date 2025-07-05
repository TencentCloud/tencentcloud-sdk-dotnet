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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListDSPAClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页步长，默认为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 分页偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 过滤项。
        /// 支持的过滤项包括：DspaId、Status、Version、DspaName、Channel。
        /// DspaId和DspaName支持模糊搜索。
        /// Status支持的可选值：enabled、disabled。
        /// Version支持的可选值：trial、official。
        /// Channel支持的可选值：sp_cds_dsgc_pre（代表dsgc实例）、sp_cds_dsgc_wedata_dc（代表wedata实例）
        /// </summary>
        [JsonProperty("Filters")]
        public DspaDataSourceMngFilter[] Filters{ get; set; }

        /// <summary>
        /// 展示模式。
        /// 
        /// 目前只有两个值的处理逻辑：
        /// 
        /// 空值：需要查询每个实例的配额信息，因为是串行查询，所以速度很慢，limit最大为100
        /// 
        /// "simple"：不需要查询每个实例的配额信息，速度快，limit最大为1000
        /// </summary>
        [JsonProperty("ListMode")]
        public string ListMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "ListMode", this.ListMode);
        }
    }
}

