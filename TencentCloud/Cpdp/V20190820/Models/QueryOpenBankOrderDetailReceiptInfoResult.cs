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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryOpenBankOrderDetailReceiptInfoResult : AbstractModel
    {
        
        /// <summary>
        /// 渠道回单申请ID
        /// </summary>
        [JsonProperty("ChannelApplyId")]
        public string ChannelApplyId{ get; set; }

        /// <summary>
        /// 申请状态。
        /// SUCCESS：申请成功；
        /// FAILED：申请失败；
        /// PROCESSING：申请中。
        /// 注意：若返回申请中，需要再次调用回单申请结果查询接口，查询结果。
        /// </summary>
        [JsonProperty("ReceiptStatus")]
        public string ReceiptStatus{ get; set; }

        /// <summary>
        /// 申请返回描述，例如失败原因等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReceiptMessage")]
        public string ReceiptMessage{ get; set; }

        /// <summary>
        /// 回单下载链接，申请成功时返回。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string DownloadUrl{ get; set; }

        /// <summary>
        /// 过期时间，yyyy-MM-dd HH:mm:ss格式。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelApplyId", this.ChannelApplyId);
            this.SetParamSimple(map, prefix + "ReceiptStatus", this.ReceiptStatus);
            this.SetParamSimple(map, prefix + "ReceiptMessage", this.ReceiptMessage);
            this.SetParamSimple(map, prefix + "DownloadUrl", this.DownloadUrl);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
        }
    }
}

