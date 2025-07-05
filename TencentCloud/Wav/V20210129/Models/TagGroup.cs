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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TagGroup : AbstractModel
    {
        
        /// <summary>
        /// 企微标签组id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 标签组业务id
        /// </summary>
        [JsonProperty("BizGroupId")]
        public string BizGroupId{ get; set; }

        /// <summary>
        /// 企微标签组名称，不能超过15个字符
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 标签组次序值。sort值大的排序靠前。有效的值范围是[0, 2^32)
        /// </summary>
        [JsonProperty("Sort")]
        public ulong? Sort{ get; set; }

        /// <summary>
        /// 标签组创建时间,单位为秒
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 标签组内的标签列表, 上限为20
        /// </summary>
        [JsonProperty("Tags")]
        public TagDetailInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "BizGroupId", this.BizGroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

