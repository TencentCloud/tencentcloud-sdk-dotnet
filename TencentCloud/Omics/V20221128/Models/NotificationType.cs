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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NotificationType : AbstractModel
    {
        
        /// <summary>
        /// 腾讯健康组学平台站点信息。
        /// </summary>
        [JsonProperty("StationMessage")]
        public bool? StationMessage{ get; set; }

        /// <summary>
        /// 邮箱列表。
        /// </summary>
        [JsonProperty("Email")]
        public string[] Email{ get; set; }

        /// <summary>
        /// 当前用户邮箱。
        /// </summary>
        [JsonProperty("CurrentUserEmail")]
        public bool? CurrentUserEmail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StationMessage", this.StationMessage);
            this.SetParamArraySimple(map, prefix + "Email.", this.Email);
            this.SetParamSimple(map, prefix + "CurrentUserEmail", this.CurrentUserEmail);
        }
    }
}

