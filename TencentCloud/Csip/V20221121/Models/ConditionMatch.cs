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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConditionMatch : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像ID匹配串（三选一，有且仅有一个非空）</p>
        /// </summary>
        [JsonProperty("ImageIDMatchString")]
        public string ImageIDMatchString{ get; set; }

        /// <summary>
        /// <p>镜像名匹配串（三选一，有且仅有一个非空）</p>
        /// </summary>
        [JsonProperty("ImageNameMatchString")]
        public string ImageNameMatchString{ get; set; }

        /// <summary>
        /// <p>镜像地址匹配串（三选一，有且仅有一个非空）</p>
        /// </summary>
        [JsonProperty("ImageAddressMatchString")]
        public string ImageAddressMatchString{ get; set; }

        /// <summary>
        /// <p>匹配条件，取值：EQUALS-等于/NOT_EQUALS-不等于/STARTS_WITH-以…开头/NOT_STARTS_WITH-不以…开头/ENDS_WITH-以…结尾/NOT_ENDS_WITH-不以…结尾/CONTAINS-包含/NOT_CONTAINS-不包含</p>
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageIDMatchString", this.ImageIDMatchString);
            this.SetParamSimple(map, prefix + "ImageNameMatchString", this.ImageNameMatchString);
            this.SetParamSimple(map, prefix + "ImageAddressMatchString", this.ImageAddressMatchString);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
        }
    }
}

