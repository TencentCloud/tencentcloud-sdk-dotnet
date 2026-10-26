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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudNativeAPIGatewaySecretKeyListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>每页数量，最大20个</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>起始值</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>资源类型：</p><ul><li>Consumer: 消费者</li><li>LLM: 模型服务</li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>资源id</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>是否展示可以用于绑定信息,true/false</p>
        /// </summary>
        [JsonProperty("UseToBind")]
        public bool? UseToBind{ get; set; }

        /// <summary>
        /// <p>Key 可选：</p><ul><li>SecretType:  密钥类型 ApiKey</li><li>GenerateType:  生成方式，例如 KMS</li><li>Status: 状态 Enable/Disable</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>检索关键字</p>
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <p>可选 Boolean，默认 false。仅传 true 且返回记录 ResourceType=Consumer 时，额外返回 CredentialGenerateType、CreationSource、BatchId；省略或 false 时不返回这三个字段，原字段和返回结构保持不变。此参数只控制展示字段，不控制 Filters 是否生效。</p>
        /// </summary>
        [JsonProperty("IncludeCreationInfo")]
        public bool? IncludeCreationInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "UseToBind", this.UseToBind);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "IncludeCreationInfo", this.IncludeCreationInfo);
        }
    }
}

