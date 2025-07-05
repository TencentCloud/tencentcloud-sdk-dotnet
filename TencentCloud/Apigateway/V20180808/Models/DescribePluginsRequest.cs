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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePluginsRequest : AbstractModel
    {
        
        /// <summary>
        /// 要查询的插件列表。
        /// </summary>
        [JsonProperty("PluginIds")]
        public string[] PluginIds{ get; set; }

        /// <summary>
        /// 要查询的插件名称。
        /// </summary>
        [JsonProperty("PluginName")]
        public string PluginName{ get; set; }

        /// <summary>
        /// 要查询的插件类型。
        /// </summary>
        [JsonProperty("PluginType")]
        public string PluginType{ get; set; }

        /// <summary>
        /// 返回数量，默认为 20，最大值为 100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 过滤条件。预留字段，目前不支持过滤。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PluginIds.", this.PluginIds);
            this.SetParamSimple(map, prefix + "PluginName", this.PluginName);
            this.SetParamSimple(map, prefix + "PluginType", this.PluginType);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

