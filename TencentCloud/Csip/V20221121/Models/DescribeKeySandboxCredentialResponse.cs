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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKeySandboxCredentialResponse : AbstractModel
    {
        
        /// <summary>
        /// 凭证ID
        /// </summary>
        [JsonProperty("CredentialId")]
        public string CredentialId{ get; set; }

        /// <summary>
        /// 凭证名称
        /// </summary>
        [JsonProperty("CredentialName")]
        public string CredentialName{ get; set; }

        /// <summary>
        /// 凭证类型
        /// 枚举值：
        /// access：常规密钥
        /// sts：STS临时密钥
        /// </summary>
        [JsonProperty("CredentialType")]
        public string CredentialType{ get; set; }

        /// <summary>
        /// 生效机器范围
        /// </summary>
        [JsonProperty("CredentialEffectScope")]
        public CredentialEffectScope CredentialEffectScope{ get; set; }

        /// <summary>
        /// 常规密钥凭据数据（打码后），CredentialType为access时返回
        /// 补充说明：Key为原文，Value为打码后的值（保留前3后4位，中间用***替代）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Access")]
        public AccessCredentialOutput[] Access{ get; set; }

        /// <summary>
        /// STS凭据数据（打码后），CredentialType为sts时返回
        /// 补充说明：System为原文，SecretID和SecretKey为打码后的值（保留前3后4位，中间用***替代）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("STS")]
        public STSCredentialOutput STS{ get; set; }

        /// <summary>
        /// 创建时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CredentialId", this.CredentialId);
            this.SetParamSimple(map, prefix + "CredentialName", this.CredentialName);
            this.SetParamSimple(map, prefix + "CredentialType", this.CredentialType);
            this.SetParamObj(map, prefix + "CredentialEffectScope.", this.CredentialEffectScope);
            this.SetParamArrayObj(map, prefix + "Access.", this.Access);
            this.SetParamObj(map, prefix + "STS.", this.STS);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

