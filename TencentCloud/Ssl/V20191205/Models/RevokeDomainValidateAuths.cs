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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RevokeDomainValidateAuths : AbstractModel
    {
        
        /// <summary>
        /// DV 认证值路径。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainValidateAuthPath")]
        public string DomainValidateAuthPath{ get; set; }

        /// <summary>
        /// DV 认证 KEY。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainValidateAuthKey")]
        public string DomainValidateAuthKey{ get; set; }

        /// <summary>
        /// DV 认证值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainValidateAuthValue")]
        public string DomainValidateAuthValue{ get; set; }

        /// <summary>
        /// DV 认证域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainValidateAuthDomain")]
        public string DomainValidateAuthDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainValidateAuthPath", this.DomainValidateAuthPath);
            this.SetParamSimple(map, prefix + "DomainValidateAuthKey", this.DomainValidateAuthKey);
            this.SetParamSimple(map, prefix + "DomainValidateAuthValue", this.DomainValidateAuthValue);
            this.SetParamSimple(map, prefix + "DomainValidateAuthDomain", this.DomainValidateAuthDomain);
        }
    }
}

