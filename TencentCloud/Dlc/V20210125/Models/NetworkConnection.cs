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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkConnection : AbstractModel
    {
        
        /// <summary>
        /// 网络配置id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 网络配置唯一标志符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssociateId")]
        public string AssociateId{ get; set; }

        /// <summary>
        /// 计算引擎id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HouseId")]
        public string HouseId{ get; set; }

        /// <summary>
        /// 数据源id(已废弃)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceConnectionId")]
        public string DatasourceConnectionId{ get; set; }

        /// <summary>
        /// 网络配置状态（0-初始化，1-正常）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 创建用户Appid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Appid")]
        public long? Appid{ get; set; }

        /// <summary>
        /// 计算引擎名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HouseName")]
        public string HouseName{ get; set; }

        /// <summary>
        /// 网络配置名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// 网络配置类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkConnectionType")]
        public long? NetworkConnectionType{ get; set; }

        /// <summary>
        /// 创建用户uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 创建用户SubAccountUin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// 网络配置描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkConnectionDesc")]
        public string NetworkConnectionDesc{ get; set; }

        /// <summary>
        /// 数据源vpcid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceConnectionVpcId")]
        public string DatasourceConnectionVpcId{ get; set; }

        /// <summary>
        /// 数据源SubnetId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceConnectionSubnetId")]
        public string DatasourceConnectionSubnetId{ get; set; }

        /// <summary>
        /// 数据源SubnetId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceConnectionCidrBlock")]
        public string DatasourceConnectionCidrBlock{ get; set; }

        /// <summary>
        /// 数据源SubnetCidrBlock
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceConnectionSubnetCidrBlock")]
        public string DatasourceConnectionSubnetCidrBlock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AssociateId", this.AssociateId);
            this.SetParamSimple(map, prefix + "HouseId", this.HouseId);
            this.SetParamSimple(map, prefix + "DatasourceConnectionId", this.DatasourceConnectionId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "HouseName", this.HouseName);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamSimple(map, prefix + "NetworkConnectionType", this.NetworkConnectionType);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "NetworkConnectionDesc", this.NetworkConnectionDesc);
            this.SetParamSimple(map, prefix + "DatasourceConnectionVpcId", this.DatasourceConnectionVpcId);
            this.SetParamSimple(map, prefix + "DatasourceConnectionSubnetId", this.DatasourceConnectionSubnetId);
            this.SetParamSimple(map, prefix + "DatasourceConnectionCidrBlock", this.DatasourceConnectionCidrBlock);
            this.SetParamSimple(map, prefix + "DatasourceConnectionSubnetCidrBlock", this.DatasourceConnectionSubnetCidrBlock);
        }
    }
}

