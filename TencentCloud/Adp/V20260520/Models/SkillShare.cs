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

    public class SkillShare : AbstractModel
    {
        
        /// <summary>
        /// 审批ID
        /// </summary>
        [JsonProperty("ApprovalId")]
        public string ApprovalId{ get; set; }

        /// <summary>
        /// 共享后关联的新 skill_id
        /// </summary>
        [JsonProperty("ShareSkillId")]
        public string ShareSkillId{ get; set; }

        /// <summary>
        /// 共享版本，如 1.0.0
        /// </summary>
        [JsonProperty("ShareVersion")]
        public string ShareVersion{ get; set; }

        /// <summary>
        /// 共享版本ID
        /// </summary>
        [JsonProperty("ShareVersionId")]
        public string ShareVersionId{ get; set; }

        /// <summary>
        /// 原 skill_id
        /// </summary>
        [JsonProperty("SkillId")]
        public string SkillId{ get; set; }

        /// <summary>
        /// 共享状态
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 未共享 |
        /// | 1 | 已共享 |
        /// | 2 | 审批中 |
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApprovalId", this.ApprovalId);
            this.SetParamSimple(map, prefix + "ShareSkillId", this.ShareSkillId);
            this.SetParamSimple(map, prefix + "ShareVersion", this.ShareVersion);
            this.SetParamSimple(map, prefix + "ShareVersionId", this.ShareVersionId);
            this.SetParamSimple(map, prefix + "SkillId", this.SkillId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

