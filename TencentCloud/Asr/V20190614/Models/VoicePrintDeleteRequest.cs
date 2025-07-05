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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VoicePrintDeleteRequest : AbstractModel
    {
        
        /// <summary>
        /// 说话人id，说话人唯一标识
        /// </summary>
        [JsonProperty("VoicePrintId")]
        public string VoicePrintId{ get; set; }

        /// <summary>
        /// 说话人分组ID,仅支持大小写字母和下划线的组合，不超过128个字符
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 删除模式: 
        /// 0.默认值，删除该条声纹
        /// 1.从分组中删除该条声纹，声纹本身不删除
        /// 2.从声纹库中删除分组，仅删除分组信息，不会真正删除分组中的声纹
        /// </summary>
        [JsonProperty("DelMod")]
        public long? DelMod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VoicePrintId", this.VoicePrintId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "DelMod", this.DelMod);
        }
    }
}

