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

    public class DescribeSecretsRequest : AbstractModel
    {
        
        /// <summary>
        /// 边缘单元ID
        /// </summary>
        [JsonProperty("EdgeUnitID")]
        public ulong? EdgeUnitID{ get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 每页数目
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("SecretNamespace")]
        public string SecretNamespace{ get; set; }

        /// <summary>
        /// Secret名(模糊匹配)
        /// </summary>
        [JsonProperty("NamePattern")]
        public string NamePattern{ get; set; }

        /// <summary>
        /// Sort.Field:CreateTime Sort.Order:ASC|DESC
        /// </summary>
        [JsonProperty("Sort")]
        public FieldSort Sort{ get; set; }

        /// <summary>
        /// Secret类型(DockerConfigJson或Opaque)
        /// </summary>
        [JsonProperty("SecretType")]
        public string SecretType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EdgeUnitID", this.EdgeUnitID);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SecretNamespace", this.SecretNamespace);
            this.SetParamSimple(map, prefix + "NamePattern", this.NamePattern);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
        }
    }
}

