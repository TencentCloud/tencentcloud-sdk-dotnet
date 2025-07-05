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

    public class UpdateCCCSkillGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 技能组ID
        /// </summary>
        [JsonProperty("SkillGroupID")]
        public long? SkillGroupID{ get; set; }

        /// <summary>
        /// 修改后的技能组名字
        /// </summary>
        [JsonProperty("SkillGroupName")]
        public string SkillGroupName{ get; set; }

        /// <summary>
        /// 修改后的最大并发数,同振最大为2
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }

        /// <summary>
        /// true同振，false顺振
        /// </summary>
        [JsonProperty("RingAll")]
        public bool? RingAll{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "SkillGroupID", this.SkillGroupID);
            this.SetParamSimple(map, prefix + "SkillGroupName", this.SkillGroupName);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "RingAll", this.RingAll);
        }
    }
}

