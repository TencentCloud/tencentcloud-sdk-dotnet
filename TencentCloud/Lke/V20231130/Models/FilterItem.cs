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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FilterItem : AbstractModel
    {
        
        /// <summary>
        /// 筛选内容。
        /// 例如筛选审核状态可以使用"AuditStatus"
        /// </summary>
        [JsonProperty("FilterKey")]
        public string FilterKey{ get; set; }

        /// <summary>
        /// 筛选条件。
        /// 例如对于筛选内容"AuditStatus"，可使用筛选条件:
        /// "ContentFailed":"内容审核失败",
        /// "PictureFailed":"图片审核失败",
        /// "ContentAndPictureFailed":"图片和内容审核失败",
        /// </summary>
        [JsonProperty("FilterValue")]
        public string[] FilterValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FilterKey", this.FilterKey);
            this.SetParamArraySimple(map, prefix + "FilterValue.", this.FilterValue);
        }
    }
}

