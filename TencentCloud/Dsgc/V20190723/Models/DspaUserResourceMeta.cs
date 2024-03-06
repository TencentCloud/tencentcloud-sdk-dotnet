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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspaUserResourceMeta : AbstractModel
    {
        
        /// <summary>
        /// 用户资源ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源名称。
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 资源VIP。
        /// </summary>
        [JsonProperty("ResourceVip")]
        public string ResourceVip{ get; set; }

        /// <summary>
        /// 资源端口。
        /// </summary>
        [JsonProperty("ResourceVPort")]
        public ulong? ResourceVPort{ get; set; }

        /// <summary>
        /// 资源被创建时间。
        /// </summary>
        [JsonProperty("ResourceCreateTime")]
        public string ResourceCreateTime{ get; set; }

        /// <summary>
        /// 用户资源VPC ID 字符串。
        /// </summary>
        [JsonProperty("ResourceUniqueVpcId")]
        public string ResourceUniqueVpcId{ get; set; }

        /// <summary>
        /// 用户资源Subnet ID 字符串。
        /// </summary>
        [JsonProperty("ResourceUniqueSubnetId")]
        public string ResourceUniqueSubnetId{ get; set; }

        /// <summary>
        /// 用户资源类型信息。
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// 资源所处地域。
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 资源被同步时间。
        /// </summary>
        [JsonProperty("ResourceSyncTime")]
        public string ResourceSyncTime{ get; set; }

        /// <summary>
        /// 资源被授权状态。
        /// </summary>
        [JsonProperty("AuthStatus")]
        public string AuthStatus{ get; set; }

        /// <summary>
        /// 资源创建类型，cloud-云原生资源，build-用户自建资源。
        /// </summary>
        [JsonProperty("BuildType")]
        public string BuildType{ get; set; }

        /// <summary>
        /// 主实例ID。
        /// </summary>
        [JsonProperty("MasterInsId")]
        public string MasterInsId{ get; set; }

        /// <summary>
        /// 用户资源VPC ID 整数。
        /// </summary>
        [JsonProperty("ResourceVpcId")]
        public ulong? ResourceVpcId{ get; set; }

        /// <summary>
        /// 用户资源Subnet ID 整数。
        /// </summary>
        [JsonProperty("ResourceSubnetId")]
        public ulong? ResourceSubnetId{ get; set; }

        /// <summary>
        /// 协议类型。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 资源版本号。
        /// </summary>
        [JsonProperty("ResourceVersion")]
        public string ResourceVersion{ get; set; }

        /// <summary>
        /// 授权方式
        /// </summary>
        [JsonProperty("ResourceAuthType")]
        public string ResourceAuthType{ get; set; }

        /// <summary>
        /// 授权账号名
        /// </summary>
        [JsonProperty("ResourceAuthAccount")]
        public string ResourceAuthAccount{ get; set; }

        /// <summary>
        /// x
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// x
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceValue")]
        public string InstanceValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ResourceVip", this.ResourceVip);
            this.SetParamSimple(map, prefix + "ResourceVPort", this.ResourceVPort);
            this.SetParamSimple(map, prefix + "ResourceCreateTime", this.ResourceCreateTime);
            this.SetParamSimple(map, prefix + "ResourceUniqueVpcId", this.ResourceUniqueVpcId);
            this.SetParamSimple(map, prefix + "ResourceUniqueSubnetId", this.ResourceUniqueSubnetId);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "ResourceSyncTime", this.ResourceSyncTime);
            this.SetParamSimple(map, prefix + "AuthStatus", this.AuthStatus);
            this.SetParamSimple(map, prefix + "BuildType", this.BuildType);
            this.SetParamSimple(map, prefix + "MasterInsId", this.MasterInsId);
            this.SetParamSimple(map, prefix + "ResourceVpcId", this.ResourceVpcId);
            this.SetParamSimple(map, prefix + "ResourceSubnetId", this.ResourceSubnetId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ResourceVersion", this.ResourceVersion);
            this.SetParamSimple(map, prefix + "ResourceAuthType", this.ResourceAuthType);
            this.SetParamSimple(map, prefix + "ResourceAuthAccount", this.ResourceAuthAccount);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceValue", this.InstanceValue);
        }
    }
}

