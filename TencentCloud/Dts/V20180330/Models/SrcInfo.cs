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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SrcInfo : AbstractModel
    {
        
        /// <summary>
        /// 阿里云AccessKey。源库是阿里云RDS5.6适用
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// 实例的IP地址
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 实例的端口
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 实例的用户名
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 实例的密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 阿里云RDS实例ID。源库是阿里云RDS5.6/5.6适用
        /// </summary>
        [JsonProperty("RdsInstanceId")]
        public string RdsInstanceId{ get; set; }

        /// <summary>
        /// CVM实例短ID，格式如：ins-olgl39y8，与云主机控制台页面显示的实例ID相同。如果是CVM自建实例，需要传递此字段
        /// </summary>
        [JsonProperty("CvmInstanceId")]
        public string CvmInstanceId{ get; set; }

        /// <summary>
        /// 专线网关ID，格式如：dcg-0rxtqqxb
        /// </summary>
        [JsonProperty("UniqDcgId")]
        public string UniqDcgId{ get; set; }

        /// <summary>
        /// 私有网络ID，格式如：vpc-92jblxto
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络下的子网ID，格式如：subnet-3paxmkdz
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// VPN网关ID，格式如：vpngw-9ghexg7q
        /// </summary>
        [JsonProperty("UniqVpnGwId")]
        public string UniqVpnGwId{ get; set; }

        /// <summary>
        /// 数据库实例ID，格式如：cdb-powiqx8q
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 地域英文名，如：ap-guangzhou
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 当实例为RDS实例时，填写为aliyun, 其他情况均填写others
        /// </summary>
        [JsonProperty("Supplier")]
        public string Supplier{ get; set; }

        /// <summary>
        /// 云联网ID，如：ccn-afp6kltc
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 数据库版本，当实例为RDS实例时才有效，格式如：5.6或者5.7，默认为5.6
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "RdsInstanceId", this.RdsInstanceId);
            this.SetParamSimple(map, prefix + "CvmInstanceId", this.CvmInstanceId);
            this.SetParamSimple(map, prefix + "UniqDcgId", this.UniqDcgId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "UniqVpnGwId", this.UniqVpnGwId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Supplier", this.Supplier);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
        }
    }
}

