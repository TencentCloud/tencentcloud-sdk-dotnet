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

namespace TencentCloud.Npp.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VirturalNumCdr : AbstractModel
    {
        
        /// <summary>
        /// 呼叫通话 ID
        /// </summary>
        [JsonProperty("CallId")]
        public string CallId{ get; set; }

        /// <summary>
        /// 双方号码 + 中间号绑定 ID，该 ID 全局唯一
        /// </summary>
        [JsonProperty("BindId")]
        public string BindId{ get; set; }

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
        /// 主叫通讯录直拨虚拟保护号码
        /// </summary>
        [JsonProperty("DstVirtualNum")]
        public string DstVirtualNum{ get; set; }

        /// <summary>
        /// 虚拟保护号码平台收到呼叫时间
        /// </summary>
        [JsonProperty("CallCenterAcceptTime")]
        public string CallCenterAcceptTime{ get; set; }

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
        /// 通话最后状态：0：未知状态 1：正常通话 2：查询呼叫转移被叫号异常 3：未接通 4：未接听 5：拒接挂断 6：关机 7：空号 8：通话中 9：欠费 10：运营商线路或平台异常
        /// </summary>
        [JsonProperty("CallEndStatus")]
        public string CallEndStatus{ get; set; }

        /// <summary>
        /// 主叫接通虚拟保护号码到通话结束通话时间
        /// </summary>
        [JsonProperty("SrcDuration")]
        public string SrcDuration{ get; set; }

        /// <summary>
        /// 呼叫转接被叫接通到通话结束通话时间
        /// </summary>
        [JsonProperty("DstDuration")]
        public string DstDuration{ get; set; }

        /// <summary>
        /// 录音 URL，如果不录音或录音失败，该值为空
        /// </summary>
        [JsonProperty("RecordUrl")]
        public string RecordUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallId", this.CallId);
            this.SetParamSimple(map, prefix + "BindId", this.BindId);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamSimple(map, prefix + "Dst", this.Dst);
            this.SetParamSimple(map, prefix + "DstVirtualNum", this.DstVirtualNum);
            this.SetParamSimple(map, prefix + "CallCenterAcceptTime", this.CallCenterAcceptTime);
            this.SetParamSimple(map, prefix + "StartDstCallTime", this.StartDstCallTime);
            this.SetParamSimple(map, prefix + "StartDstRingTime", this.StartDstRingTime);
            this.SetParamSimple(map, prefix + "DstAcceptTime", this.DstAcceptTime);
            this.SetParamSimple(map, prefix + "EndCallTime", this.EndCallTime);
            this.SetParamSimple(map, prefix + "CallEndStatus", this.CallEndStatus);
            this.SetParamSimple(map, prefix + "SrcDuration", this.SrcDuration);
            this.SetParamSimple(map, prefix + "DstDuration", this.DstDuration);
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
        }
    }
}

