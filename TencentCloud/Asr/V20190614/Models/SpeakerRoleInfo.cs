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
        /// <p>音频url地址，建议不超过30秒，最大45秒（配合RoleName字段一起使用，仅限16k_zh_en、16k_zh_en_2.0引擎）</p>
        /// </summary>
        [JsonProperty("RoleAudioUrl")]
        public string RoleAudioUrl{ get; set; }

        /// <summary>
        /// <p>不超过30字节（配合RoleAudioUrl字段一起使用，仅限16k_zh_en、16k_zh_en_2.0引擎）</p>
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// <p>声纹 ID（与SpeakerNick配合使用，仅限16k_zh_en_meeting引擎支持），注意：- 传入未注册或不属于本 AppId 的声纹 ID，该 ID 会被跳过（不报错，相当于没有传入这个说话人信息）</p>
        /// </summary>
        [JsonProperty("VoicePrintId")]
        public string VoicePrintId{ get; set; }

        /// <summary>
        /// <p>角色昵称（与VoicePrintId配合使用，仅限16k_zh_en_meeting引擎支持），注意：- 传空字符串或者不传入则使用声纹注册时指定的角色名- 否则将覆盖声纹注册时指定的角色名- 角色名不超过 30 字节，仅支持字母、数字、下划线和中文。- 这里指定的角色名只影响本次识别，不影响声纹库中注册的角色名</p>
        /// </summary>
        [JsonProperty("SpeakerNick")]
        public string SpeakerNick{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleAudioUrl", this.RoleAudioUrl);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "VoicePrintId", this.VoicePrintId);
            this.SetParamSimple(map, prefix + "SpeakerNick", this.SpeakerNick);
        }
    }
}

