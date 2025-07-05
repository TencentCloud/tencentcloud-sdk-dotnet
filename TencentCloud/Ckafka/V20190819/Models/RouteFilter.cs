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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RouteFilter : AbstractModel
    {
        
        /// <summary>
        /// 过滤名称,目前支持security-group-id,按安全组关联过滤
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 过滤值,当过滤名称为security-group-id时仅支持传单个value
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// 过滤关系,支持IN和NOT_IN,默认为IN
        /// </summary>
        [JsonProperty("Relation")]
        public string Relation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamSimple(map, prefix + "Relation", this.Relation);
        }
    }
}

