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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVariableListRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 过滤条件(支持: VariableIdList-变量ID列表, VariableType-变量类型)
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// 模块类型。枚举值: 1:环境参数, 2:应用参数, 3:系统参数, -1:所有参数
        /// </summary>
        [JsonProperty("ModuleType")]
        public long? ModuleType{ get; set; }

        /// <summary>
        /// 是否需要内部变量
        /// </summary>
        [JsonProperty("NeedInternalVariable")]
        public bool? NeedInternalVariable{ get; set; }

        /// <summary>
        /// 页码(从0开始)
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页数量(最大值:100)
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 查询关键词
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamSimple(map, prefix + "ModuleType", this.ModuleType);
            this.SetParamSimple(map, prefix + "NeedInternalVariable", this.NeedInternalVariable);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Query", this.Query);
        }
    }
}

