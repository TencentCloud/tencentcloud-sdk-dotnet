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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpeakerRoleInfo : AbstractModel
    {
        
        /// <summary>
        /// 音频url地址，建议不超过30秒，最大45秒
        /// </summary>
        [JsonProperty("RoleAudioUrl")]
        public string RoleAudioUrl{ get; set; }

        /// <summary>
        /// 不超过30字节
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleAudioUrl", this.RoleAudioUrl);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
        }
    }
}

