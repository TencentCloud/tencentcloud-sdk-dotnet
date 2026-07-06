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

    public class DescribeSkillDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// skillID
        /// </summary>
        [JsonProperty("SkillId")]
        public string SkillId{ get; set; }

        /// <summary>
        /// 空间ID
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// 版本过滤条件(多个Filter之间为AND关系,同一Filter的多个Values为OR关系): - Perspective: 视角枚举,字符串单值,Values 长度必须为 1,多值视为非法;仅作用于详情返回的 version_list 裁剪,不决定接口本身可见性;不传默认 USER (USER=使用者视角,version_list 仅返回已上线版本 / EDITOR=编辑者视角,version_list 返回全部存活版本 / ALL=全量视角,同 EDITOR)
        /// </summary>
        [JsonProperty("VersionFilterList")]
        public Filter[] VersionFilterList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkillId", this.SkillId);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamArrayObj(map, prefix + "VersionFilterList.", this.VersionFilterList);
        }
    }
}

