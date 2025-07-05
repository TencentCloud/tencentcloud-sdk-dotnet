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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateConfigMapRequest : AbstractModel
    {
        
        /// <summary>
        /// 单元ID
        /// </summary>
        [JsonProperty("EdgeUnitID")]
        public ulong? EdgeUnitID{ get; set; }

        /// <summary>
        /// ConfigMap名称
        /// </summary>
        [JsonProperty("ConfigMapName")]
        public string ConfigMapName{ get; set; }

        /// <summary>
        /// ConfigMap内容
        /// </summary>
        [JsonProperty("ConfigMapData")]
        public KeyValueObj[] ConfigMapData{ get; set; }

        /// <summary>
        /// ConfigMap命名空间,默认：default
        /// </summary>
        [JsonProperty("ConfigMapNamespace")]
        public string ConfigMapNamespace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EdgeUnitID", this.EdgeUnitID);
            this.SetParamSimple(map, prefix + "ConfigMapName", this.ConfigMapName);
            this.SetParamArrayObj(map, prefix + "ConfigMapData.", this.ConfigMapData);
            this.SetParamSimple(map, prefix + "ConfigMapNamespace", this.ConfigMapNamespace);
        }
    }
}

