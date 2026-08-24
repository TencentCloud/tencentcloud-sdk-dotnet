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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDrillGroupAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 要修改属性的容灾演练组id。
        /// </summary>
        [JsonProperty("DrillGroupId")]
        public string DrillGroupId{ get; set; }

        /// <summary>
        /// 修改容灾演练组名称（长度最大支持 64 个字符）
        /// </summary>
        [JsonProperty("DrillGroupName")]
        public string DrillGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrillGroupId", this.DrillGroupId);
            this.SetParamSimple(map, prefix + "DrillGroupName", this.DrillGroupName);
        }
    }
}

