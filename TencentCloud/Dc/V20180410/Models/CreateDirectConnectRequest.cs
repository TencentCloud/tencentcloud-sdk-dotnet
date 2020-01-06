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

    public class CreateDirectConnectRequest : AbstractModel
    {
        
        /// <summary>
        /// 物理专线的名称。
        /// </summary>
        [JsonProperty("DirectConnectName")]
        public string DirectConnectName{ get; set; }

        /// <summary>
        /// 物理专线所在的接入点。
        /// 您可以通过调用 DescribeAccessPoints接口获取地域ID。所选择的接入点必须存在且处于可接入的状态。
        /// </summary>
        [JsonProperty("AccessPointId")]
        public string AccessPointId{ get; set; }

        /// <summary>
        /// 提供接入物理专线的运营商。ChinaTelecom：中国电信， ChinaMobile：中国移动，ChinaUnicom：中国联通， In-houseWiring：楼内线，ChinaOther：中国其他， InternationalOperator：境外其他。
        /// </summary>
        [JsonProperty("LineOperator")]
        public string LineOperator{ get; set; }

        /// <summary>
        /// 本地数据中心的地理位置。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 物理专线接入端口类型,取值：100Base-T：百兆电口,1000Base-T（默认值）：千兆电口,1000Base-LX：千兆单模光口（10千米）,10GBase-T：万兆电口10GBase-LR：万兆单模光口（10千米），默认值，千兆单模光口（10千米）。
        /// </summary>
        [JsonProperty("PortType")]
        public string PortType{ get; set; }

        /// <summary>
        /// 运营商或者服务商为物理专线提供的电路编码。
        /// </summary>
        [JsonProperty("CircuitCode")]
        public string CircuitCode{ get; set; }

        /// <summary>
        /// 物理专线接入接口带宽，单位为Mbps，默认值为1000，取值范围为 [2, 10240]。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 冗余物理专线的ID。
        /// </summary>
        [JsonProperty("RedundantDirectConnectId")]
        public string RedundantDirectConnectId{ get; set; }

        /// <summary>
        /// 物理专线调试VLAN。默认开启VLAN，自动分配VLAN。
        /// </summary>
        [JsonProperty("Vlan")]
        public long? Vlan{ get; set; }

        /// <summary>
        /// 物理专线调试腾讯侧互联 IP。默认自动分配。
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// 物理专线调试用户侧互联 IP。默认自动分配。
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
            this.SetParamSimple(map, prefix + "DirectConnectName", this.DirectConnectName);
            this.SetParamSimple(map, prefix + "AccessPointId", this.AccessPointId);
            this.SetParamSimple(map, prefix + "LineOperator", this.LineOperator);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "PortType", this.PortType);
            this.SetParamSimple(map, prefix + "CircuitCode", this.CircuitCode);
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
        }
    }
}

