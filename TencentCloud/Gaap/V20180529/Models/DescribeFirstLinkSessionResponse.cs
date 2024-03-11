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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFirstLinkSessionResponse : AbstractModel
    {
        
        /// <summary>
        /// 会话状态，具体如下：
        /// 1： 加速中；
        /// 0： 非加速中。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 剩余加速时间，单位秒。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 加速套餐类型。
        /// 套餐说明如下：
        /// T100K：上/下行保障100kbps；
        /// BD4M：下行带宽保障4Mbps；
        /// BU4M：上行带宽保障4Mbps。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuiteType")]
        public string SuiteType{ get; set; }

        /// <summary>
        /// 加速终端的公网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcPublicIpv4")]
        public string SrcPublicIpv4{ get; set; }

        /// <summary>
        /// 加速目标ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DestIpv4")]
        public string[] DestIpv4{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "SuiteType", this.SuiteType);
            this.SetParamSimple(map, prefix + "SrcPublicIpv4", this.SrcPublicIpv4);
            this.SetParamArraySimple(map, prefix + "DestIpv4.", this.DestIpv4);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

