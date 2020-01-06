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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoSnapshotPolicy : AbstractModel
    {
        
        /// <summary>
        /// 定期快照策略ID。
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// 定期快照策略名称。
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyName")]
        public string AutoSnapshotPolicyName{ get; set; }

        /// <summary>
        /// 定期快照策略的状态。取值范围：<br><li>NORMAL：正常<br><li>ISOLATED：已隔离。
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyState")]
        public string AutoSnapshotPolicyState{ get; set; }

        /// <summary>
        /// 定期快照策略是否激活。
        /// </summary>
        [JsonProperty("IsActivated")]
        public bool? IsActivated{ get; set; }

        /// <summary>
        /// 使用该定期快照策略创建出来的快照是否永久保留。
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// 使用该定期快照策略创建出来的快照保留天数。
        /// </summary>
        [JsonProperty("RetentionDays")]
        public ulong? RetentionDays{ get; set; }

        /// <summary>
        /// 定期快照策略的创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 定期快照下次触发的时间。
        /// </summary>
        [JsonProperty("NextTriggerTime")]
        public string NextTriggerTime{ get; set; }

        /// <summary>
        /// 定期快照的执行策略。
        /// </summary>
        [JsonProperty("Policy")]
        public Policy[] Policy{ get; set; }

        /// <summary>
        /// 已绑定当前定期快照策略的云盘ID列表。
        /// </summary>
        [JsonProperty("DiskIdSet")]
        public string[] DiskIdSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyName", this.AutoSnapshotPolicyName);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyState", this.AutoSnapshotPolicyState);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "RetentionDays", this.RetentionDays);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "NextTriggerTime", this.NextTriggerTime);
            this.SetParamArrayObj(map, prefix + "Policy.", this.Policy);
            this.SetParamArraySimple(map, prefix + "DiskIdSet.", this.DiskIdSet);
        }
    }
}

