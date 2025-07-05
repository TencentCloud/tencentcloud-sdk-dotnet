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

    public class QueryCloudChannelDataResponse : AbstractModel
    {
        
        /// <summary>
        /// 外部订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutOrderNo")]
        public string OutOrderNo{ get; set; }

        /// <summary>
        /// 渠道订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 第三方渠道数据类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalChannelDataType")]
        public string ExternalChannelDataType{ get; set; }

        /// <summary>
        /// 渠道名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 第三方渠道数据列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalChannelDataList")]
        public CloudExternalChannelData[] ExternalChannelDataList{ get; set; }

        /// <summary>
        /// 子应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 米大师分配的支付主MidasAppId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

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
            this.SetParamSimple(map, prefix + "OutOrderNo", this.OutOrderNo);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "ExternalChannelDataType", this.ExternalChannelDataType);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamArrayObj(map, prefix + "ExternalChannelDataList.", this.ExternalChannelDataList);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

