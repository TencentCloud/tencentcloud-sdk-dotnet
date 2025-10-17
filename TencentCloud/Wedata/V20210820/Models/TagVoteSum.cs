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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TagVoteSum : AbstractModel
    {
        
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonProperty("TagId")]
        public long? TagId{ get; set; }

        /// <summary>
        /// 该表该标签投票次数
        /// </summary>
        [JsonProperty("VoteSum")]
        public long? VoteSum{ get; set; }

        /// <summary>
        /// 当前用户对这张表是否加了该标签 true 已添加 false 未添加
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [JsonProperty("TagName")]
        public string TagName{ get; set; }

        /// <summary>
        /// 标签描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagDesc")]
        public string TagDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagId", this.TagId);
            this.SetParamSimple(map, prefix + "VoteSum", this.VoteSum);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamSimple(map, prefix + "TagDesc", this.TagDesc);
        }
    }
}

