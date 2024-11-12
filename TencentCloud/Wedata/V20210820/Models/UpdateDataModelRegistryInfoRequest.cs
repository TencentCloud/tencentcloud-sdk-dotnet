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
        /// 数语的ip
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 数语的端口
        /// </summary>
        [JsonProperty("Vport")]
        public ulong? Vport{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CloudappId", this.CloudappId);
            this.SetParamSimple(map, prefix + "AppCamRole", this.AppCamRole);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "AppCamRoleId", this.AppCamRoleId);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "OwnId", this.OwnId);
        }
    }
}

