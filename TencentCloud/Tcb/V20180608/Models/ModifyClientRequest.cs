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

    public class ModifyClientRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户端所属的云开发环境 ID，用于标识该应用归属的云开发环境。不同环境之间的应用数据相互隔离。
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 需要修改的客户端唯一标识符（Client ID），在 OAuth/OIDC 授权流程中作为 client_id 参数使用。该字段为定位参数，仅用于指定目标客户端，不可修改。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Refresh Token 的有效期，单位为秒。超过该时间后 Refresh Token 将失效，用户需重新登录。取值范围：1800~2592000（即 30 分钟至 30 天），超出上限将被截断为 2592000。默认值为 2592000（即 30 天）。注意：当该值 ≤ 7200 时，AccessTokenExpiresIn 将被自动设为该值减去 660 秒。
        /// </summary>
        [JsonProperty("RefreshTokenExpiresIn")]
        public long? RefreshTokenExpiresIn{ get; set; }

        /// <summary>
        /// 单个用户在该应用下允许同时登录的最大会话数量。取值范围：-1~50。特殊值说明：-1 表示不限制设备数；0 表示按客户端 User-Agent 区分设备（相同 User-Agent 视为同一设备）；1~50 为精确的最大会话数限制，超出限制后最早登录的会话将被自动踢出。不传则保持原有配置不变。
        /// </summary>
        [JsonProperty("MaxDevice")]
        public long? MaxDevice{ get; set; }

        /// <summary>
        /// Access Token 的有效期，单位为秒。超过该时间后 Access Token 将失效，需使用 Refresh Token 重新换取。最小有效值为 1800 秒（小于 1800 将被忽略，使用默认值），默认值为 7200（即 2 小时）。该值应小于 RefreshTokenExpiresIn。
        /// </summary>
        [JsonProperty("AccessTokenExpiresIn")]
        public long? AccessTokenExpiresIn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RefreshTokenExpiresIn", this.RefreshTokenExpiresIn);
            this.SetParamSimple(map, prefix + "MaxDevice", this.MaxDevice);
            this.SetParamSimple(map, prefix + "AccessTokenExpiresIn", this.AccessTokenExpiresIn);
        }
    }
}

