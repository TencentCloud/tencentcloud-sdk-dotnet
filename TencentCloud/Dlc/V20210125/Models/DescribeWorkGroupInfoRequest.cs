/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWorkGroupInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作组Id
        /// </summary>
        [JsonProperty("WorkGroupId")]
        public long? WorkGroupId{ get; set; }

        /// <summary>
        /// 查询信息类型：User：用户信息 DataAuth：数据权限 EngineAuth：引擎权限
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 查询的过滤条件。
        /// 
        /// 当Type为User时，支持Key为user-name的模糊搜索；
        /// 
        /// 当Type为DataAuth时，支持key：
        /// 
        /// policy-type：权限类型。
        /// 
        /// policy-source：数据来源。
        /// 
        /// data-name：库表的模糊搜索。
        /// 
        /// 当Type为EngineAuth时，支持key：
        /// 
        /// policy-type：权限类型。
        /// 
        /// policy-source：数据来源。
        /// 
        /// engine-name：库表的模糊搜索。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段。
        /// 
        /// 当Type为User时，支持create-time、user-name
        /// 
        /// 当Type为DataAuth时，支持create-time
        /// 
        /// 当Type为EngineAuth时，支持create-time
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// 排序方式，desc表示正序，asc表示反序， 默认为asc
        /// </summary>
        [JsonProperty("Sorting")]
        public string Sorting{ get; set; }

        /// <summary>
        /// 返回数量，默认20，最大值100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkGroupId", this.WorkGroupId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "Sorting", this.Sorting);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

