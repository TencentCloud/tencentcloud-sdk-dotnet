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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// 扩展服务类型，和入参一致	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 扩展服务名称	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 授权员工列表	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasAuthUserList")]
        public HasAuthUser[] HasAuthUserList{ get; set; }

        /// <summary>
        /// 授权企业列表（企业自动签时，该字段有值）	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasAuthOrganizationList")]
        public HasAuthOrganization[] HasAuthOrganizationList{ get; set; }

        /// <summary>
        /// 授权员工列表总数	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthUserTotal")]
        public long? AuthUserTotal{ get; set; }

        /// <summary>
        /// 授权企业列表总数	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthOrganizationTotal")]
        public long? AuthOrganizationTotal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "HasAuthUserList.", this.HasAuthUserList);
            this.SetParamArrayObj(map, prefix + "HasAuthOrganizationList.", this.HasAuthOrganizationList);
            this.SetParamSimple(map, prefix + "AuthUserTotal", this.AuthUserTotal);
            this.SetParamSimple(map, prefix + "AuthOrganizationTotal", this.AuthOrganizationTotal);
        }
    }
}

