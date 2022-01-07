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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetWeChatBillDetailsResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否还有下一页。该字段为true时，需要将NextCursor的值作为入参Cursor继续调用本接口。
        /// </summary>
        [JsonProperty("HasNextPage")]
        public bool? HasNextPage{ get; set; }

        /// <summary>
        /// 下一页的游标。用于分页。
        /// </summary>
        [JsonProperty("NextCursor")]
        public ulong? NextCursor{ get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        [JsonProperty("WeChatBillDetails")]
        public WeChatBillDetail[] WeChatBillDetails{ get; set; }

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
            this.SetParamSimple(map, prefix + "HasNextPage", this.HasNextPage);
            this.SetParamSimple(map, prefix + "NextCursor", this.NextCursor);
            this.SetParamArrayObj(map, prefix + "WeChatBillDetails.", this.WeChatBillDetails);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

