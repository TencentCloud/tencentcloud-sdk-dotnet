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

    public class DescribeCreditResultResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>呼叫结果，取值范围：</p><ul style="margin-bottom:0px;"><li>NON：接通</li><li>DBU：号码忙</li><li>DRF：不在服务区</li><li>ANA：欠费未接听</li><li>REJ：拒接</li><li>SHU：关机</li><li>NAN：空号</li><li>HAL：停机</li><li>DAD：未接听</li><li>EXE：其他异常</li></ul>
        /// </summary>
        [JsonProperty("ResultCode")]
        public string ResultCode{ get; set; }

        /// <summary>
        /// 客户标识代码，多个标识码以英文逗号分隔，ResultCode为NON时才有。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientCode")]
        public string ClientCode{ get; set; }

        /// <summary>
        /// 开始振铃时间，ResultCode为NON或DAD时才有此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RingStartTime")]
        public string RingStartTime{ get; set; }

        /// <summary>
        /// 振铃时长
        /// </summary>
        [JsonProperty("RingDuration")]
        public long? RingDuration{ get; set; }

        /// <summary>
        /// 接通时长
        /// </summary>
        [JsonProperty("AnswerDuration")]
        public long? AnswerDuration{ get; set; }

        /// <summary>
        /// JSON格式的扩展信息字段，ResultCode为NON时才有。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContextValue")]
        public string ContextValue{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
            this.SetParamSimple(map, prefix + "ClientCode", this.ClientCode);
            this.SetParamSimple(map, prefix + "RingStartTime", this.RingStartTime);
            this.SetParamSimple(map, prefix + "RingDuration", this.RingDuration);
            this.SetParamSimple(map, prefix + "AnswerDuration", this.AnswerDuration);
            this.SetParamSimple(map, prefix + "ContextValue", this.ContextValue);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

