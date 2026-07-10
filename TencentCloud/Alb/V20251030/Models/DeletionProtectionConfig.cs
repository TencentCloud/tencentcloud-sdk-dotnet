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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeletionProtectionConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否开启删除保护。开启后，可防止实例被意外删除。
        /// - true：开启删除保护
        /// - false：关闭删除保护
        /// </summary>
        [JsonProperty("DeletionProtectionEnabled")]
        public bool? DeletionProtectionEnabled{ get; set; }

        /// <summary>
        /// 开启修改保护的原因说明。
        /// 长度为 1~255 个字符，必须是中文和无害字符串中的字符， 可包含中文、字母、数字、短划线（-）、正斜线（/）、半角句号（.）、下划线（_）。
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeletionProtectionEnabled", this.DeletionProtectionEnabled);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

