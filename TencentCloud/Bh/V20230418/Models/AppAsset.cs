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

    public class AppAsset : AbstractModel
    {
        
        /// <summary>
        /// 应用资产id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 应用服务器id
        /// </summary>
        [JsonProperty("DeviceId")]
        public ulong? DeviceId{ get; set; }

        /// <summary>
        /// 应用服务器账号id
        /// </summary>
        [JsonProperty("DeviceAccountId")]
        public ulong? DeviceAccountId{ get; set; }

        /// <summary>
        /// 应用资产类型。1-web应用
        /// </summary>
        [JsonProperty("Kind")]
        public ulong? Kind{ get; set; }

        /// <summary>
        /// 客户端工具路径
        /// </summary>
        [JsonProperty("ClientAppPath")]
        public string ClientAppPath{ get; set; }

        /// <summary>
        /// 客户端工具类型
        /// </summary>
        [JsonProperty("ClientAppKind")]
        public string ClientAppKind{ get; set; }

        /// <summary>
        /// 应用资产url
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 托管状态。0-未托管，1-已托管
        /// </summary>
        [JsonProperty("BindStatus")]
        public ulong? BindStatus{ get; set; }

        /// <summary>
        /// 应用服务器实例id
        /// </summary>
        [JsonProperty("DeviceInstanceId")]
        public string DeviceInstanceId{ get; set; }

        /// <summary>
        /// 应用服务器名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 应用服务器账号名称
        /// </summary>
        [JsonProperty("DeviceAccountName")]
        public string DeviceAccountName{ get; set; }

        /// <summary>
        /// 堡垒机实例id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 堡垒机实例信息
        /// </summary>
        [JsonProperty("Resource")]
        public Resource Resource{ get; set; }

        /// <summary>
        /// 网络域id
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// 网络域名称
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 资产组信息
        /// </summary>
        [JsonProperty("GroupSet")]
        public Group[] GroupSet{ get; set; }

        /// <summary>
        /// 资产所属部门
        /// </summary>
        [JsonProperty("Department")]
        public Department Department{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "DeviceAccountId", this.DeviceAccountId);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "ClientAppPath", this.ClientAppPath);
            this.SetParamSimple(map, prefix + "ClientAppKind", this.ClientAppKind);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamSimple(map, prefix + "DeviceInstanceId", this.DeviceInstanceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "DeviceAccountName", this.DeviceAccountName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamArrayObj(map, prefix + "GroupSet.", this.GroupSet);
            this.SetParamObj(map, prefix + "Department.", this.Department);
        }
    }
}

