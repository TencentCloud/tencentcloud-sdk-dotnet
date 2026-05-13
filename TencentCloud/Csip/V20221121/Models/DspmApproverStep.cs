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

    public class DspmApproverStep : AbstractModel
    {
        
        /// <summary>
        /// 审批人列表
        /// </summary>
        [JsonProperty("ApproverUinSet")]
        public DspmUinUser[] ApproverUinSet{ get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        [JsonProperty("ApproverUin")]
        public string ApproverUin{ get; set; }

        /// <summary>
        /// 审批状态  0-未审批 1-通过 2-拒绝
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 审批意见
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 审批时间。
        /// </summary>
        [JsonProperty("ApproveTime")]
        public string ApproveTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ApproverUinSet.", this.ApproverUinSet);
            this.SetParamSimple(map, prefix + "ApproverUin", this.ApproverUin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
        }
    }
}

