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

    public class DeleteTargetGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否预览此次请求。
        /// - **false**（默认）：发送普通请求，直接删除目标组。
        /// - **true**：发送预览请求，检查删除目标组的参数、格式、业务限制等是否符合要求。
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// 目标组 ID 列表，ID 格式为 lbtg- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("TargetGroupIds")]
        public string[] TargetGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamArraySimple(map, prefix + "TargetGroupIds.", this.TargetGroupIds);
        }
    }
}

