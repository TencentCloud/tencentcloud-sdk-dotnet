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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTelCdrRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间戳，Unix 时间戳
        /// </summary>
        [JsonProperty("StartTimeStamp")]
        public long? StartTimeStamp{ get; set; }

        /// <summary>
        /// 结束时间戳，Unix 时间戳
        /// </summary>
        [JsonProperty("EndTimeStamp")]
        public long? EndTimeStamp{ get; set; }

        /// <summary>
        /// 返回数据条数，上限（deprecated）
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移（deprecated）
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 实例 ID（deprecated）
        /// </summary>
        [JsonProperty("InstanceId")]
        public long? InstanceId{ get; set; }

        /// <summary>
        /// 应用 ID
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 分页尺寸，上限 100
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 分页页码，从 0 开始
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeStamp", this.StartTimeStamp);
            this.SetParamSimple(map, prefix + "EndTimeStamp", this.EndTimeStamp);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
        }
    }
}

