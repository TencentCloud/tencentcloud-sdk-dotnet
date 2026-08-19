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

    public class NotPassItemStatistic : AbstractModel
    {
        
        /// <summary>
        /// 策略类型。取值：SYSTEM（系统策略）、SELF（自定义策略）。
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 策略 ID。SYSTEM 策略为 0。
        /// </summary>
        [JsonProperty("PolicyID")]
        public ulong? PolicyID{ get; set; }

        /// <summary>
        /// 父分类 ID。SELF 策略为 0。
        /// </summary>
        [JsonProperty("ParentCategoryID")]
        public ulong? ParentCategoryID{ get; set; }

        /// <summary>
        /// 该策略下未通过的检测项数。
        /// </summary>
        [JsonProperty("NotPassCount")]
        public ulong? NotPassCount{ get; set; }

        /// <summary>
        /// 策略或分类名称。SYSTEM 取父分类名称，SELF 取策略名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyID", this.PolicyID);
            this.SetParamSimple(map, prefix + "ParentCategoryID", this.ParentCategoryID);
            this.SetParamSimple(map, prefix + "NotPassCount", this.NotPassCount);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

