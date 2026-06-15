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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TsfPageBusinessLogV2 : AbstractModel
    {
        
        /// <summary>
        /// <p>总条数</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>业务日志列表</p>
        /// </summary>
        [JsonProperty("Content")]
        public BusinessLogV2[] Content{ get; set; }

        /// <summary>
        /// <p>游标ID</p>
        /// </summary>
        [JsonProperty("ScrollId")]
        public string ScrollId{ get; set; }

        /// <summary>
        /// <p>查询状态，SUCCESS：查询成功完成，ERROR_RANGE_EXCEED：查询范围过大异常，ERROR_COMPLEX_CONDITION：查询条件复杂异常，ERROR_OTHER_CAUSE：其他异常</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>查询es时，使用searchAfter返回的游标</p>
        /// </summary>
        [JsonProperty("SearchAfter")]
        public string[] SearchAfter{ get; set; }

        /// <summary>
        /// <p>是否压缩</p>
        /// </summary>
        [JsonProperty("Compressed")]
        public bool? Compressed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "ScrollId", this.ScrollId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SearchAfter.", this.SearchAfter);
            this.SetParamSimple(map, prefix + "Compressed", this.Compressed);
        }
    }
}

