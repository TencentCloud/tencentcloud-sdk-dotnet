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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateMountLimitRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据源类型英文名
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 存储实例ID
        /// </summary>
        [JsonProperty("StorageId")]
        public string StorageId{ get; set; }

        /// <summary>
        /// 限制开关是否开启，只有开启时才有限制，默认关闭
        /// </summary>
        [JsonProperty("LimitMount")]
        public bool? LimitMount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "StorageId", this.StorageId);
            this.SetParamSimple(map, prefix + "LimitMount", this.LimitMount);
        }
    }
}

