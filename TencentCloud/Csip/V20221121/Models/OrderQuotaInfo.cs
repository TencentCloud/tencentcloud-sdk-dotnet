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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrderQuotaInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>配额键</p>
        /// </summary>
        [JsonProperty("QuotaKey")]
        public string QuotaKey{ get; set; }

        /// <summary>
        /// <p>配额总量</p>
        /// </summary>
        [JsonProperty("QuotaNum")]
        public long? QuotaNum{ get; set; }

        /// <summary>
        /// <p>配额已使用量（含共享给其他账号的消耗）。仅请求参数 NeedQuotaUsed 为 true 时采集；未传或为 false 时恒为 0；用量查询失败时恒为 0，错误提示见响应 QuotaUsedError 字段</p>
        /// </summary>
        [JsonProperty("QuotaUsed")]
        public long? QuotaUsed{ get; set; }

        /// <summary>
        /// <p>赠送配额。仅 CSPM 存在赠送额度，其余计费项为 0</p>
        /// </summary>
        [JsonProperty("QuotaGranted")]
        public long? QuotaGranted{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QuotaKey", this.QuotaKey);
            this.SetParamSimple(map, prefix + "QuotaNum", this.QuotaNum);
            this.SetParamSimple(map, prefix + "QuotaUsed", this.QuotaUsed);
            this.SetParamSimple(map, prefix + "QuotaGranted", this.QuotaGranted);
        }
    }
}

