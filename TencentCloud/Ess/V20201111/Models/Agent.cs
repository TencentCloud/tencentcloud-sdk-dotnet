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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Agent : AbstractModel
    {
        
        /// <summary>
        /// 代理机构的应用编号,32位字符串，一般不用传
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 被代理机构的应用号，一般不用传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyAppId")]
        public string ProxyAppId{ get; set; }

        /// <summary>
        /// 被代理机构在电子签平台的机构编号，集团代理下场景必传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyOrganizationId")]
        public string ProxyOrganizationId{ get; set; }

        /// <summary>
        /// 被代理机构的经办人，一般不用传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyOperator")]
        public string ProxyOperator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ProxyAppId", this.ProxyAppId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationId", this.ProxyOrganizationId);
            this.SetParamSimple(map, prefix + "ProxyOperator", this.ProxyOperator);
        }
    }
}

