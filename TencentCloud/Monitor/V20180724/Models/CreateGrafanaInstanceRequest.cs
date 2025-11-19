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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateGrafanaInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// VPC ID (私有网络 ID)
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网 ID 数组(VPC ID下的子网 ID，只取第一个)。
        /// 注意：并不是所有可用区都可用（可通过 monitor:DescribePrometheusZones 接口获取可用区状态，选择 ZoneState 和ZoneResourceState 都为1的可用区）
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 是否启用外网
        /// </summary>
        [JsonProperty("EnableInternet")]
        public bool? EnableInternet{ get; set; }

        /// <summary>
        /// Grafana 初始密码(国际站用户必填，国内站用户可不填，不填时会生成随机密码并给主账号发送通知)
        /// </summary>
        [JsonProperty("GrafanaInitPassword")]
        public string GrafanaInitPassword{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("TagSpecification")]
        public PrometheusTag[] TagSpecification{ get; set; }

        /// <summary>
        /// 是否自动选择代金券，默认为 false
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "EnableInternet", this.EnableInternet);
            this.SetParamSimple(map, prefix + "GrafanaInitPassword", this.GrafanaInitPassword);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
        }
    }
}

