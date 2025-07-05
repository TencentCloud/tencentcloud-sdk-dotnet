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

namespace TencentCloud.Bma.V20221115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceData : AbstractModel
    {
        
        /// <summary>
        /// 网站保护关联资产数
        /// </summary>
        [JsonProperty("ProtectURLCount")]
        public long? ProtectURLCount{ get; set; }

        /// <summary>
        /// 网站保护服务到期时间
        /// </summary>
        [JsonProperty("ProtectURLExpireTime")]
        public string ProtectURLExpireTime{ get; set; }

        /// <summary>
        /// 应用保护关联资产数
        /// </summary>
        [JsonProperty("ProtectAPPCount")]
        public long? ProtectAPPCount{ get; set; }

        /// <summary>
        /// 应用保护服务到期时间
        /// </summary>
        [JsonProperty("ProtectAPPExpireTime")]
        public string ProtectAPPExpireTime{ get; set; }

        /// <summary>
        /// 公众号保护关联资产数
        /// </summary>
        [JsonProperty("ProtectOfficialAccountCount")]
        public long? ProtectOfficialAccountCount{ get; set; }

        /// <summary>
        /// 公众号保护服务到期时间
        /// </summary>
        [JsonProperty("ProtectOfficialAccountExpireTime")]
        public string ProtectOfficialAccountExpireTime{ get; set; }

        /// <summary>
        /// 小程序保护关联资产数
        /// </summary>
        [JsonProperty("ProtectMiniProgramCount")]
        public long? ProtectMiniProgramCount{ get; set; }

        /// <summary>
        /// 小程序保护服务到期时间
        /// </summary>
        [JsonProperty("ProtectMiniProgramExpireTime")]
        public string ProtectMiniProgramExpireTime{ get; set; }

        /// <summary>
        /// 关停下架使用次数
        /// </summary>
        [JsonProperty("OfflineCount")]
        public long? OfflineCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectURLCount", this.ProtectURLCount);
            this.SetParamSimple(map, prefix + "ProtectURLExpireTime", this.ProtectURLExpireTime);
            this.SetParamSimple(map, prefix + "ProtectAPPCount", this.ProtectAPPCount);
            this.SetParamSimple(map, prefix + "ProtectAPPExpireTime", this.ProtectAPPExpireTime);
            this.SetParamSimple(map, prefix + "ProtectOfficialAccountCount", this.ProtectOfficialAccountCount);
            this.SetParamSimple(map, prefix + "ProtectOfficialAccountExpireTime", this.ProtectOfficialAccountExpireTime);
            this.SetParamSimple(map, prefix + "ProtectMiniProgramCount", this.ProtectMiniProgramCount);
            this.SetParamSimple(map, prefix + "ProtectMiniProgramExpireTime", this.ProtectMiniProgramExpireTime);
            this.SetParamSimple(map, prefix + "OfflineCount", this.OfflineCount);
        }
    }
}

