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

namespace TencentCloud.Ic.V20190307.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResSms : AbstractModel
    {
        
        /// <summary>
        /// 卡片ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Iccid")]
        public string Iccid{ get; set; }

        /// <summary>
        /// 卡片号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Msisdn")]
        public string Msisdn{ get; set; }

        /// <summary>
        /// 应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SdkAppid")]
        public long? SdkAppid{ get; set; }

        /// <summary>
        /// 短信内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 短信类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmsType")]
        public long? SmsType{ get; set; }

        /// <summary>
        /// 发送时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SendTime")]
        public string SendTime{ get; set; }

        /// <summary>
        /// 推送时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReportTime")]
        public string ReportTime{ get; set; }

        /// <summary>
        /// SUCC：成功  FAIL 失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 回执状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Iccid", this.Iccid);
            this.SetParamSimple(map, prefix + "Msisdn", this.Msisdn);
            this.SetParamSimple(map, prefix + "SdkAppid", this.SdkAppid);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "SmsType", this.SmsType);
            this.SetParamSimple(map, prefix + "SendTime", this.SendTime);
            this.SetParamSimple(map, prefix + "ReportTime", this.ReportTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

