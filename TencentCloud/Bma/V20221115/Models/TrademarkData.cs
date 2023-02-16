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

namespace TencentCloud.Bma.V20221115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrademarkData : AbstractModel
    {
        
        /// <summary>
        /// 商标证明
        /// </summary>
        [JsonProperty("Trademark")]
        public string Trademark{ get; set; }

        /// <summary>
        /// 商标审核状态
        /// </summary>
        [JsonProperty("TrademarkStatus")]
        public long? TrademarkStatus{ get; set; }

        /// <summary>
        /// 商标审核状态说明
        /// </summary>
        [JsonProperty("TrademarkNote")]
        public string TrademarkNote{ get; set; }

        /// <summary>
        /// 商标id
        /// </summary>
        [JsonProperty("TrademarkId")]
        public long? TrademarkId{ get; set; }

        /// <summary>
        /// 商标转让书
        /// </summary>
        [JsonProperty("Transfer")]
        public string Transfer{ get; set; }

        /// <summary>
        /// 商标转让书审核状态
        /// </summary>
        [JsonProperty("TransferStatus")]
        public long? TransferStatus{ get; set; }

        /// <summary>
        /// 商标转让书审核状态说明
        /// </summary>
        [JsonProperty("TransferNote")]
        public string TransferNote{ get; set; }

        /// <summary>
        /// 商标名称
        /// </summary>
        [JsonProperty("TrademarkName")]
        public string TrademarkName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Trademark", this.Trademark);
            this.SetParamSimple(map, prefix + "TrademarkStatus", this.TrademarkStatus);
            this.SetParamSimple(map, prefix + "TrademarkNote", this.TrademarkNote);
            this.SetParamSimple(map, prefix + "TrademarkId", this.TrademarkId);
            this.SetParamSimple(map, prefix + "Transfer", this.Transfer);
            this.SetParamSimple(map, prefix + "TransferStatus", this.TransferStatus);
            this.SetParamSimple(map, prefix + "TransferNote", this.TransferNote);
            this.SetParamSimple(map, prefix + "TrademarkName", this.TrademarkName);
        }
    }
}

