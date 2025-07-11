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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAndroidInstancesByAppsRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量，默认为 0	
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 限制量，默认为 20，最大值为 500	
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 应用 ID 列表。当 AndroidIds 为多条数据时（例如 app1, app2），返回的实例列表为：安装了 app1 应用的实例和安装了 app2 应用的实例集合（并集）。
        /// </summary>
        [JsonProperty("AndroidAppIds")]
        public string[] AndroidAppIds{ get; set; }

        /// <summary>
        /// 字段过滤器，Filter 的 Name 有以下值： AndroidInstanceId：实例 Id
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "AndroidAppIds.", this.AndroidAppIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

