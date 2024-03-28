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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBaselineRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Data")]
        public BaselineRule Data{ get; set; }

        /// <summary>
        /// 是否过滤全选
        /// </summary>
        [JsonProperty("SelectAll")]
        public long? SelectAll{ get; set; }

        /// <summary>
        /// <li>ItemName - string - 是否必填：否 - 项名称</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 0:检测项，1:检测项分类
        /// </summary>
        [JsonProperty("IdType")]
        public ulong? IdType{ get; set; }

        /// <summary>
        /// 需要排除的检测项id
        /// </summary>
        [JsonProperty("ExcludeIds")]
        public ulong?[] ExcludeIds{ get; set; }

        /// <summary>
        /// 勾选的检测项分类
        /// </summary>
        [JsonProperty("CategoryIds")]
        public ulong?[] CategoryIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "SelectAll", this.SelectAll);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "IdType", this.IdType);
            this.SetParamArraySimple(map, prefix + "ExcludeIds.", this.ExcludeIds);
            this.SetParamArraySimple(map, prefix + "CategoryIds.", this.CategoryIds);
        }
    }
}

