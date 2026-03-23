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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyModelRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 模型ID
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 协议类型：http/https
        /// </summary>
        [JsonProperty("HttpProtocolType")]
        public string HttpProtocolType{ get; set; }

        /// <summary>
        /// 目标路径
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// 目标服务器
        /// </summary>
        [JsonProperty("TargetHosts")]
        public TargetHostDTO[] TargetHosts{ get; set; }

        /// <summary>
        /// 凭据ID
        /// </summary>
        [JsonProperty("CredentialID")]
        public string CredentialID{ get; set; }

        /// <summary>
        /// https时，是否检查证书合法
        /// </summary>
        [JsonProperty("CheckTargetCertsError")]
        public bool? CheckTargetCertsError{ get; set; }

        /// <summary>
        /// http协议版本：1.1/2.0
        /// </summary>
        [JsonProperty("HttpProtocolVersion")]
        public string HttpProtocolVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "HttpProtocolType", this.HttpProtocolType);
            this.SetParamSimple(map, prefix + "TargetPath", this.TargetPath);
            this.SetParamArrayObj(map, prefix + "TargetHosts.", this.TargetHosts);
            this.SetParamSimple(map, prefix + "CredentialID", this.CredentialID);
            this.SetParamSimple(map, prefix + "CheckTargetCertsError", this.CheckTargetCertsError);
            this.SetParamSimple(map, prefix + "HttpProtocolVersion", this.HttpProtocolVersion);
        }
    }
}

