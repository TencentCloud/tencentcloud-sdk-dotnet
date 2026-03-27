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

    public class CreateVmInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 服务器类型：
        /// LightHouse = 轻量云服务器
        /// CVM = 云服务器
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 轻量云服务器套餐ID。 当Type=LightHouse时必传
        /// </summary>
        [JsonProperty("LightHouseBundleId")]
        public string LightHouseBundleId{ get; set; }

        /// <summary>
        /// 轻量云服务器镜像ID。当Type=LightHouse时必传
        /// </summary>
        [JsonProperty("LightHouseBlueprintId")]
        public string LightHouseBlueprintId{ get; set; }

        /// <summary>
        /// 服务器别名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 登录方式
        /// </summary>
        [JsonProperty("LoginConfiguration")]
        public VMLoginConfiguration LoginConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "LightHouseBundleId", this.LightHouseBundleId);
            this.SetParamSimple(map, prefix + "LightHouseBlueprintId", this.LightHouseBlueprintId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "LoginConfiguration.", this.LoginConfiguration);
        }
    }
}

