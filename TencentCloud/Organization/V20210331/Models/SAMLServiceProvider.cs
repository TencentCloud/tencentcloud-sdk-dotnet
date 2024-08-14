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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SAMLServiceProvider : AbstractModel
    {
        
        /// <summary>
        /// https://tencentcloudsso.com/saml/sp/z-sjw8ensa**
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// 空间ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// SP 元数据文档（Base64 编码）。
        /// </summary>
        [JsonProperty("EncodedMetadataDocument")]
        public string EncodedMetadataDocument{ get; set; }

        /// <summary>
        /// SP 的 ACS URL。
        /// </summary>
        [JsonProperty("AcsUrl")]
        public string AcsUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EntityId", this.EntityId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "EncodedMetadataDocument", this.EncodedMetadataDocument);
            this.SetParamSimple(map, prefix + "AcsUrl", this.AcsUrl);
        }
    }
}

