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

    public class SecuritySetting : AbstractModel
    {
        
        /// <summary>
        /// 国密认证方式设置
        /// </summary>
        [JsonProperty("AuthModeGM")]
        public AuthModeSetting AuthModeGM{ get; set; }

        /// <summary>
        /// 资产重连次数
        /// </summary>
        [JsonProperty("Reconnection")]
        public ReconnectionSetting Reconnection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AuthModeGM.", this.AuthModeGM);
            this.SetParamObj(map, prefix + "Reconnection.", this.Reconnection);
        }
    }
}

