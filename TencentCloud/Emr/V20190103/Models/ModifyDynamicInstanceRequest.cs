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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDynamicInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>EMR集群id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>支持DynamicInstance的服务名称</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>DynamicInstance类型</p><p>枚举值：</p><ul><li>RayCluster： RayCluster类型</li></ul>
        /// </summary>
        [JsonProperty("DynamicInstanceType")]
        public string DynamicInstanceType{ get; set; }

        /// <summary>
        /// <p>DynamicInstance的id</p>
        /// </summary>
        [JsonProperty("DynamicInstanceId")]
        public ulong? DynamicInstanceId{ get; set; }

        /// <summary>
        /// <p>更新表单配置（每个更新域都传递最新的内容，要完整）</p>
        /// </summary>
        [JsonProperty("DynamicInstanceForm")]
        public ModifyDynamicInstanceForm DynamicInstanceForm{ get; set; }

        /// <summary>
        /// <p>更新YAML配置</p>
        /// </summary>
        [JsonProperty("DynamicInstanceYaml")]
        public string DynamicInstanceYaml{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "DynamicInstanceType", this.DynamicInstanceType);
            this.SetParamSimple(map, prefix + "DynamicInstanceId", this.DynamicInstanceId);
            this.SetParamObj(map, prefix + "DynamicInstanceForm.", this.DynamicInstanceForm);
            this.SetParamSimple(map, prefix + "DynamicInstanceYaml", this.DynamicInstanceYaml);
        }
    }
}

