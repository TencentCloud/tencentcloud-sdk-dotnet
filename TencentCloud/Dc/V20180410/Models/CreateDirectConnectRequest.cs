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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDirectConnectRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>物理专线的名称。</p>
        /// </summary>
        [JsonProperty("DirectConnectName")]
        public string DirectConnectName{ get; set; }

        /// <summary>
        /// <p>物理专线所在的接入点。<br>您可以通过调用<a href="https://cloud.tencent.com/document/product/216/34827">DescribeAccessPoints</a>接口获取接入点ID。</p>
        /// </summary>
        [JsonProperty("AccessPointId")]
        public string AccessPointId{ get; set; }

        /// <summary>
        /// <p>提供接入物理专线的运营商。<br>ChinaTelecom：中国电信；<br>ChinaMobile：中国移动；<br>ChinaUnicom：中国联通；<br> In-houseWiring：楼内线；<br>ChinaOther：中国其他；<br> InternationalOperator：境外其他。</p>
        /// </summary>
        [JsonProperty("LineOperator")]
        public string LineOperator{ get; set; }

        /// <summary>
        /// <p>物理专线接入端口类型，取值：<br>100Base-T：百兆电口；<br>1000Base-T（默认值）：千兆电口；<br>1000Base-LX：千兆单模光口（10千米）；<br>10GBase-T：万兆电口；<br>10GBase-LR（默认值）：万兆单模光口（10千米）。</p>
        /// </summary>
        [JsonProperty("PortType")]
        public string PortType{ get; set; }

        /// <summary>
        /// <p>运营商或者服务商为物理专线提供的电路编码。</p>
        /// </summary>
        [JsonProperty("CircuitCode")]
        public string CircuitCode{ get; set; }

        /// <summary>
        /// <p>本地数据中心的地理位置。</p>
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// <p>物理专线接入接口带宽，单位为Mbps，默认值为1000，取值范围为 [2, 10240]。</p>
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// <p>冗余物理专线的ID。</p>
        /// </summary>
        [JsonProperty("RedundantDirectConnectId")]
        public string RedundantDirectConnectId{ get; set; }

        /// <summary>
        /// <p>物理专线调试VLAN。默认开启VLAN，自动分配VLAN。</p>
        /// </summary>
        [JsonProperty("Vlan")]
        public long? Vlan{ get; set; }

        /// <summary>
        /// <p>物理专线调试腾讯侧互联 IP。默认自动分配。</p>
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// <p>物理专线调试用户侧互联 IP。默认自动分配。</p>
        /// </summary>
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress{ get; set; }

        /// <summary>
        /// <p>物理专线申请者姓名。默认从账户体系获取。</p>
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// <p>物理专线申请者联系邮箱。默认从账户体系获取。</p>
        /// </summary>
        [JsonProperty("CustomerContactMail")]
        public string CustomerContactMail{ get; set; }

        /// <summary>
        /// <p>物理专线申请者联系号码。默认从账户体系获取。</p>
        /// </summary>
        [JsonProperty("CustomerContactNumber")]
        public string CustomerContactNumber{ get; set; }

        /// <summary>
        /// <p>报障联系人。</p>
        /// </summary>
        [JsonProperty("FaultReportContactPerson")]
        public string FaultReportContactPerson{ get; set; }

        /// <summary>
        /// <p>报障联系电话。</p>
        /// </summary>
        [JsonProperty("FaultReportContactNumber")]
        public string FaultReportContactNumber{ get; set; }

        /// <summary>
        /// <p>报障联系邮箱。</p>
        /// </summary>
        [JsonProperty("FaultReportContactEmail")]
        public string FaultReportContactEmail{ get; set; }

        /// <summary>
        /// <p>物理专线申请者是否签署了用户使用协议。默认已签署。</p>
        /// </summary>
        [JsonProperty("SignLaw")]
        public bool? SignLaw{ get; set; }

        /// <summary>
        /// <p>标签键值对</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>是否MACsec需求</p>
        /// </summary>
        [JsonProperty("IsMacSec")]
        public bool? IsMacSec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectName", this.DirectConnectName);
            this.SetParamSimple(map, prefix + "AccessPointId", this.AccessPointId);
            this.SetParamSimple(map, prefix + "LineOperator", this.LineOperator);
            this.SetParamSimple(map, prefix + "PortType", this.PortType);
            this.SetParamSimple(map, prefix + "CircuitCode", this.CircuitCode);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "RedundantDirectConnectId", this.RedundantDirectConnectId);
            this.SetParamSimple(map, prefix + "Vlan", this.Vlan);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "CustomerContactMail", this.CustomerContactMail);
            this.SetParamSimple(map, prefix + "CustomerContactNumber", this.CustomerContactNumber);
            this.SetParamSimple(map, prefix + "FaultReportContactPerson", this.FaultReportContactPerson);
            this.SetParamSimple(map, prefix + "FaultReportContactNumber", this.FaultReportContactNumber);
            this.SetParamSimple(map, prefix + "FaultReportContactEmail", this.FaultReportContactEmail);
            this.SetParamSimple(map, prefix + "SignLaw", this.SignLaw);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "IsMacSec", this.IsMacSec);
        }
    }
}

