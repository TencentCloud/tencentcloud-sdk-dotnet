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

    public class CreatePrometheusMultiTenantInstancePostPayModeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例名</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>VPC ID(可通过 vpc:DescribeVpcs 接口获取，与实例同地域)</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网 ID(可通过 vpc:DescribeSubnets 接口获取)</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>数据存储时间（单位天），限制值为15, 30, 45, 90, 180, 365, 730之一</p>
        /// </summary>
        [JsonProperty("DataRetentionTime")]
        public long? DataRetentionTime{ get; set; }

        /// <summary>
        /// <p>可用区(与子网同可用区)</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>实例的标签</p>
        /// </summary>
        [JsonProperty("TagSpecification")]
        public PrometheusTag[] TagSpecification{ get; set; }

        /// <summary>
        /// <p>需要关联的 Grafana 实例</p>
        /// </summary>
        [JsonProperty("GrafanaInstanceId")]
        public string GrafanaInstanceId{ get; set; }

        /// <summary>
        /// <p>标识prom实例特殊属性</p><p>归档存储时长(天):<br>key: LongTermStorageRetentionTime<br>value: 60-730</p>
        /// </summary>
        [JsonProperty("InstanceAttributes")]
        public PrometheusRuleKV[] InstanceAttributes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DataRetentionTime", this.DataRetentionTime);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "GrafanaInstanceId", this.GrafanaInstanceId);
            this.SetParamArrayObj(map, prefix + "InstanceAttributes.", this.InstanceAttributes);
        }
    }
}

