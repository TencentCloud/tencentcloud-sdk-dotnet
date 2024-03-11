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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetSSHKeyPairValueResponse : AbstractModel
    {
        
        /// <summary>
        /// SSH密钥对ID。
        /// </summary>
        [JsonProperty("SSHKeyID")]
        public string SSHKeyID{ get; set; }

        /// <summary>
        /// 公钥明文，使用base64编码。
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }

        /// <summary>
        /// 私钥明文，使用base64编码
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// 此密钥对所属的项目ID。
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// SSH密钥对的描述信息。
        /// 用户可以在CVM侧控制台对密钥对的描述信息进行修改。
        /// </summary>
        [JsonProperty("SSHKeyDescription")]
        public string SSHKeyDescription{ get; set; }

        /// <summary>
        /// SSH密钥对的名称。
        /// 用户可以在CVM侧控制台对密钥对的名称进行修改。
        /// </summary>
        [JsonProperty("SSHKeyName")]
        public string SSHKeyName{ get; set; }

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
            this.SetParamSimple(map, prefix + "SSHKeyID", this.SSHKeyID);
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamSimple(map, prefix + "SSHKeyDescription", this.SSHKeyDescription);
            this.SetParamSimple(map, prefix + "SSHKeyName", this.SSHKeyName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

