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

    public class DescribeModelResponseVO : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云AppID
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// 腾讯云Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 实例ID
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
        /// 凭据ID
        /// </summary>
        [JsonProperty("CredentialID")]
        public string CredentialID{ get; set; }

        /// <summary>
        /// 凭据名称
        /// </summary>
        [JsonProperty("CredentialName")]
        public string CredentialName{ get; set; }

        /// <summary>
        /// http协议类型
        /// </summary>
        [JsonProperty("HttpProtocolType")]
        public string HttpProtocolType{ get; set; }

        /// <summary>
        /// https时，是否校验目标证书
        /// </summary>
        [JsonProperty("CheckTargetCertsError")]
        public bool? CheckTargetCertsError{ get; set; }

        /// <summary>
        /// http协议版本：1.1/2.0
        /// </summary>
        [JsonProperty("HttpProtocolVersion")]
        public string HttpProtocolVersion{ get; set; }

        /// <summary>
        /// 目标路径
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// 目标器列表
        /// </summary>
        [JsonProperty("TargetHosts")]
        public TargetHostDTO[] TargetHosts{ get; set; }

        /// <summary>
        /// 被模型服务使用的个数
        /// </summary>
        [JsonProperty("ModelServiceCount")]
        public long? ModelServiceCount{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CredentialID", this.CredentialID);
            this.SetParamSimple(map, prefix + "CredentialName", this.CredentialName);
            this.SetParamSimple(map, prefix + "HttpProtocolType", this.HttpProtocolType);
            this.SetParamSimple(map, prefix + "CheckTargetCertsError", this.CheckTargetCertsError);
            this.SetParamSimple(map, prefix + "HttpProtocolVersion", this.HttpProtocolVersion);
            this.SetParamSimple(map, prefix + "TargetPath", this.TargetPath);
            this.SetParamArrayObj(map, prefix + "TargetHosts.", this.TargetHosts);
            this.SetParamSimple(map, prefix + "ModelServiceCount", this.ModelServiceCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
        }
    }
}

