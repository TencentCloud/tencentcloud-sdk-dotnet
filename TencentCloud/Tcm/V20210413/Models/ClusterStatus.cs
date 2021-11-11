/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterStatus : AbstractModel
    {
        
        /// <summary>
        /// 关联状态，取值范围：
        /// - LINKING: 关联中
        /// - LINKED: 已关联
        /// - UNLINKING: 解关联中
        /// - LINK_FAILED: 关联失败
        /// - UNLINK_FAILED: 解关联失败
        /// </summary>
        [JsonProperty("LinkState")]
        public string LinkState{ get; set; }

        /// <summary>
        /// 关联错误详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkErrorDetail")]
        public string LinkErrorDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LinkState", this.LinkState);
            this.SetParamSimple(map, prefix + "LinkErrorDetail", this.LinkErrorDetail);
        }
    }
}

