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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWSimpleSecretKey : AbstractModel
    {
        
        /// <summary>
        /// <p>密钥ID</p>
        /// </summary>
        [JsonProperty("SecretKeyId")]
        public string SecretKeyId{ get; set; }

        /// <summary>
        /// <p>密钥名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>启用状态</p><p>枚举值：</p><ul><li>Enable： 启动</li><li>Disable： 禁用</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>密钥类型</p><p>枚举值：</p><ul><li>ApiKey： ApiKey类型</li></ul>
        /// </summary>
        [JsonProperty("SecretType")]
        public string SecretType{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>参数格式：2026-09-03 14:11:05</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretKeyId", this.SecretKeyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

