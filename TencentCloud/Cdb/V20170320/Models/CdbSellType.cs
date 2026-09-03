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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CdbSellType : AbstractModel
    {
        
        /// <summary>
        /// <p>售卖实例名称。<br>Z3：是高可用类型，对应规格中的 DeviceType，包含 UNIVERSAL，EXCLUSIVE。<br>CVM：是基础版类型，对应规格中的 DeviceType 是 BASIC（已下线）。<br>TKE：是基础版v2类型，对应规格中的 DeviceType 是 BASIC_V2。<br>CLOUD_NATIVE_CLUSTER：表示云盘版标准型。<br>CLOUD_NATIVE_CLUSTER_EXCLUSIVE：表示云盘版加强型。<br>CLOUD_NATIVE_CLUSTER_ULTRA：表示云盘版旗舰型。<br>CLOUD_NATIVE_SINGLE_NODE：表示云盘版单节点<br>ECONOMICAL：表示经济型。</p>
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// <p>引擎版本号</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string[] EngineVersion{ get; set; }

        /// <summary>
        /// <p>售卖规格Id</p>
        /// </summary>
        [JsonProperty("ConfigIds")]
        public long?[] ConfigIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamArraySimple(map, prefix + "EngineVersion.", this.EngineVersion);
            this.SetParamArraySimple(map, prefix + "ConfigIds.", this.ConfigIds);
        }
    }
}

