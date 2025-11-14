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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalDevice : AbstractModel
    {
        
        /// <summary>
        /// 操作系统名称，只能是Linux、Windows或MySQL
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 管理端口
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 主机名，可为空
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 资产所属的部门ID
        /// </summary>
        [JsonProperty("DepartmentId")]
        public string DepartmentId{ get; set; }

        /// <summary>
        /// 资产多节点：字段ip和端口
        /// </summary>
        [JsonProperty("IpPortSet")]
        public string[] IpPortSet{ get; set; }

        /// <summary>
        /// 是否启用SSL,1:启用 0：禁用，仅支持Redis资产
        /// </summary>
        [JsonProperty("EnableSSL")]
        public long? EnableSSL{ get; set; }

        /// <summary>
        /// SSL证书，EnableSSL时必填
        /// </summary>
        [JsonProperty("SSLCert")]
        public string SSLCert{ get; set; }

        /// <summary>
        /// SSL证书名称，EnableSSL时必填
        /// </summary>
        [JsonProperty("SSLCertName")]
        public string SSLCertName{ get; set; }

        /// <summary>
        /// 资产实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 资产所属地域
        /// </summary>
        [JsonProperty("ApCode")]
        public string ApCode{ get; set; }

        /// <summary>
        /// 地域名称
        /// </summary>
        [JsonProperty("ApName")]
        public string ApName{ get; set; }

        /// <summary>
        /// 资产所属VPC
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 资产所属子网
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DepartmentId", this.DepartmentId);
            this.SetParamArraySimple(map, prefix + "IpPortSet.", this.IpPortSet);
            this.SetParamSimple(map, prefix + "EnableSSL", this.EnableSSL);
            this.SetParamSimple(map, prefix + "SSLCert", this.SSLCert);
            this.SetParamSimple(map, prefix + "SSLCertName", this.SSLCertName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ApCode", this.ApCode);
            this.SetParamSimple(map, prefix + "ApName", this.ApName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
        }
    }
}

