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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateGroupWithSubGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 待创建的新群组名
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 低代码平台应用ID
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 子群组ID列表，子群组ID不能重复，最多40个
        /// </summary>
        [JsonProperty("SubGroupIds")]
        public string[] SubGroupIds{ get; set; }

        /// <summary>
        /// 群组默认主讲老师ID
        /// </summary>
        [JsonProperty("TeacherId")]
        public string TeacherId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamArraySimple(map, prefix + "SubGroupIds.", this.SubGroupIds);
            this.SetParamSimple(map, prefix + "TeacherId", this.TeacherId);
        }
    }
}

