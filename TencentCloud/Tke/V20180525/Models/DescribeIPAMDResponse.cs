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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIPAMDResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否安装了eniipamd组件
        /// </summary>
        [JsonProperty("EnableIPAMD")]
        public bool? EnableIPAMD{ get; set; }

        /// <summary>
        /// 是否开启自定义podcidr，默认为false，已安装eniipamd组件才意义
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableCustomizedPodCidr")]
        public bool? EnableCustomizedPodCidr{ get; set; }

        /// <summary>
        /// 是否不开启vpccni模式，默认为false，已安装eniipamd组件才意义
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisableVpcCniMode")]
        public bool? DisableVpcCniMode{ get; set; }

        /// <summary>
        /// 组件状态，已安装eniipamd组件才会有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Phase")]
        public string Phase{ get; set; }

        /// <summary>
        /// 错误信息，已安装eniipamd组件且状态为非running才会有错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 子网信息，已安装eniipamd组件才会有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 固定ip回收时间，已安装eniipamd组件才会有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClaimExpiredDuration")]
        public string ClaimExpiredDuration{ get; set; }

        /// <summary>
        /// 是否开启了中继网卡模式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableTrunkingENI")]
        public bool? EnableTrunkingENI{ get; set; }

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
            this.SetParamSimple(map, prefix + "EnableIPAMD", this.EnableIPAMD);
            this.SetParamSimple(map, prefix + "EnableCustomizedPodCidr", this.EnableCustomizedPodCidr);
            this.SetParamSimple(map, prefix + "DisableVpcCniMode", this.DisableVpcCniMode);
            this.SetParamSimple(map, prefix + "Phase", this.Phase);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "ClaimExpiredDuration", this.ClaimExpiredDuration);
            this.SetParamSimple(map, prefix + "EnableTrunkingENI", this.EnableTrunkingENI);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

