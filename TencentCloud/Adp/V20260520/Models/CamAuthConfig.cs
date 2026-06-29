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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CamAuthConfig : AbstractModel
    {
        
        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 密钥位置 HEADER/QUERY
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 头鉴权 |
        /// | 1 | 请求信息鉴权 |
        /// </summary>
        [JsonProperty("KeyLocation")]
        public long? KeyLocation{ get; set; }

        /// <summary>
        /// SecretId字段名称
        /// </summary>
        [JsonProperty("SecretIdName")]
        public string SecretIdName{ get; set; }

        /// <summary>
        /// SecretKey字段名称
        /// </summary>
        [JsonProperty("SecretKeyName")]
        public string SecretKeyName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "KeyLocation", this.KeyLocation);
            this.SetParamSimple(map, prefix + "SecretIdName", this.SecretIdName);
            this.SetParamSimple(map, prefix + "SecretKeyName", this.SecretKeyName);
        }
    }
}

