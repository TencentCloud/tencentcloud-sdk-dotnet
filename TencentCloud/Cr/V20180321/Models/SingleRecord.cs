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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SingleRecord : AbstractModel
    {
        
        /// <summary>
        /// 案件编号。
        /// </summary>
        [JsonProperty("AccountNum")]
        public string AccountNum{ get; set; }

        /// <summary>
        /// 外呼日期。
        /// </summary>
        [JsonProperty("BizDate")]
        public string BizDate{ get; set; }

        /// <summary>
        /// 开始呼叫时间。
        /// </summary>
        [JsonProperty("CallStartTime")]
        public string CallStartTime{ get; set; }

        /// <summary>
        /// 主叫号码。
        /// </summary>
        [JsonProperty("CallerPhone")]
        public string CallerPhone{ get; set; }

        /// <summary>
        /// 呼叫方向，O为呼出，I为呼入。
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 通话时长。
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 产品ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 录音下载链接。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordCosUrl")]
        public string RecordCosUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountNum", this.AccountNum);
            this.SetParamSimple(map, prefix + "BizDate", this.BizDate);
            this.SetParamSimple(map, prefix + "CallStartTime", this.CallStartTime);
            this.SetParamSimple(map, prefix + "CallerPhone", this.CallerPhone);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "RecordCosUrl", this.RecordCosUrl);
        }
    }
}

