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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupGroup : AbstractModel
    {
        
        /// <summary>
        /// 备份组ID。
        /// </summary>
        [JsonProperty("BackupGroupId")]
        public string BackupGroupId{ get; set; }

        /// <summary>
        /// 备份组创建进度。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// 备份和云盘绑定关系
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupBindDisk")]
        public ApplyDisk[] BackupBindDisk{ get; set; }

        /// <summary>
        /// 备份组名称。
        /// </summary>
        [JsonProperty("BackupGroupName")]
        public string BackupGroupName{ get; set; }

        /// <summary>
        /// 备份组状态。NORMAL: 正常；CREATING: 创建中；ROLLBACKING: 回滚中
        /// </summary>
        [JsonProperty("BackupGroupState")]
        public string BackupGroupState{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 用户AppId。
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 是否为永久备份组。
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// 备份组的到期时间。如果为永久备份组，则取值为null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// 创建备份组的实例ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 创建备份组时刻实例的详情。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceDetails")]
        public string InstanceDetails{ get; set; }

        /// <summary>
        /// 创建人名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// 主账号uin。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountUin")]
        public string AccountUin{ get; set; }

        /// <summary>
        /// 创建备份的子账号uin。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// 创建当前备份的定期备份策略ID，为null则为手动创建的备份。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoBackupPolicyId")]
        public string AutoBackupPolicyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupGroupId", this.BackupGroupId);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamArrayObj(map, prefix + "BackupBindDisk.", this.BackupBindDisk);
            this.SetParamSimple(map, prefix + "BackupGroupName", this.BackupGroupName);
            this.SetParamSimple(map, prefix + "BackupGroupState", this.BackupGroupState);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceDetails", this.InstanceDetails);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "AutoBackupPolicyId", this.AutoBackupPolicyId);
        }
    }
}

