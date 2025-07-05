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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateDataModelRegistryInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 云应用的实例id
        /// </summary>
        [JsonProperty("CloudappId")]
        public string CloudappId{ get; set; }

        /// <summary>
        /// 数语的CAM角色
        /// </summary>
        [JsonProperty("AppCamRole")]
        public string AppCamRole{ get; set; }

        /// <summary>
        /// 数语的公网访问ip
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 数语的公网访问端口
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 数语的CAM角色id
        /// </summary>
        [JsonProperty("AppCamRoleId")]
        public string AppCamRoleId{ get; set; }

        /// <summary>
        /// 服务提供方
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// 主账号id
        /// </summary>
        [JsonProperty("OwnId")]
        public string OwnId{ get; set; }

        /// <summary>
        /// VpcId
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Vpc地域
        /// </summary>
        [JsonProperty("VpcRegion")]
        public string VpcRegion{ get; set; }

        /// <summary>
        /// 数语的内网访问ip
        /// </summary>
        [JsonProperty("Pip")]
        public string Pip{ get; set; }

        /// <summary>
        /// 数语的内网访问端口
        /// </summary>
        [JsonProperty("Pport")]
        public ulong? Pport{ get; set; }

        /// <summary>
        /// 是否开放公网访问数语, 1:是，0:否，默认1开放
        /// </summary>
        [JsonProperty("IsPublic")]
        public ulong? IsPublic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CloudappId", this.CloudappId);
            this.SetParamSimple(map, prefix + "AppCamRole", this.AppCamRole);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "AppCamRoleId", this.AppCamRoleId);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "OwnId", this.OwnId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcRegion", this.VpcRegion);
            this.SetParamSimple(map, prefix + "Pip", this.Pip);
            this.SetParamSimple(map, prefix + "Pport", this.Pport);
            this.SetParamSimple(map, prefix + "IsPublic", this.IsPublic);
        }
    }
}

