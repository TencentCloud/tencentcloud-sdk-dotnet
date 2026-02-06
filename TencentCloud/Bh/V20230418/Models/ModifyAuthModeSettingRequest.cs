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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAuthModeSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// 双因子认证，0-不开启（暂停使用），1-OTP，2-短信，3-USB Key（只有ResourceType=1且AuthModeGM不传时有效，其他情况不能为3）    
        /// 备注：AuthMode和AuthModeGM至少有一个有效传参
        /// </summary>
        [JsonProperty("AuthMode")]
        public ulong? AuthMode{ get; set; }

        /// <summary>
        /// 国密双因子认证，0-不开启（暂停使用），1-OTP，2-短信，3-USB Key
        /// 备注：AuthMode和AuthModeGM至少有一个有效传参，AuthModeGM优先级高于ResourceType
        /// </summary>
        [JsonProperty("AuthModeGM")]
        public ulong? AuthModeGM{ get; set; }

        /// <summary>
        /// 资源类型，0：普通（暂停使用，由AuthMode和AuthModeGM传参决定） 1：国密
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthMode", this.AuthMode);
            this.SetParamSimple(map, prefix + "AuthModeGM", this.AuthModeGM);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
        }
    }
}

