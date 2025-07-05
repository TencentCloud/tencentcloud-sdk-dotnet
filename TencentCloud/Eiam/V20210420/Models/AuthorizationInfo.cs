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

namespace TencentCloud.Eiam.V20210420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthorizationInfo : AbstractModel
    {
        
        /// <summary>
        /// 应用唯一ID。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 类型名称。
        /// </summary>
        [JsonProperty("EntityName")]
        public string EntityName{ get; set; }

        /// <summary>
        /// 类型唯一ID。
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// 上次更新时间，符合 ISO8601 标准。
        /// </summary>
        [JsonProperty("LastModifiedDate")]
        public string LastModifiedDate{ get; set; }

        /// <summary>
        /// 授权类型唯一ID。
        /// </summary>
        [JsonProperty("AuthorizationId")]
        public string AuthorizationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "EntityName", this.EntityName);
            this.SetParamSimple(map, prefix + "EntityId", this.EntityId);
            this.SetParamSimple(map, prefix + "LastModifiedDate", this.LastModifiedDate);
            this.SetParamSimple(map, prefix + "AuthorizationId", this.AuthorizationId);
        }
    }
}

