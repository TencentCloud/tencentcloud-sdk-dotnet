/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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
        /// 阿里云AccessKey
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
        /// 阿里云rds实例id
        /// </summary>
        [JsonProperty("RdsInstanceId")]
        public string RdsInstanceId{ get; set; }

        /// <summary>
        /// CVM实例短ID，格式如：ins-olgl89y8，与云主机控制台页面显示的实例ID相同，如果是CVM自建实例或者通过自建VPN接入的公网实例，需要传递此字段
        /// </summary>
        [JsonProperty("CvmInstanceId")]
        public string CvmInstanceId{ get; set; }

        /// <summary>
        /// 专线网关ID
        /// </summary>
        [JsonProperty("UniqDcgId")]
        public string UniqDcgId{ get; set; }

        /// <summary>
        /// 私有网络ID，和原来的数字vpcId对应，需要调vpc的接口去转换
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络下的子网ID, 和原来的数字子网ID对应，需要调用vpc的接口去转换
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 系统分配的VPN网关ID
        /// </summary>
        [JsonProperty("UniqVpnGwId")]
        public string UniqVpnGwId{ get; set; }

        /// <summary>
        /// 实例短Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 地域英文名，如：ap-guangzhou
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 服务提供商，如:aliyun,others
        /// </summary>
        [JsonProperty("Supplier")]
        public string Supplier{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
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
        }
    }
}

