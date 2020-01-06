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

namespace TencentCloud.Bmvpc.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpcPeerConnection : AbstractModel
    {
        
        /// <summary>
        /// 本端VPC唯一ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 对端VPC唯一ID
        /// </summary>
        [JsonProperty("PeerVpcId")]
        public string PeerVpcId{ get; set; }

        /// <summary>
        /// 本端APPID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 对端APPID
        /// </summary>
        [JsonProperty("PeerAppId")]
        public string PeerAppId{ get; set; }

        /// <summary>
        /// 对等连接唯一ID
        /// </summary>
        [JsonProperty("VpcPeerConnectionId")]
        public string VpcPeerConnectionId{ get; set; }

        /// <summary>
        /// 对等连接名称
        /// </summary>
        [JsonProperty("VpcPeerConnectionName")]
        public string VpcPeerConnectionName{ get; set; }

        /// <summary>
        /// 对等连接状态
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 本端VPC所属可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcZone")]
        public string VpcZone{ get; set; }

        /// <summary>
        /// 对端VPC所属可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeerVpcZone")]
        public string PeerVpcZone{ get; set; }

        /// <summary>
        /// 本端Uin
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// 对端Uin
        /// </summary>
        [JsonProperty("PeerUin")]
        public ulong? PeerUin{ get; set; }

        /// <summary>
        /// 对等连接类型
        /// </summary>
        [JsonProperty("PeerType")]
        public ulong? PeerType{ get; set; }

        /// <summary>
        /// 对等连接带宽
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 本端VPC地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 对端VPC地域
        /// </summary>
        [JsonProperty("PeerRegion")]
        public string PeerRegion{ get; set; }

        /// <summary>
        /// 是否允许删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeleteFlag")]
        public ulong? DeleteFlag{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "PeerVpcId", this.PeerVpcId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PeerAppId", this.PeerAppId);
            this.SetParamSimple(map, prefix + "VpcPeerConnectionId", this.VpcPeerConnectionId);
            this.SetParamSimple(map, prefix + "VpcPeerConnectionName", this.VpcPeerConnectionName);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "VpcZone", this.VpcZone);
            this.SetParamSimple(map, prefix + "PeerVpcZone", this.PeerVpcZone);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "PeerUin", this.PeerUin);
            this.SetParamSimple(map, prefix + "PeerType", this.PeerType);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "PeerRegion", this.PeerRegion);
            this.SetParamSimple(map, prefix + "DeleteFlag", this.DeleteFlag);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

