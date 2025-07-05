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

    public class ForwardingTarget : AbstractModel
    {
        
        /// <summary>
        /// 呼转目标类型 1 座席 2 技能组 3 分机
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 呼转目标为座席的账号 Type 为 1 时填写
        /// </summary>
        [JsonProperty("StaffUserId")]
        public string StaffUserId{ get; set; }

        /// <summary>
        /// 呼转目标为技能组的 ID，Type 为 2 时填写
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// 呼转目标为分机的账号，Type 为 3 时填写
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "StaffUserId", this.StaffUserId);
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "Extension", this.Extension);
        }
    }
}

