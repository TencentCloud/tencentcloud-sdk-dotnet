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

    public class AutoBackupPolicy : AbstractModel
    {
        
        /// <summary>
        /// 定期备份策略是否激活。
        /// </summary>
        [JsonProperty("IsActivated")]
        public bool? IsActivated{ get; set; }

        /// <summary>
        /// 使用该定期备份策略创建出来的备份是否永久保留。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// 使用该定期备份策略创建出来的备份是否永久保留。
        /// </summary>
        [JsonProperty("NextTriggerTime")]
        public string NextTriggerTime{ get; set; }

        /// <summary>
        /// NORMAL
        /// </summary>
        [JsonProperty("AutoBackupPolicyState")]
        public string AutoBackupPolicyState{ get; set; }

        /// <summary>
        /// 备份策略的名称。
        /// </summary>
        [JsonProperty("AutoBackupPolicyName")]
        public string AutoBackupPolicyName{ get; set; }

        /// <summary>
        /// 定期备份的执行策略。
        /// </summary>
        [JsonProperty("Policy")]
        public Policy[] Policy{ get; set; }

        /// <summary>
        /// 备份策略ID。
        /// </summary>
        [JsonProperty("AutoBackupPolicyId")]
        public string AutoBackupPolicyId{ get; set; }

        /// <summary>
        /// 备份策略的创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 使用该定期备份策略创建出来的备份保留天数。
        /// </summary>
        [JsonProperty("RetentionDays")]
        public ulong? RetentionDays{ get; set; }

        /// <summary>
        /// 用户AppId。
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 定期备份策略绑定的实例ID列表。
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// 该定期快照创建的快照最大保留月数
        /// </summary>
        [JsonProperty("RetentionMonths")]
        public ulong? RetentionMonths{ get; set; }

        /// <summary>
        /// 该定期快照创建的快照最大保留数量
        /// </summary>
        [JsonProperty("RetentionAmount")]
        public ulong? RetentionAmount{ get; set; }

        /// <summary>
        /// 创建人。
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
        /// 子账号uin。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// 策略存储类型
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 备份库ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VaultId")]
        public string VaultId{ get; set; }

        /// <summary>
        /// 高级保留策略
        /// </summary>
        [JsonProperty("AdvancedRetentionPolicy")]
        public AdvancedRetentionPolicy AdvancedRetentionPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "NextTriggerTime", this.NextTriggerTime);
            this.SetParamSimple(map, prefix + "AutoBackupPolicyState", this.AutoBackupPolicyState);
            this.SetParamSimple(map, prefix + "AutoBackupPolicyName", this.AutoBackupPolicyName);
            this.SetParamArrayObj(map, prefix + "Policy.", this.Policy);
            this.SetParamSimple(map, prefix + "AutoBackupPolicyId", this.AutoBackupPolicyId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RetentionDays", this.RetentionDays);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "RetentionMonths", this.RetentionMonths);
            this.SetParamSimple(map, prefix + "RetentionAmount", this.RetentionAmount);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "VaultId", this.VaultId);
            this.SetParamObj(map, prefix + "AdvancedRetentionPolicy.", this.AdvancedRetentionPolicy);
        }
    }
}

