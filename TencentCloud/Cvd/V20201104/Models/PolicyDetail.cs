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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>策略id</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>策略名称</p>
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// <p>策略描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>策略作用用户id列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// <p>策略的租户uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>文件重定向策略id。取值范围：<br>1：读写<br>2：只读<br>3：禁止读写</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilePolicyId")]
        public long? FilePolicyId{ get; set; }

        /// <summary>
        /// <p>剪切板重定向策略id。取值范围：<br>1：开启云桌面到客户端<br>2：开启客户端到云桌面<br>3：双向开启<br>4：禁用</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClipPolicyId")]
        public long? ClipPolicyId{ get; set; }

        /// <summary>
        /// <p>外设重定向策略id。取值范围：<br>1：允许usb重定向<br>2：允许端口重定向<br>3：允许usb和端口重定向<br>4：禁用</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DrivePolicyId")]
        public long? DrivePolicyId{ get; set; }

        /// <summary>
        /// <p>水印重定向策略id。取值范围（离散值）：<br>4:   当前时间，居中策略<br>10: 当前时间，平铺策略<br>15:  云桌面ID， 居中策略<br>16:  云桌面ID+当前时间， 居中策略<br>17:  云桌面ID， 平铺策略<br>18:  云桌面ID+当前时间， 平铺策略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaterMarkPolicyId")]
        public long? WaterMarkPolicyId{ get; set; }

        /// <summary>
        /// <p>是否是默认策略</p>
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// <p>注意：默认策略的当前值无效</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalUser")]
        public long? TotalUser{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "FilePolicyId", this.FilePolicyId);
            this.SetParamSimple(map, prefix + "ClipPolicyId", this.ClipPolicyId);
            this.SetParamSimple(map, prefix + "DrivePolicyId", this.DrivePolicyId);
            this.SetParamSimple(map, prefix + "WaterMarkPolicyId", this.WaterMarkPolicyId);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "TotalUser", this.TotalUser);
        }
    }
}

