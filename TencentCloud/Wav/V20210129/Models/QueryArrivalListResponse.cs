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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryArrivalListResponse : AbstractModel
    {
        
        /// <summary>
        /// 分页游标，下次调用带上该值，则从当前的位置继续往后拉，以实现增量拉取。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextCursor")]
        public string NextCursor{ get; set; }

        /// <summary>
        /// 潜客客户存档信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageData")]
        public ArrivalInfo[] PageData{ get; set; }

        /// <summary>
        /// 是否还有更多数据。0-否；1-是。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasMore")]
        public ulong? HasMore{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NextCursor", this.NextCursor);
            this.SetParamArrayObj(map, prefix + "PageData.", this.PageData);
            this.SetParamSimple(map, prefix + "HasMore", this.HasMore);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

