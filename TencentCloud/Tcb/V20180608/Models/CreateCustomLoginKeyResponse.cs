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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCustomLoginKeyResponse : AbstractModel
    {
        
        /// <summary>
        /// 自定义登录的 RSA 私钥（1024 位），PEM 编码格式（PKCS#1）。调用方需使用该私钥对包含用户身份信息的 JSON 数据进行 JWS 签名，生成 JWT Token 后传入自定义登录接口完成身份认证。出于安全考虑，系统仅存储公钥，私钥仅在创建时返回一次且无法恢复，请妥善保存。创建新密钥后，该环境下原有未设置过期时间的旧密钥将被自动标记为 2 小时后过期
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// 密钥对的唯一标识符（UUID 格式），由系统自动生成。在自定义登录时，需将该 KeyID 拼接到 ProviderToken 参数中（格式：{KeyID}/{algorithm}/{signedJWT}），服务端通过 KeyID 查找对应的公钥以验证签名
        /// </summary>
        [JsonProperty("KeyID")]
        public string KeyID{ get; set; }

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
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "KeyID", this.KeyID);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

