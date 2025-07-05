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

    public class ModifySecretRequest : AbstractModel
    {
        
        /// <summary>
        /// 边缘单元ID
        /// </summary>
        [JsonProperty("EdgeUnitID")]
        public ulong? EdgeUnitID{ get; set; }

        /// <summary>
        /// Secret名
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// Secret的Yaml格式
        /// </summary>
        [JsonProperty("Yaml")]
        public string Yaml{ get; set; }

        /// <summary>
        /// Secret命名空间（默认:default）
        /// </summary>
        [JsonProperty("SecretNamespace")]
        public string SecretNamespace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EdgeUnitID", this.EdgeUnitID);
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "Yaml", this.Yaml);
            this.SetParamSimple(map, prefix + "SecretNamespace", this.SecretNamespace);
        }
    }
}

