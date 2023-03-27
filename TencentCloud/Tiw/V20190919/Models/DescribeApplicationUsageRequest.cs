/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApplicationUsageRequest : AbstractModel
    {
        
        /// <summary>
        /// 用量开始时间（包括该时间点）
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 用量结束时间（不包括该时间点）
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 白板子产品名
        /// </summary>
        [JsonProperty("SubProduct")]
        public string SubProduct{ get; set; }

        /// <summary>
        /// 时间跨度单位
        /// - MONTHLY：月
        /// - DAILY：天
        /// - MINUTELY：分钟
        /// </summary>
        [JsonProperty("TimeLevel")]
        public string TimeLevel{ get; set; }

        /// <summary>
        /// 白板应用的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// true: 返回加权求和后的用量数据
        /// false: 返回原始用量数据
        /// </summary>
        [JsonProperty("IsWeighted")]
        public bool? IsWeighted{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubProduct", this.SubProduct);
            this.SetParamSimple(map, prefix + "TimeLevel", this.TimeLevel);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "IsWeighted", this.IsWeighted);
        }
    }
}

