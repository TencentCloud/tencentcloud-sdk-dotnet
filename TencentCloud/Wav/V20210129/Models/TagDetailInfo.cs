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

    public class TagDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("TagName")]
        public string TagName{ get; set; }

        /// <summary>
        /// 标签业务ID
        /// </summary>
        [JsonProperty("BizTagId")]
        public string BizTagId{ get; set; }

        /// <summary>
        /// 企微标签ID
        /// </summary>
        [JsonProperty("TagId")]
        public string TagId{ get; set; }

        /// <summary>
        /// 标签排序的次序值，sort值大的排序靠前。有效的值范围是[0, 2^32)
        /// </summary>
        [JsonProperty("Sort")]
        public ulong? Sort{ get; set; }

        /// <summary>
        /// 标签创建时间,单位为秒
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamSimple(map, prefix + "BizTagId", this.BizTagId);
            this.SetParamSimple(map, prefix + "TagId", this.TagId);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

