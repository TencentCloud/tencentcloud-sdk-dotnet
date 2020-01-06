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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDirectConnectAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 物理专线的ID。
        /// </summary>
        [JsonProperty("DirectConnectId")]
        public string DirectConnectId{ get; set; }

        /// <summary>
        /// 物理专线名称。
        /// </summary>
        [JsonProperty("DirectConnectName")]
        public string DirectConnectName{ get; set; }

        /// <summary>
        /// 运营商或者服务商为物理专线提供的电路编码。
        /// </summary>
        [JsonProperty("CircuitCode")]
        public string CircuitCode{ get; set; }

        /// <summary>
        /// 物理专线调试VLAN。
        /// </summary>
        [JsonProperty("Vlan")]
        public long? Vlan{ get; set; }

        /// <summary>
        /// 物理专线调试腾讯侧互联 IP。
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// 物理专线调试用户侧互联 IP。
        /// </summary>
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress{ get; set; }

        /// <summary>
        /// 物理专线申请者姓名。默认从账户体系获取。
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// 物理专线申请者联系邮箱。默认从账户体系获取。
        /// </summary>
        [JsonProperty("CustomerContactMail")]
        public string CustomerContactMail{ get; set; }

        /// <summary>
        /// 物理专线申请者联系号码。默认从账户体系获取。
        /// </summary>
        [JsonProperty("CustomerContactNumber")]
        public string CustomerContactNumber{ get; set; }

        /// <summary>
        /// 报障联系人。
        /// </summary>
        [JsonProperty("FaultReportContactPerson")]
        public string FaultReportContactPerson{ get; set; }

        /// <summary>
        /// 报障联系电话。
        /// </summary>
        [JsonProperty("FaultReportContactNumber")]
        public string FaultReportContactNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectId", this.DirectConnectId);
            this.SetParamSimple(map, prefix + "DirectConnectName", this.DirectConnectName);
            this.SetParamSimple(map, prefix + "CircuitCode", this.CircuitCode);
            this.SetParamSimple(map, prefix + "Vlan", this.Vlan);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "CustomerContactMail", this.CustomerContactMail);
            this.SetParamSimple(map, prefix + "CustomerContactNumber", this.CustomerContactNumber);
            this.SetParamSimple(map, prefix + "FaultReportContactPerson", this.FaultReportContactPerson);
            this.SetParamSimple(map, prefix + "FaultReportContactNumber", this.FaultReportContactNumber);
        }
    }
}

