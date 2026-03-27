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

    public class CreateApiKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境 ID，用于标识该密钥归属的云开发环境，不同环境之间的数据相互隔离
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 密钥类型。可选值：api_key（服务端调用使用的 API 密钥，具有完整权限，请勿暴露在客户端）、publish_key（客户端使用的公开密钥，权限受限，可安全用于前端或移动端）。
        /// </summary>
        [JsonProperty("KeyType")]
        public string KeyType{ get; set; }

        /// <summary>
        /// 密钥的自定义名称，用于在管理列表中标识和区分不同的密钥，建议填写能体现用途或归属的描述性名称，例如：server-prod、mobile-test
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// 密钥的有效期，单位为秒，最短不得低于 7200 秒。超过有效期后密钥将自动失效。不设置或设置为 0 则表示永不过期，建议根据安全需求合理设置有效期
        /// </summary>
        [JsonProperty("ExpireIn")]
        public long? ExpireIn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "KeyType", this.KeyType);
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "ExpireIn", this.ExpireIn);
        }
    }
}

