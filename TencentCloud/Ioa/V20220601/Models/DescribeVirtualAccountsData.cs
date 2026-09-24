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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVirtualAccountsData : AbstractModel
    {
        
        /// <summary>
        /// <p>Id(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>用户账号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>账户分组Id(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public ulong? AccountGroupId{ get; set; }

        /// <summary>
        /// <p>账户组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>关联服务器名称(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountId")]
        public ulong? AccountId{ get; set; }

        /// <summary>
        /// <p>账户源(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// <p>状态(只支持32位)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>账户namepath</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NamePath")]
        public string NamePath{ get; set; }

        /// <summary>
        /// <p>账户扩展信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public string ExtraInfo{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Itime")]
        public string Itime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Utime")]
        public string Utime{ get; set; }

        /// <summary>
        /// <p>多OU组信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountGroups")]
        public DescribeAccountAccountGroupsData[] AccountGroups{ get; set; }

        /// <summary>
        /// <p>绑定PC端数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PcBindNum")]
        public long? PcBindNum{ get; set; }

        /// <summary>
        /// <p>绑定移动端数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MobileBindNum")]
        public long? MobileBindNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "AccountGroupId", this.AccountGroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "NamePath", this.NamePath);
            this.SetParamSimple(map, prefix + "ExtraInfo", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "Itime", this.Itime);
            this.SetParamSimple(map, prefix + "Utime", this.Utime);
            this.SetParamArrayObj(map, prefix + "AccountGroups.", this.AccountGroups);
            this.SetParamSimple(map, prefix + "PcBindNum", this.PcBindNum);
            this.SetParamSimple(map, prefix + "MobileBindNum", this.MobileBindNum);
        }
    }
}

