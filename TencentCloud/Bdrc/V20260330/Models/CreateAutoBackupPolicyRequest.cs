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

    public class CreateAutoBackupPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>定期备份的执行策略。</p>
        /// </summary>
        [JsonProperty("Policy")]
        public Policy[] Policy{ get; set; }

        /// <summary>
        /// <p>通过该定期备份策略创建的备份是否永久保留。false表示非永久保留，true表示永久保留，默认为false。</p>
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// <p>定期备份策略的名称。</p>
        /// </summary>
        [JsonProperty("AutoBackupPolicyName")]
        public string AutoBackupPolicyName{ get; set; }

        /// <summary>
        /// <p>是否激活定期备份策略。</p>
        /// </summary>
        [JsonProperty("IsActivated")]
        public bool? IsActivated{ get; set; }

        /// <summary>
        /// <p>通过定期备份策略创建出的备份保留时间。本参数与 RetentionMonths、RetentionAmount 互斥，不可同时传入。当 IsPermanent 为 false 或不传时，RetentionDays / RetentionMonths / RetentionAmount / AdvancedRetentionPolicy 必须传入至少一项有效值。</p>
        /// </summary>
        [JsonProperty("RetentionDays")]
        public ulong? RetentionDays{ get; set; }

        /// <summary>
        /// <p>该定期备份策略创建的备份可以保留的月数。本参数与 RetentionDays、RetentionAmount 互斥，不可同时传入。当 IsPermanent 为 false 或不传时，RetentionDays / RetentionMonths / RetentionAmount / AdvancedRetentionPolicy 必须传入至少一项有效值。</p>
        /// </summary>
        [JsonProperty("RetentionMonths")]
        public ulong? RetentionMonths{ get; set; }

        /// <summary>
        /// <p>通过该定期备份策略最多保留的备份个数，超过该个数限制后自动删除最先创建的备份。本参数与 RetentionDays、RetentionMonths互斥，不可同时传入。当 IsPermanent 为 false 或不传时，RetentionDays / RetentionMonths / RetentionAmount / AdvancedRetentionPolicy 必须传入至少一项有效值。</p>
        /// </summary>
        [JsonProperty("RetentionAmount")]
        public ulong? RetentionAmount{ get; set; }

        /// <summary>
        /// <p>备份存储类型。COMMON表示走普通模式（不需要备份库），VAULT表示走备份库（必须关联一个备份库）。默认为COMMON</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>备份库ID，创建agent备份策略时必须指定。当StorageType为VAULT时必传。</p>
        /// </summary>
        [JsonProperty("VaultId")]
        public string VaultId{ get; set; }

        /// <summary>
        /// <p>定期备份高级保留策略，该参数不可与 IsPermanent 参数冲突。当 IsPermanent 为 false 或不传、且未传入 RetentionDays / RetentionMonths / RetentionAmount 时，必须传入本参数。</p>
        /// </summary>
        [JsonProperty("AdvancedRetentionPolicy")]
        public AdvancedRetentionPolicy AdvancedRetentionPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Policy.", this.Policy);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "AutoBackupPolicyName", this.AutoBackupPolicyName);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "RetentionDays", this.RetentionDays);
            this.SetParamSimple(map, prefix + "RetentionMonths", this.RetentionMonths);
            this.SetParamSimple(map, prefix + "RetentionAmount", this.RetentionAmount);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "VaultId", this.VaultId);
            this.SetParamObj(map, prefix + "AdvancedRetentionPolicy.", this.AdvancedRetentionPolicy);
        }
    }
}

