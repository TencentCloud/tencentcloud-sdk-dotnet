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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostItem : AbstractModel
    {
        
        /// <summary>
        /// cdh实例所在的位置。通过该参数可以指定实例所属可用区，所属项目等属性。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// cdh实例id
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// cdh实例类型
        /// </summary>
        [JsonProperty("HostType")]
        public string HostType{ get; set; }

        /// <summary>
        /// cdh实例名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// cdh实例付费模式
        /// </summary>
        [JsonProperty("HostChargeType")]
        public string HostChargeType{ get; set; }

        /// <summary>
        /// cdh实例自动续费标记
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// cdh实例创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// cdh实例过期时间
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// cdh实例上已创建云子机的实例id列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// cdh实例状态
        /// </summary>
        [JsonProperty("HostState")]
        public string HostState{ get; set; }

        /// <summary>
        /// cdh实例ip
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// cdh实例资源信息
        /// </summary>
        [JsonProperty("HostResource")]
        public HostResource HostResource{ get; set; }

        /// <summary>
        /// 专用宿主机所属的围笼ID。该字段仅对金融专区围笼内的专用宿主机有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CageId")]
        public string CageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostChargeType", this.HostChargeType);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "HostState", this.HostState);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamObj(map, prefix + "HostResource.", this.HostResource);
            this.SetParamSimple(map, prefix + "CageId", this.CageId);
        }
    }
}

