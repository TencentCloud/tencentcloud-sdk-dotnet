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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnbindStaffSkillGroupListRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [JsonProperty("StaffEmail")]
        public string StaffEmail{ get; set; }

        /// <summary>
        /// 解绑技能组列表
        /// </summary>
        [JsonProperty("SkillGroupList")]
        public long?[] SkillGroupList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "StaffEmail", this.StaffEmail);
            this.SetParamArraySimple(map, prefix + "SkillGroupList.", this.SkillGroupList);
        }
    }
}

