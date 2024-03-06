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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLogKafkaAccessRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例名称 如 主机安全测试环境
        /// </summary>
        [JsonProperty("KafkaEnvName")]
        public string KafkaEnvName{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("KafkaId")]
        public string KafkaId{ get; set; }

        /// <summary>
        /// 接入方式，1公网域名接入，2支撑环境接入
        /// </summary>
        [JsonProperty("AccessType")]
        public ulong? AccessType{ get; set; }

        /// <summary>
        /// 接入地址
        /// </summary>
        [JsonProperty("AccessAddr")]
        public string AccessAddr{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 0不用密码，1有密码
        /// </summary>
        [JsonProperty("HasPwd")]
        public ulong? HasPwd{ get; set; }

        /// <summary>
        /// 日志投递类型配置细节
        /// </summary>
        [JsonProperty("DeliverTypeDetails")]
        public DeliverTypeDetails[] DeliverTypeDetails{ get; set; }

        /// <summary>
        /// kafka版本
        /// </summary>
        [JsonProperty("InsVersion")]
        public string InsVersion{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Az")]
        public string Az{ get; set; }

        /// <summary>
        /// vpcid地址
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 投递状态，1：健康，2：告警，3：异常
        /// </summary>
        [JsonProperty("DeliverStatus")]
        public long? DeliverStatus{ get; set; }

        /// <summary>
        /// 峰值带宽
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// 磁盘容量
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 密码，aes加密
        /// </summary>
        [JsonProperty("Pwd")]
        public string Pwd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KafkaEnvName", this.KafkaEnvName);
            this.SetParamSimple(map, prefix + "KafkaId", this.KafkaId);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "AccessAddr", this.AccessAddr);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "HasPwd", this.HasPwd);
            this.SetParamArrayObj(map, prefix + "DeliverTypeDetails.", this.DeliverTypeDetails);
            this.SetParamSimple(map, prefix + "InsVersion", this.InsVersion);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Az", this.Az);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DeliverStatus", this.DeliverStatus);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "Pwd", this.Pwd);
        }
    }
}

