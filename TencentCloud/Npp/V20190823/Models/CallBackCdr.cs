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

namespace TencentCloud.Npp.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CallBackCdr : AbstractModel
    {
        
        /// <summary>
        /// 呼叫通话 ID
        /// </summary>
        [JsonProperty("CallId")]
        public string CallId{ get; set; }

        /// <summary>
        /// 主叫号码
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [JsonProperty("Dst")]
        public string Dst{ get; set; }

        /// <summary>
        /// 主叫呼叫开始时间
        /// </summary>
        [JsonProperty("StartSrcCallTime")]
        public string StartSrcCallTime{ get; set; }

        /// <summary>
        /// 主叫响铃开始时间
        /// </summary>
        [JsonProperty("StartSrcRingTime")]
        public string StartSrcRingTime{ get; set; }

        /// <summary>
        /// 主叫接听时间
        /// </summary>
        [JsonProperty("SrcAcceptTime")]
        public string SrcAcceptTime{ get; set; }

        /// <summary>
        /// 被叫呼叫开始时间
        /// </summary>
        [JsonProperty("StartDstCallTime")]
        public string StartDstCallTime{ get; set; }

        /// <summary>
        /// 被叫响铃开始时间
        /// </summary>
        [JsonProperty("StartDstRingTime")]
        public string StartDstRingTime{ get; set; }

        /// <summary>
        /// 被叫接听时间
        /// </summary>
        [JsonProperty("DstAcceptTime")]
        public string DstAcceptTime{ get; set; }

        /// <summary>
        /// 用户挂机通话结束时间
        /// </summary>
        [JsonProperty("EndCallTime")]
        public string EndCallTime{ get; set; }

        /// <summary>
        /// 通话最后状态：0：未知状态 1：正常通话 2：主叫未接 3：主叫接听，被叫未接 4：主叫未接通 5：被叫未接通
        /// </summary>
        [JsonProperty("CallEndStatus")]
        public string CallEndStatus{ get; set; }

        /// <summary>
        /// 通话计费时间
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// 录音 URL，如果不录音或录音失败，该值为空
        /// </summary>
        [JsonProperty("RecordUrl")]
        public string RecordUrl{ get; set; }

        /// <summary>
        /// 通话类型(1: VOIP 2:IP TO PSTN 3: PSTN TO PSTN)，如果话单中没有该字段，默认值为回拨 3 (PSTN TO PSTN)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallType")]
        public string CallType{ get; set; }

        /// <summary>
        /// 同回拨请求中的 bizId，如果回拨请求中带 bizId 会有该字段返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizId")]
        public string BizId{ get; set; }

        /// <summary>
        /// 订单 ID,最大长度不超过 64 个字节，对于一些有订单状态 App 相关应用（如达人帮接入 App 应用)，该字段只在帐单中带上，其它回调不附带该字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallId", this.CallId);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamSimple(map, prefix + "Dst", this.Dst);
            this.SetParamSimple(map, prefix + "StartSrcCallTime", this.StartSrcCallTime);
            this.SetParamSimple(map, prefix + "StartSrcRingTime", this.StartSrcRingTime);
            this.SetParamSimple(map, prefix + "SrcAcceptTime", this.SrcAcceptTime);
            this.SetParamSimple(map, prefix + "StartDstCallTime", this.StartDstCallTime);
            this.SetParamSimple(map, prefix + "StartDstRingTime", this.StartDstRingTime);
            this.SetParamSimple(map, prefix + "DstAcceptTime", this.DstAcceptTime);
            this.SetParamSimple(map, prefix + "EndCallTime", this.EndCallTime);
            this.SetParamSimple(map, prefix + "CallEndStatus", this.CallEndStatus);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
        }
    }
}

