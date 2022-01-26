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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomPersonFilter : AbstractModel
    {
        
        /// <summary>
        /// 待查询的人物姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 待过滤的自定义类型Id数组
        /// </summary>
        [JsonProperty("CategoryIdSet")]
        public string[] CategoryIdSet{ get; set; }

        /// <summary>
        /// 待过滤的自定义人物Id数组
        /// </summary>
        [JsonProperty("PersonIdSet")]
        public string[] PersonIdSet{ get; set; }

        /// <summary>
        /// 一级自定义人物类型数组
        /// </summary>
        [JsonProperty("L1CategorySet")]
        public string[] L1CategorySet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "CategoryIdSet.", this.CategoryIdSet);
            this.SetParamArraySimple(map, prefix + "PersonIdSet.", this.PersonIdSet);
            this.SetParamArraySimple(map, prefix + "L1CategorySet.", this.L1CategorySet);
        }
    }
}

