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

    public class AppShareAccessControl : AbstractModel
    {
        
        /// <summary>
        /// 访问控制类型。枚举值: 1:公开访问(所有用户都可访问), 2:内部访问(仅企业用户可访问), 3:账号白名单(指定UIN/手机/邮箱/IP可访问)
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// 体验链接开关
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 白名单(仅 access_type=ACCOUNT_WHITELIST 时生效)
        /// </summary>
        [JsonProperty("Whitelist")]
        public AppShareWhitelistItem[] Whitelist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArrayObj(map, prefix + "Whitelist.", this.Whitelist);
        }
    }
}

