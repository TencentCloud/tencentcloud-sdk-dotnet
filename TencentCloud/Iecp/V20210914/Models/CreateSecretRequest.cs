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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSecretRequest : AbstractModel
    {
        
        /// <summary>
        /// 单元ID
        /// </summary>
        [JsonProperty("EdgeUnitID")]
        public ulong? EdgeUnitID{ get; set; }

        /// <summary>
        /// secret名
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// 命名空间（默认:default）
        /// </summary>
        [JsonProperty("SecretNamespace")]
        public string SecretNamespace{ get; set; }

        /// <summary>
        /// secret类型(取值范围:DockerConfigJson,Opaque 默认Opaque)
        /// </summary>
        [JsonProperty("SecretType")]
        public string SecretType{ get; set; }

        /// <summary>
        /// DockerConfig的序列化base64编码后的字符串
        /// </summary>
        [JsonProperty("DockerConfigJson")]
        public string DockerConfigJson{ get; set; }

        /// <summary>
        /// Opaque类型的Secret内容
        /// </summary>
        [JsonProperty("CloudData")]
        public KeyValueObj[] CloudData{ get; set; }

        /// <summary>
        /// DockerConfig配置
        /// </summary>
        [JsonProperty("DockerConfig")]
        public DockerConfig DockerConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EdgeUnitID", this.EdgeUnitID);
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "SecretNamespace", this.SecretNamespace);
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
            this.SetParamSimple(map, prefix + "DockerConfigJson", this.DockerConfigJson);
            this.SetParamArrayObj(map, prefix + "CloudData.", this.CloudData);
            this.SetParamObj(map, prefix + "DockerConfig.", this.DockerConfig);
        }
    }
}

